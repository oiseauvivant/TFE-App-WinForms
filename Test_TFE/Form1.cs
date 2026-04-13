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

        public Form1()
        {
            InitializeComponent();
            //id=1;sens=entree;nbr=1


            serialPort = new SerialPort("COM5", 115200, Parity.None, 8, StopBits.One);
            serialPort.DataReceived += recevoir;
            try
            {
                serialPort.Open();
                //MessageBox.Show("Port série ouvert !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur ouverture port : " + ex.Message);
            }
            

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

                    tmrClignoPorte.Start();
                }));

            }

            
        }

        private void clignoPorte(object sender, EventArgs e)
        {
            pnlId1.BackColor = Color.Green;
            pnlId2.BackColor = Color.Green;
            tmrClignoPorte.Stop();
        }
    }
}
