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
            this.tmrClignoPorte = new System.Windows.Forms.Timer(this.components);
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.NUPNbrPorte = new System.Windows.Forms.NumericUpDown();
            this.PnlPiece = new System.Windows.Forms.Panel();
            this.btnEdition = new System.Windows.Forms.Button();
            this.pnlTaillePiece = new System.Windows.Forms.Panel();
            this.lblTailleX = new System.Windows.Forms.Label();
            this.lblTailleY = new System.Windows.Forms.Label();
            this.txtTailleY = new System.Windows.Forms.TextBox();
            this.txtTailleX = new System.Windows.Forms.TextBox();
            this.btnTaillePieceValider = new System.Windows.Forms.Button();
            this.lblNbrPorte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUPNbrPorte)).BeginInit();
            this.pnlTaillePiece.SuspendLayout();
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
            this.lblsortie.Location = new System.Drawing.Point(326, 105);
            this.lblsortie.Name = "lblsortie";
            this.lblsortie.Size = new System.Drawing.Size(38, 13);
            this.lblsortie.TabIndex = 2;
            this.lblsortie.Text = "sortie :";
            // 
            // lblentree
            // 
            this.lblentree.AutoSize = true;
            this.lblentree.Location = new System.Drawing.Point(326, 142);
            this.lblentree.Name = "lblentree";
            this.lblentree.Size = new System.Drawing.Size(43, 13);
            this.lblentree.TabIndex = 3;
            this.lblentree.Text = "entree :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(315, 197);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total :";
            // 
            // tmrClignoPorte
            // 
            this.tmrClignoPorte.Interval = 200;
            this.tmrClignoPorte.Tick += new System.EventHandler(this.clignoPorte);
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
            // NUPNbrPorte
            // 
            this.NUPNbrPorte.Location = new System.Drawing.Point(42, 158);
            this.NUPNbrPorte.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUPNbrPorte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUPNbrPorte.Name = "NUPNbrPorte";
            this.NUPNbrPorte.Size = new System.Drawing.Size(40, 20);
            this.NUPNbrPorte.TabIndex = 11;
            this.NUPNbrPorte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUPNbrPorte.ValueChanged += new System.EventHandler(this.NUPPorteChange);
            // 
            // PnlPiece
            // 
            this.PnlPiece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPiece.Location = new System.Drawing.Point(436, 159);
            this.PnlPiece.Name = "PnlPiece";
            this.PnlPiece.Size = new System.Drawing.Size(385, 298);
            this.PnlPiece.TabIndex = 12;
            // 
            // btnEdition
            // 
            this.btnEdition.Location = new System.Drawing.Point(290, 354);
            this.btnEdition.Name = "btnEdition";
            this.btnEdition.Size = new System.Drawing.Size(75, 23);
            this.btnEdition.TabIndex = 13;
            this.btnEdition.Text = "Edition";
            this.btnEdition.UseVisualStyleBackColor = true;
            this.btnEdition.Click += new System.EventHandler(this.mode_Edition_click);
            // 
            // pnlTaillePiece
            // 
            this.pnlTaillePiece.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTaillePiece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTaillePiece.Controls.Add(this.lblNbrPorte);
            this.pnlTaillePiece.Controls.Add(this.lblTailleX);
            this.pnlTaillePiece.Controls.Add(this.lblTailleY);
            this.pnlTaillePiece.Controls.Add(this.txtTailleY);
            this.pnlTaillePiece.Controls.Add(this.NUPNbrPorte);
            this.pnlTaillePiece.Controls.Add(this.txtTailleX);
            this.pnlTaillePiece.Controls.Add(this.btnTaillePieceValider);
            this.pnlTaillePiece.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTaillePiece.Enabled = false;
            this.pnlTaillePiece.Location = new System.Drawing.Point(1000, 0);
            this.pnlTaillePiece.Name = "pnlTaillePiece";
            this.pnlTaillePiece.Size = new System.Drawing.Size(123, 546);
            this.pnlTaillePiece.TabIndex = 14;
            // 
            // lblTailleX
            // 
            this.lblTailleX.AutoSize = true;
            this.lblTailleX.Location = new System.Drawing.Point(37, 8);
            this.lblTailleX.Name = "lblTailleX";
            this.lblTailleX.Size = new System.Drawing.Size(43, 13);
            this.lblTailleX.TabIndex = 4;
            this.lblTailleX.Text = "Largeur";
            // 
            // lblTailleY
            // 
            this.lblTailleY.AutoSize = true;
            this.lblTailleY.Location = new System.Drawing.Point(37, 51);
            this.lblTailleY.Name = "lblTailleY";
            this.lblTailleY.Size = new System.Drawing.Size(45, 13);
            this.lblTailleY.TabIndex = 3;
            this.lblTailleY.Text = "Hauteur";
            // 
            // txtTailleY
            // 
            this.txtTailleY.Location = new System.Drawing.Point(12, 67);
            this.txtTailleY.Name = "txtTailleY";
            this.txtTailleY.Size = new System.Drawing.Size(100, 20);
            this.txtTailleY.TabIndex = 2;
            // 
            // txtTailleX
            // 
            this.txtTailleX.Location = new System.Drawing.Point(12, 24);
            this.txtTailleX.Name = "txtTailleX";
            this.txtTailleX.Size = new System.Drawing.Size(100, 20);
            this.txtTailleX.TabIndex = 1;
            // 
            // btnTaillePieceValider
            // 
            this.btnTaillePieceValider.Location = new System.Drawing.Point(27, 99);
            this.btnTaillePieceValider.Name = "btnTaillePieceValider";
            this.btnTaillePieceValider.Size = new System.Drawing.Size(75, 23);
            this.btnTaillePieceValider.TabIndex = 0;
            this.btnTaillePieceValider.Text = "Valider";
            this.btnTaillePieceValider.UseVisualStyleBackColor = true;
            this.btnTaillePieceValider.Click += new System.EventHandler(this.validerTaillePiece);
            // 
            // lblNbrPorte
            // 
            this.lblNbrPorte.AutoSize = true;
            this.lblNbrPorte.Location = new System.Drawing.Point(19, 141);
            this.lblNbrPorte.Name = "lblNbrPorte";
            this.lblNbrPorte.Size = new System.Drawing.Size(91, 13);
            this.lblNbrPorte.TabIndex = 15;
            this.lblNbrPorte.Text = "Nombre de portes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 546);
            this.Controls.Add(this.pnlTaillePiece);
            this.Controls.Add(this.btnEdition);
            this.Controls.Add(this.PnlPiece);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblentree);
            this.Controls.Add(this.lblsortie);
            this.Controls.Add(this.txtEnvoi);
            this.Controls.Add(this.btnEnvoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Visualisation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoadForm);
            this.Shown += new System.EventHandler(this.Detection);
            ((System.ComponentModel.ISupportInitialize)(this.NUPNbrPorte)).EndInit();
            this.pnlTaillePiece.ResumeLayout(false);
            this.pnlTaillePiece.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvoi;
        private System.Windows.Forms.TextBox txtEnvoi;
        private System.Windows.Forms.Label lblsortie;
        private System.Windows.Forms.Label lblentree;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Timer tmrClignoPorte;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.NumericUpDown NUPNbrPorte;
        private System.Windows.Forms.Panel PnlPiece;
        private System.Windows.Forms.Button btnEdition;
        private System.Windows.Forms.Panel pnlTaillePiece;
        private System.Windows.Forms.Button btnTaillePieceValider;
        private System.Windows.Forms.TextBox txtTailleY;
        private System.Windows.Forms.TextBox txtTailleX;
        private System.Windows.Forms.Label lblTailleX;
        private System.Windows.Forms.Label lblTailleY;
        private System.Windows.Forms.Label lblNbrPorte;
    }
}

