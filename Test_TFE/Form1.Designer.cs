namespace Test_TFE
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnvoi = new System.Windows.Forms.Button();
            this.txtEnvoi = new System.Windows.Forms.TextBox();
            this.lblsortie = new System.Windows.Forms.Label();
            this.lblentree = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlId1 = new System.Windows.Forms.Panel();
            this.pnlId2 = new System.Windows.Forms.Panel();
            this.tmrClignoPorte = new System.Windows.Forms.Timer(this.components);
            this.pnlId3 = new System.Windows.Forms.Panel();
            this.pnlId4 = new System.Windows.Forms.Panel();
            this.pnlId5 = new System.Windows.Forms.Panel();
            this.pnlId6 = new System.Windows.Forms.Panel();
            this.pnlId7 = new System.Windows.Forms.Panel();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnvoi
            // 
            this.btnEnvoi.Location = new System.Drawing.Point(138, 281);
            this.btnEnvoi.Name = "btnEnvoi";
            this.btnEnvoi.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoi.TabIndex = 0;
            this.btnEnvoi.Text = "Envoyer";
            this.btnEnvoi.UseVisualStyleBackColor = true;
            this.btnEnvoi.Click += new System.EventHandler(this.envoyer);
            // 
            // txtEnvoi
            // 
            this.txtEnvoi.Location = new System.Drawing.Point(98, 77);
            this.txtEnvoi.Multiline = true;
            this.txtEnvoi.Name = "txtEnvoi";
            this.txtEnvoi.Size = new System.Drawing.Size(158, 131);
            this.txtEnvoi.TabIndex = 1;
            // 
            // lblsortie
            // 
            this.lblsortie.AutoSize = true;
            this.lblsortie.Location = new System.Drawing.Point(457, 158);
            this.lblsortie.Name = "lblsortie";
            this.lblsortie.Size = new System.Drawing.Size(38, 13);
            this.lblsortie.TabIndex = 2;
            this.lblsortie.Text = "sortie :";
            // 
            // lblentree
            // 
            this.lblentree.AutoSize = true;
            this.lblentree.Location = new System.Drawing.Point(457, 195);
            this.lblentree.Name = "lblentree";
            this.lblentree.Size = new System.Drawing.Size(43, 13);
            this.lblentree.TabIndex = 3;
            this.lblentree.Text = "entree :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(446, 250);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total :";
            // 
            // pnlId1
            // 
            this.pnlId1.BackColor = System.Drawing.Color.Green;
            this.pnlId1.Location = new System.Drawing.Point(595, 28);
            this.pnlId1.Name = "pnlId1";
            this.pnlId1.Size = new System.Drawing.Size(81, 56);
            this.pnlId1.TabIndex = 5;
            // 
            // pnlId2
            // 
            this.pnlId2.BackColor = System.Drawing.Color.Green;
            this.pnlId2.Location = new System.Drawing.Point(595, 92);
            this.pnlId2.Name = "pnlId2";
            this.pnlId2.Size = new System.Drawing.Size(81, 56);
            this.pnlId2.TabIndex = 6;
            // 
            // tmrClignoPorte
            // 
            this.tmrClignoPorte.Interval = 200;
            this.tmrClignoPorte.Tick += new System.EventHandler(this.clignoPorte);
            // 
            // pnlId3
            // 
            this.pnlId3.BackColor = System.Drawing.Color.Green;
            this.pnlId3.Location = new System.Drawing.Point(595, 156);
            this.pnlId3.Name = "pnlId3";
            this.pnlId3.Size = new System.Drawing.Size(81, 56);
            this.pnlId3.TabIndex = 7;
            // 
            // pnlId4
            // 
            this.pnlId4.BackColor = System.Drawing.Color.Green;
            this.pnlId4.Location = new System.Drawing.Point(595, 220);
            this.pnlId4.Name = "pnlId4";
            this.pnlId4.Size = new System.Drawing.Size(81, 56);
            this.pnlId4.TabIndex = 6;
            // 
            // pnlId5
            // 
            this.pnlId5.BackColor = System.Drawing.Color.Green;
            this.pnlId5.Location = new System.Drawing.Point(595, 284);
            this.pnlId5.Name = "pnlId5";
            this.pnlId5.Size = new System.Drawing.Size(81, 56);
            this.pnlId5.TabIndex = 6;
            // 
            // pnlId6
            // 
            this.pnlId6.BackColor = System.Drawing.Color.Green;
            this.pnlId6.Location = new System.Drawing.Point(595, 348);
            this.pnlId6.Name = "pnlId6";
            this.pnlId6.Size = new System.Drawing.Size(81, 56);
            this.pnlId6.TabIndex = 6;
            // 
            // pnlId7
            // 
            this.pnlId7.BackColor = System.Drawing.Color.Green;
            this.pnlId7.Location = new System.Drawing.Point(595, 412);
            this.pnlId7.Name = "pnlId7";
            this.pnlId7.Size = new System.Drawing.Size(81, 56);
            this.pnlId7.TabIndex = 6;
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(358, 56);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 21);
            this.cbPorts.TabIndex = 8;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(485, 56);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 9;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.Connexion);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(485, 85);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(84, 23);
            this.btnDeconnexion.TabIndex = 10;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.Deconnexion);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 513);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.pnlId7);
            this.Controls.Add(this.pnlId6);
            this.Controls.Add(this.pnlId5);
            this.Controls.Add(this.pnlId4);
            this.Controls.Add(this.pnlId3);
            this.Controls.Add(this.pnlId2);
            this.Controls.Add(this.pnlId1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblentree);
            this.Controls.Add(this.lblsortie);
            this.Controls.Add(this.txtEnvoi);
            this.Controls.Add(this.btnEnvoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Visualisation";
            this.Shown += new System.EventHandler(this.Detection);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvoi;
        private System.Windows.Forms.TextBox txtEnvoi;
        private System.Windows.Forms.Label lblsortie;
        private System.Windows.Forms.Label lblentree;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlId1;
        private System.Windows.Forms.Panel pnlId2;
        private System.Windows.Forms.Timer tmrClignoPorte;
        private System.Windows.Forms.Panel pnlId3;
        private System.Windows.Forms.Panel pnlId4;
        private System.Windows.Forms.Panel pnlId5;
        private System.Windows.Forms.Panel pnlId6;
        private System.Windows.Forms.Panel pnlId7;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}

