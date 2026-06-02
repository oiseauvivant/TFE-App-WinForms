using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_TFE
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        string[] parties;
        string id;
        string sens;
        int total = 0;
        int entree = 0;
        int sortie = 0;
        bool modeEdition = false;

        private List<Panel> listePanelsPorte = new List<Panel>();

        public class PortItem
        {
            public string Name { get; set; }
            public override string ToString() => Name;
        }

        public Form1()
        {
            InitializeComponent();
            //id=1;sens=entree;nbr=1

            LoadPorts();
            
        }

        private void CreerPortePanels()
        {
            PnlPiece.Controls.Clear();
            listePanelsPorte.Clear();

            int count = (int)NUPNbrPorte.Value;

            for (int i = 0; i < count; i++)
            {
                Panel p = new Panel();
                p.Width = 40;
                p.Height = 40;
                p.BackColor = Color.Gray;
                p.BorderStyle = BorderStyle.FixedSingle;

                if (i < 5)
                {
                    p.Left = 20 + (i * 40);
                    p.Top = 20;
                }
                else if (i >= 5)
                {
                    p.Left = 20 + ((i - 5) * 40);
                    p.Top = 20 + 40;
                }

                listePanelsPorte.Add(p);

                PnlPiece.Controls.Add(p);
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_DEVICECHANGE = 0x0219;
            const int DBT_DEVICEARRIVAL = 0x8000;
            const int DBT_DEVICEREMOVECOMPLETE = 0x8004;

            if (m.Msg == WM_DEVICECHANGE)
            {
                if (m.WParam.ToInt32() == DBT_DEVICEARRIVAL)
                {
                    // Un appareil vient d'être branché
                    LoadPorts();
                    DetectionAutoESP32();
                }
                else if (m.WParam.ToInt32() == DBT_DEVICEREMOVECOMPLETE)
                {
                    // Un appareil vient d'être débranché
                    this.Text = "Déconnecté";
                    LoadPorts();
                }
            }

            base.WndProc(ref m);
        }

        private void Detection(object sender, EventArgs e)
        {
            DetectionAutoESP32();
        }

        private void LoadPorts()
        {
            string[] ports = SerialPort.GetPortNames();

            var list = ports
                .Select(p => new PortItem { Name = p })
                .ToList();

            cbPorts.DataSource = list;
            cbPorts.DisplayMember = "Name";
        }

        private void DetectionAutoESP32()
        {
            foreach (PortItem port in cbPorts.Items)
            {
                if (PingESP(port.Name))
                {
                    //connexion réussi
                    serialPort = new SerialPort(port.Name, 115200);
                    serialPort.DataReceived += recevoir;
                    serialPort.Open();
                    this.Text = "Connecté à " + port.Name;
                    MessageBox.Show("Connexion réussie au port " + port.Name);
                    
                    cbPorts.SelectedItem = port; // Sélectionne le port dans le ComboBox
                    return;
                }
            } 

            MessageBox.Show("Aucun ESP32 module central détecté !");
        }

        private bool PingESP(string portName)
        {
                try
                {
                    using (SerialPort testPort = new SerialPort(portName, 115200))
                    {
                        testPort.ReadTimeout = 1000; // Timeout de lecture de 1 seconde
                        testPort.Open();
                        testPort.DiscardInBuffer();
                        testPort.DiscardOutBuffer();
                        testPort.WriteLine("PING"); //envoi du ping

                        string response = testPort.ReadLine().Trim();

                        return response == "PONG";
                    }
                }
                catch
                {
                    
                }

            return false; // Si une exception se produit, le port n'est pas celui de l'ESP32
        }

        private void envoyer(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                string message = txtEnvoi.Text; // Récupère le contenu du TextBox
                serialPort.WriteLine(message);  // Envoie au port série
            }
            else
            {
                MessageBox.Show("Port série non ouvert !");
            }
        }

        private void recevoir(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                string messageRecu = serialPort.ReadLine().Trim(); // Lit la ligne reçue
                this.Invoke(new Action(() =>
                {
                    txtEnvoi.Text = messageRecu; // Affiche le message reçu dans le TextBox
                    parties = messageRecu.Split(';');

                    id = parties[0].Split('=')[1];
                    sens = parties[1].Split('=')[1];

                    if (sens == "1")
                    {
                        total++;
                        entree++;
                        lblentree.Text = "Entrées: " + entree.ToString();
                    }
                    else if (sens == "0")
                    {
                        total--;
                        sortie++;
                        lblsortie.Text = "Sorties: " + sortie.ToString();
                    }

                    lblTotal.Text = "Total: " + total.ToString();

                    tmrClignoPorte.Start();
                }));

            }
        }

        private void clignoPorte(object sender, EventArgs e)
        {
            tmrClignoPorte.Stop();
        }

        private void Connexion(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                MessageBox.Show("Déjà connecté.");
                return;
            }
            else if (cbPorts.SelectedItem is PortItem selectedPort)
            {
                try
                {
                    serialPort = new SerialPort(selectedPort.Name, 115200);
                    serialPort.DataReceived += recevoir;
                    serialPort.Open();
                    this.Text = "Connecté à " + selectedPort.Name;
                    MessageBox.Show("Connexion réussie au port " + selectedPort.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion: " + ex.Message);
                }
            }
        }

        private void Deconnexion(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                    this.Text = "Déconnecté";
                    MessageBox.Show("Déconnexion réussie.");
                }
                else                 {
                    MessageBox.Show("Vous êtes déjà déconnecté.");
                }
            }
            catch
            {

            }
        }

        private void NUPPorteChange(object sender, EventArgs e)
        {
            CreerPortePanels();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            CreerPortePanels();
        }

        private void mode_Edition_click(object sender, EventArgs e)
        {
            modeEdition = !modeEdition;

            if (modeEdition) 
            {
                btnEdition.BackColor = Color.Orange;
                pnlTaillePiece.Enabled = true;
            }
            else
            {
                btnEdition.BackColor = SystemColors.Control;
                pnlTaillePiece.Enabled = false;
            }
        }

        private void validerTaillePiece(object sender, EventArgs e)
        {
            PnlPiece.Width = int.Parse(txtTailleX.Text);
            PnlPiece.Height = int.Parse(txtTailleY.Text);
        }
    }
}
