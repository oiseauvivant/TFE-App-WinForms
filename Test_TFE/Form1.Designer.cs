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
            this.btnEnvoi = new System.Windows.Forms.Button();
            this.txtEnvoi = new System.Windows.Forms.TextBox();
            this.lblsortie = new System.Windows.Forms.Label();
            this.lblentree = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlId1 = new System.Windows.Forms.Panel();
            this.pnlId2 = new System.Windows.Forms.Panel();
            this.tmrClignoPorte = new System.Windows.Forms.Timer(this.components);
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
            this.pnlId1.Location = new System.Drawing.Point(549, 71);
            this.pnlId1.Name = "pnlId1";
            this.pnlId1.Size = new System.Drawing.Size(81, 56);
            this.pnlId1.TabIndex = 5;
            // 
            // pnlId2
            // 
            this.pnlId2.BackColor = System.Drawing.Color.Green;
            this.pnlId2.Location = new System.Drawing.Point(549, 148);
            this.pnlId2.Name = "pnlId2";
            this.pnlId2.Size = new System.Drawing.Size(95, 69);
            this.pnlId2.TabIndex = 6;
            // 
            // tmrClignoPorte
            // 
            this.tmrClignoPorte.Interval = 200;
            this.tmrClignoPorte.Tick += new System.EventHandler(this.clignoPorte);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 513);
            this.Controls.Add(this.pnlId2);
            this.Controls.Add(this.pnlId1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblentree);
            this.Controls.Add(this.lblsortie);
            this.Controls.Add(this.txtEnvoi);
            this.Controls.Add(this.btnEnvoi);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

