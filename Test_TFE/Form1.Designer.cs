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
            this.txtReception = new System.Windows.Forms.TextBox();
            this.lblsortie = new System.Windows.Forms.Label();
            this.lblentree = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.NUPNbrPorte = new System.Windows.Forms.NumericUpDown();
            this.PnlPiece = new System.Windows.Forms.Panel();
            this.btnEdition = new System.Windows.Forms.Button();
            this.pnlTaillePiece = new System.Windows.Forms.Panel();
            this.lblNbrPorte = new System.Windows.Forms.Label();
            this.lblTailleX = new System.Windows.Forms.Label();
            this.lblTailleY = new System.Windows.Forms.Label();
            this.txtTailleY = new System.Windows.Forms.TextBox();
            this.txtTailleX = new System.Windows.Forms.TextBox();
            this.btnTaillePieceValider = new System.Windows.Forms.Button();
            this.btnSynchroniser = new System.Windows.Forms.Button();
            this.btnDeplacePortes = new System.Windows.Forms.Button();
            this.cmsMenuPorte = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprmierPorte = new System.Windows.Forms.ToolStripMenuItem();
            this.changerNumeroPorte = new System.Windows.Forms.ToolStripMenuItem();
            this.cbChangerNumeroPorte = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUPNbrPorte)).BeginInit();
            this.pnlTaillePiece.SuspendLayout();
            this.cmsMenuPorte.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReception
            // 
            this.txtReception.Location = new System.Drawing.Point(52, 184);
            this.txtReception.Multiline = true;
            this.txtReception.Name = "txtReception";
            this.txtReception.Size = new System.Drawing.Size(158, 131);
            this.txtReception.TabIndex = 1;
            this.txtReception.Visible = false;
            // 
            // lblsortie
            // 
            this.lblsortie.AutoSize = true;
            this.lblsortie.Location = new System.Drawing.Point(268, 105);
            this.lblsortie.Name = "lblsortie";
            this.lblsortie.Size = new System.Drawing.Size(45, 13);
            this.lblsortie.TabIndex = 2;
            this.lblsortie.Text = "Sorties :";
            // 
            // lblentree
            // 
            this.lblentree.AutoSize = true;
            this.lblentree.Location = new System.Drawing.Point(268, 132);
            this.lblentree.Name = "lblentree";
            this.lblentree.Size = new System.Drawing.Size(49, 13);
            this.lblentree.TabIndex = 3;
            this.lblentree.Text = "Entrées :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(268, 161);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total :";
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(8, 13);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 21);
            this.cbPorts.TabIndex = 8;
            this.cbPorts.TabStop = false;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(135, 13);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 9;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.DetectionAutoESP32);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(135, 42);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(84, 23);
            this.btnDeconnexion.TabIndex = 10;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.Deconnexion);
            // 
            // NUPNbrPorte
            // 
            this.NUPNbrPorte.Location = new System.Drawing.Point(44, 121);
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
            this.NUPNbrPorte.ReadOnly = true;
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
            this.btnEdition.Location = new System.Drawing.Point(919, 22);
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
            // lblNbrPorte
            // 
            this.lblNbrPorte.AutoSize = true;
            this.lblNbrPorte.Location = new System.Drawing.Point(19, 104);
            this.lblNbrPorte.Name = "lblNbrPorte";
            this.lblNbrPorte.Size = new System.Drawing.Size(91, 13);
            this.lblNbrPorte.TabIndex = 15;
            this.lblNbrPorte.Text = "Nombre de portes";
            // 
            // lblTailleX
            // 
            this.lblTailleX.AutoSize = true;
            this.lblTailleX.Location = new System.Drawing.Point(43, 8);
            this.lblTailleX.Name = "lblTailleX";
            this.lblTailleX.Size = new System.Drawing.Size(43, 13);
            this.lblTailleX.TabIndex = 4;
            this.lblTailleX.Text = "Largeur";
            // 
            // lblTailleY
            // 
            this.lblTailleY.AutoSize = true;
            this.lblTailleY.Location = new System.Drawing.Point(42, 51);
            this.lblTailleY.Name = "lblTailleY";
            this.lblTailleY.Size = new System.Drawing.Size(45, 13);
            this.lblTailleY.TabIndex = 3;
            this.lblTailleY.Text = "Hauteur";
            // 
            // txtTailleY
            // 
            this.txtTailleY.Location = new System.Drawing.Point(14, 67);
            this.txtTailleY.Name = "txtTailleY";
            this.txtTailleY.Size = new System.Drawing.Size(100, 20);
            this.txtTailleY.TabIndex = 2;
            this.txtTailleY.TextChanged += new System.EventHandler(this.validerTaillePiece);
            // 
            // txtTailleX
            // 
            this.txtTailleX.Location = new System.Drawing.Point(14, 24);
            this.txtTailleX.Name = "txtTailleX";
            this.txtTailleX.Size = new System.Drawing.Size(100, 20);
            this.txtTailleX.TabIndex = 1;
            this.txtTailleX.TextChanged += new System.EventHandler(this.validerTaillePiece);
            // 
            // btnTaillePieceValider
            // 
            this.btnTaillePieceValider.Location = new System.Drawing.Point(27, 160);
            this.btnTaillePieceValider.Name = "btnTaillePieceValider";
            this.btnTaillePieceValider.Size = new System.Drawing.Size(75, 23);
            this.btnTaillePieceValider.TabIndex = 0;
            this.btnTaillePieceValider.Text = "Valider";
            this.btnTaillePieceValider.UseVisualStyleBackColor = true;
            this.btnTaillePieceValider.Click += new System.EventHandler(this.mode_Edition_click);
            // 
            // btnSynchroniser
            // 
            this.btnSynchroniser.Location = new System.Drawing.Point(313, 47);
            this.btnSynchroniser.Name = "btnSynchroniser";
            this.btnSynchroniser.Size = new System.Drawing.Size(83, 23);
            this.btnSynchroniser.TabIndex = 15;
            this.btnSynchroniser.Text = "Synchroniser";
            this.btnSynchroniser.UseVisualStyleBackColor = true;
            this.btnSynchroniser.Click += new System.EventHandler(this.synchroData);
            // 
            // btnDeplacePortes
            // 
            this.btnDeplacePortes.Location = new System.Drawing.Point(571, 88);
            this.btnDeplacePortes.Name = "btnDeplacePortes";
            this.btnDeplacePortes.Size = new System.Drawing.Size(108, 30);
            this.btnDeplacePortes.TabIndex = 16;
            this.btnDeplacePortes.Text = "Déplacer les portes";
            this.btnDeplacePortes.UseVisualStyleBackColor = true;
            this.btnDeplacePortes.Click += new System.EventHandler(this.deplacePorteMode);
            // 
            // cmsMenuPorte
            // 
            this.cmsMenuPorte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprmierPorte,
            this.changerNumeroPorte});
            this.cmsMenuPorte.Name = "cmsMenuPorte";
            this.cmsMenuPorte.Size = new System.Drawing.Size(177, 48);
            this.cmsMenuPorte.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPorte_Ouverture);
            // 
            // supprmierPorte
            // 
            this.supprmierPorte.Name = "supprmierPorte";
            this.supprmierPorte.Size = new System.Drawing.Size(176, 22);
            this.supprmierPorte.Text = "Supprimer";
            this.supprmierPorte.Click += new System.EventHandler(this.supprimerPorte_click);
            // 
            // changerNumeroPorte
            // 
            this.changerNumeroPorte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbChangerNumeroPorte});
            this.changerNumeroPorte.Name = "changerNumeroPorte";
            this.changerNumeroPorte.Size = new System.Drawing.Size(176, 22);
            this.changerNumeroPorte.Text = "Changer le numéro";
            // 
            // cbChangerNumeroPorte
            // 
            this.cbChangerNumeroPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangerNumeroPorte.MaxDropDownItems = 10;
            this.cbChangerNumeroPorte.Name = "cbChangerNumeroPorte";
            this.cbChangerNumeroPorte.Size = new System.Drawing.Size(121, 23);
            this.cbChangerNumeroPorte.SelectedIndexChanged += new System.EventHandler(this.cbChangerNumeroPorte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 546);
            this.Controls.Add(this.btnDeplacePortes);
            this.Controls.Add(this.btnSynchroniser);
            this.Controls.Add(this.pnlTaillePiece);
            this.Controls.Add(this.btnEdition);
            this.Controls.Add(this.PnlPiece);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblentree);
            this.Controls.Add(this.lblsortie);
            this.Controls.Add(this.txtReception);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Visualisation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoadForm);
            this.Shown += new System.EventHandler(this.DetectionAutoESP32);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.devMode_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.devMode_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.NUPNbrPorte)).EndInit();
            this.pnlTaillePiece.ResumeLayout(false);
            this.pnlTaillePiece.PerformLayout();
            this.cmsMenuPorte.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtReception;
        private System.Windows.Forms.Label lblsortie;
        private System.Windows.Forms.Label lblentree;
        private System.Windows.Forms.Label lblTotal;
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
        private System.Windows.Forms.Button btnSynchroniser;
        private System.Windows.Forms.Button btnDeplacePortes;
        private System.Windows.Forms.ContextMenuStrip cmsMenuPorte;
        private System.Windows.Forms.ToolStripMenuItem supprmierPorte;
        private System.Windows.Forms.ToolStripMenuItem changerNumeroPorte;
        private System.Windows.Forms.ToolStripComboBox cbChangerNumeroPorte;
    }
}

