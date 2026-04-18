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
        string nbr;
        int total = 0;
        int entree = 0;
        int sortie = 0;

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
                    serialPort.Open();
                    this.Text += " - Connecté à " + port.Name;
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
                        testPort.ReadTimeout = 500; // Timeout de lecture de 0.5 seconde
                        testPort.Open();
                        //envoi du ping
                        testPort.WriteLine("PING");

                        string response = testPort.ReadLine();

                        return response.Trim() == "PONG";
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
                string messageRecu = serialPort.ReadLine(); // Lit la ligne reçue
                this.Invoke(new Action(() =>
                {
                    txtEnvoi.Text = messageRecu; // Affiche le message reçu dans le TextBox
                    parties = messageRecu.Split(';');

                    id = parties[0].Split('=')[1];
                    sens = parties[1].Split('=')[1];
                    nbr = parties[2].Split('=')[1];

                    if (sens == "entree")
                    {
                        total++;
                        entree++;
                        lblentree.Text = "Entrées: " + entree.ToString();
                    }
                    else if (sens == "sortie")
                    {
                        total--;
                        sortie++;
                        lblsortie.Text = "Sorties: " + sortie.ToString();
                    }

                    lblTotal.Text = "Total: " + total.ToString();

                    if (id == "1")
                    {
                        pnlId1.BackColor = Color.Red;
                    }
                    else if (id == "2")
                    {
                        pnlId2.BackColor = Color.Red; 
                    }
                    else if (id == "3") 
                    {
                        pnlId3.BackColor = Color.Red;
                    }
                    else if (id == "4") 
                    {
                        pnlId4.BackColor = Color.Red;
                    }
                    else if (id == "5") 
                    {
                        pnlId5.BackColor = Color.Red;
                    }
                    else if (id == "6")
                    {
                        pnlId6.BackColor = Color.Red;
                    }
                    else if (id == "7")
                    {
                        pnlId7.BackColor = Color.Red;
                    }

                    tmrClignoPorte.Start();
                }));

            }
        }

        private void clignoPorte(object sender, EventArgs e)
        {
            pnlId1.BackColor = Color.Green;
            pnlId2.BackColor = Color.Green;
            pnlId3.BackColor = Color.Green;
            pnlId4.BackColor = Color.Green;
            pnlId5.BackColor = Color.Green;
            pnlId6.BackColor = Color.Green;
            pnlId7.BackColor = Color.Green;
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
                    this.Text += " - Connecté à " + selectedPort.Name;
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
    }
}
