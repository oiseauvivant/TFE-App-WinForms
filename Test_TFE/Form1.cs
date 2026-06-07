using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        bool modeEditionPortes = false;
        bool devMode = false;
        private bool dragging = false;
        private Point dragStart;
        private Panel panelEnDeplacement;

        private HashSet<Keys> touchesEnfoncees = new HashSet<Keys>();


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
            int count = (int)NUPNbrPorte.Value;

            // 1) AJOUTER les panels manquants
            while (listePanelsPorte.Count < count)
            {
                int i = listePanelsPorte.Count;

                Panel p = new Panel();
                p.Width = 40;
                p.Height = 40;
                p.BackColor = Color.Gray;
                p.BorderStyle = BorderStyle.FixedSingle;

                // Position par défaut (tu peux améliorer plus tard)
                if (i < 5)
                {
                    p.Left = 20 + (i * 40);
                    p.Top = 20;
                }
                else
                {
                    p.Left = 20 + ((i - 5) * 40);
                    p.Top = 60;
                }

                // Numéro de porte
                p.Tag = i;

                // Label du numéro
                Label lbl = new Label();
                lbl.Text = i.ToString();
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                lbl.MouseDown += Panel_MouseDown;
                lbl.MouseMove += Panel_MouseMove;
                lbl.MouseUp += Panel_MouseUp;
                lbl.ContextMenuStrip = cmsMenuPorte; // Associe le menu contextuel à chaque label

                p.Controls.Add(lbl);

                // Handlers pour déplacement
                p.MouseDown += Panel_MouseDown;
                p.MouseMove += Panel_MouseMove;
                p.MouseUp += Panel_MouseUp;
                p.ContextMenuStrip = cmsMenuPorte; // Associe le menu contextuel à chaque panel

                listePanelsPorte.Add(p);
                PnlPiece.Controls.Add(p);
            }

            // 2) SUPPRIMER les panels en trop
            while (listePanelsPorte.Count > count)
            {
                Panel p = listePanelsPorte[listePanelsPorte.Count - 1];
                PnlPiece.Controls.Remove(p);
                listePanelsPorte.RemoveAt(listePanelsPorte.Count - 1);
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

        private void LoadPorts()
        {
            string[] ports = SerialPort.GetPortNames();

            var list = ports
                .Select(p => new PortItem { Name = p })
                .ToList();

            cbPorts.DataSource = list;
            cbPorts.DisplayMember = "Name";
        }

        private void DetectionAutoESP32(object sender = null, EventArgs e = null)
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
                    btnConnexion.Enabled = false;
                    btnDeconnexion.Enabled = true;

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

        private void recevoir(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                string messageRecu = serialPort.ReadLine().Trim(); // Lit la ligne reçue
                this.Invoke(new Action(() =>
                {
                    if (messageRecu.StartsWith("id=") && messageRecu.Contains("sens="))
                    {
                        txtReception.Text = messageRecu; // Affiche le message reçu dans le TextBox
                        parties = messageRecu.Split(';');

                        id = parties[0].Split('=')[1];
                        sens = parties[1].Split('=')[1];

                        if (sens == "1")
                        {
                            total++;
                            entree++;
                            lblentree.Text = "Entrées: " + entree.ToString();
                            lblTotal.Text = "Total: " + total.ToString();

                            if (int.Parse(id) == -1)
                            {
                                return;
                            }

                            int index = int.Parse(id);

                            if (index >= 0 && index < listePanelsPorte.Count)
                            {
                                clignoPorteEntree(listePanelsPorte[index]);
                            }
                        }
                        else if (sens == "0")
                        {
                            if (total > 0)
                            {
                                total--;
                            }
                            sortie++;
                            lblsortie.Text = "Sorties: " + sortie.ToString();
                            lblTotal.Text = "Total: " + total.ToString();

                            if (int.Parse(id) == -1)
                            {
                                return;
                            }

                            int index = int.Parse(id);

                            if (index >= 0 && index < listePanelsPorte.Count)
                            {
                                clignoPorteSortie(listePanelsPorte[index]);
                            }
                        }
                    }

                    if (messageRecu.StartsWith("SYNCHRO"))
                    {
                        txtReception.Text = messageRecu; // Affiche le message reçu dans le TextBox
                        var parts = messageRecu.Split(';');

                        int entreeSynchro = int.Parse(parts[1]);
                        int sortieSynchro = int.Parse(parts[2]);
                        int totalSynchro = int.Parse(parts[3]);

                        entree = entreeSynchro;
                        sortie = sortieSynchro;
                        total = totalSynchro;

                        lblentree.Text = "Entrées: " + entree.ToString();
                        lblsortie.Text = "Sorties: " + sortie.ToString();
                        lblTotal.Text = "Total: " + total.ToString();

                    }
                }));

            }
        }

        private async void clignoPorteEntree(Panel p)
        {
            Color original = p.BackColor;

            p.BackColor = Color.Green;
            await Task.Delay(500);

            p.BackColor = original;
        }

        private async void clignoPorteSortie(Panel p)
        {
            Color original = p.BackColor;

            p.BackColor = Color.Red;
            await Task.Delay(500);

            p.BackColor = original;
        }

        private void Deconnexion(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.WriteLine("DECONNEXION"); // Envoie un message de déconnexion à l'ESP32
                    serialPort.BaseStream.Flush();
                    serialPort.Close();
                    btnConnexion.Enabled = true;
                    btnDeconnexion.Enabled = false;
                    this.Text = "Déconnecté";
                    MessageBox.Show("Déconnexion réussie.");
                }
                else
                {
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
            txtTailleX.Text = PnlPiece.Width.ToString();
            txtTailleY.Text = PnlPiece.Height.ToString();
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
            int largeur, hauteur;

            if (!int.TryParse(txtTailleX.Text, out largeur) || !int.TryParse(txtTailleY.Text, out hauteur))
            {

            }
            else
            {
                PnlPiece.Width = int.Parse(txtTailleX.Text);
                PnlPiece.Height = int.Parse(txtTailleY.Text);
            }
        }

        private void synchroData(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.WriteLine("SYNCHRO"); // Envoie un message de synchronisation à l'ESP32
                    MessageBox.Show("Synchronisation réussie.");
                }
                else
                {
                    MessageBox.Show("Vous n'êtes pas connecté.");
                }
            }
            catch
            {

            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (!modeEdition && !modeEditionPortes) return;

            dragging = true;
            panelEnDeplacement = (sender as Panel) ?? (sender as Label)?.Parent as Panel;
            dragStart = e.Location;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!modeEdition && !modeEditionPortes || !dragging || panelEnDeplacement == null) return;


            panelEnDeplacement.Left += e.X - dragStart.X;
            panelEnDeplacement.Top += e.Y - dragStart.Y;

            // --- PROTECTION : empêcher de sortir de la pièce ---
            if (panelEnDeplacement.Left < 0)
                panelEnDeplacement.Left = 0;

            if (panelEnDeplacement.Top < 0)
                panelEnDeplacement.Top = 0;

            if (panelEnDeplacement.Right > PnlPiece.Width)
                panelEnDeplacement.Left = PnlPiece.Width - panelEnDeplacement.Width;

            if (panelEnDeplacement.Bottom > PnlPiece.Height)
                panelEnDeplacement.Top = PnlPiece.Height - panelEnDeplacement.Height;
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            panelEnDeplacement = null;
        }

        private void deplacePorteMode(object sender, EventArgs e)
        {
            modeEditionPortes = !modeEditionPortes;

            if (modeEditionPortes)
            {
                btnDeplacePortes.BackColor = Color.Orange;
            }
            else
            {
                btnDeplacePortes.BackColor = SystemColors.Control;
            }
        }

        private void cmsPorte_Ouverture(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!modeEdition && !modeEditionPortes)
            {
                e.Cancel = true; // Empêche l'ouverture du menu si aucun mode d'édition n'est actif
                return;
            }

            // Récupérer la porte ciblée
            Panel p = (cmsMenuPorte.SourceControl as Panel)
                      ?? (cmsMenuPorte.SourceControl as Label)?.Parent as Panel;

            if (p == null)
            {
                e.Cancel = true;
                return;
            }

            // Remplir le ComboBox avec tous les numéros
            cbChangerNumeroPorte.Items.Clear();
            for (int i = 0; i < listePanelsPorte.Count; i++)
                cbChangerNumeroPorte.Items.Add(i);

            // Sélectionner le numéro actuel
            cbChangerNumeroPorte.SelectedItem = (int)p.Tag;
        }

        private void supprimerPorte_click(object sender, EventArgs e)
        {
            if (listePanelsPorte.Count <= 1)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer la dernière porte");
                return;
            }

            Panel p = (cmsMenuPorte.SourceControl as Panel)
              ?? (cmsMenuPorte.SourceControl as Label)?.Parent as Panel;

            if (p == null) return;

            // Retirer du panel parent
            PnlPiece.Controls.Remove(p);

            // Retirer de la liste interne
            listePanelsPorte.Remove(p);

            // Réindexer toutes les portes restantes
            for (int i = 0; i < listePanelsPorte.Count; i++)
            {
                listePanelsPorte[i].Tag = i;
                ((Label)listePanelsPorte[i].Controls[0]).Text = i.ToString();
            }

            // Mettre à jour le NumericUpDown
            NUPNbrPorte.Value = listePanelsPorte.Count;
        }

        private void cbChangerNumeroPorte_Click(object sender, EventArgs e)
        {
            // Récupérer la porte ciblée
            Panel p = (cmsMenuPorte.SourceControl as Panel)
                      ?? (cmsMenuPorte.SourceControl as Label)?.Parent as Panel;

            cmsMenuPorte.Close();

            if (p == null) return;

            int ancienNum = (int)p.Tag;
            int nouveauNum = (int)cbChangerNumeroPorte.SelectedItem;

            if (nouveauNum == ancienNum) return;

            // Récupérer la porte qui a déjà ce numéro
            Panel autre = listePanelsPorte[nouveauNum];

            // Échanger les numéros
            p.Tag = nouveauNum;
            autre.Tag = ancienNum;

            ((Label)p.Controls[0]).Text = nouveauNum.ToString();
            ((Label)autre.Controls[0]).Text = ancienNum.ToString();

            // Réordonner la liste interne
            listePanelsPorte[ancienNum] = autre;
            listePanelsPorte[nouveauNum] = p;

            cmsMenuPorte.Close();
        }

        private void devMode_KeyDown(object sender, KeyEventArgs e)
        {
            touchesEnfoncees.Add(e.KeyCode);
            verifierToucheDevMode();

        }

        private void devMode_KeyUp(object sender, KeyEventArgs e)
        {
            touchesEnfoncees.Remove(e.KeyCode);
        }

        private void verifierToucheDevMode()
        {
            if (touchesEnfoncees.Contains(Keys.ControlKey) && touchesEnfoncees.Contains(Keys.K))
            {
                devMode = !devMode;
            }

            if (devMode)
            {
                txtReception.Visible = true;
            }
            else
            {
                txtReception.Visible = false;
            }
        }

        private void avantQuitter(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.WriteLine("DECONNEXION"); // Envoie un message de déconnexion à l'ESP32
                    serialPort.BaseStream.Flush();
                    serialPort.Close();
                    MessageBox.Show("Déconnexion réussie.");
                }
            }
            catch
            {

            }
        }
    }
}
