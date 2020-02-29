namespace GestionRemiseBanque.forms.TitresBancaires
{
    partial class frmListeTitresBancaires
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCheques = new System.Windows.Forms.RadioButton();
            this.rbEffet = new System.Windows.Forms.RadioButton();
            this.rbTout = new System.Windows.Forms.RadioButton();
            this.cbSurPlace = new System.Windows.Forms.CheckBox();
            this.cbHorsPlace = new System.Windows.Forms.CheckBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmidTitreBq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSociete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBanque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRemise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHorsPlace);
            this.groupBox1.Controls.Add(this.cbSurPlace);
            this.groupBox1.Controls.Add(this.rbCheques);
            this.groupBox1.Controls.Add(this.rbEffet);
            this.groupBox1.Controls.Add(this.rbTout);
            this.groupBox1.Location = new System.Drawing.Point(21, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trier par";
            // 
            // rbCheques
            // 
            this.rbCheques.AutoSize = true;
            this.rbCheques.Location = new System.Drawing.Point(214, 28);
            this.rbCheques.Name = "rbCheques";
            this.rbCheques.Size = new System.Drawing.Size(67, 17);
            this.rbCheques.TabIndex = 5;
            this.rbCheques.TabStop = true;
            this.rbCheques.Text = "Cheques";
            this.rbCheques.UseVisualStyleBackColor = true;
            // 
            // rbEffet
            // 
            this.rbEffet.AutoSize = true;
            this.rbEffet.Location = new System.Drawing.Point(111, 28);
            this.rbEffet.Name = "rbEffet";
            this.rbEffet.Size = new System.Drawing.Size(52, 17);
            this.rbEffet.TabIndex = 4;
            this.rbEffet.TabStop = true;
            this.rbEffet.Text = "Effets";
            this.rbEffet.UseVisualStyleBackColor = true;
            // 
            // rbTout
            // 
            this.rbTout.AutoSize = true;
            this.rbTout.Location = new System.Drawing.Point(19, 28);
            this.rbTout.Name = "rbTout";
            this.rbTout.Size = new System.Drawing.Size(47, 17);
            this.rbTout.TabIndex = 3;
            this.rbTout.TabStop = true;
            this.rbTout.Text = "Tout";
            this.rbTout.UseVisualStyleBackColor = true;
            // 
            // cbSurPlace
            // 
            this.cbSurPlace.AutoSize = true;
            this.cbSurPlace.Location = new System.Drawing.Point(332, 20);
            this.cbSurPlace.Name = "cbSurPlace";
            this.cbSurPlace.Size = new System.Drawing.Size(109, 17);
            this.cbSurPlace.TabIndex = 6;
            this.cbSurPlace.Text = "Cheque sur place";
            this.cbSurPlace.UseVisualStyleBackColor = true;
            // 
            // cbHorsPlace
            // 
            this.cbHorsPlace.AutoSize = true;
            this.cbHorsPlace.Location = new System.Drawing.Point(332, 43);
            this.cbHorsPlace.Name = "cbHorsPlace";
            this.cbHorsPlace.Size = new System.Drawing.Size(115, 17);
            this.cbHorsPlace.TabIndex = 7;
            this.cbHorsPlace.Text = "Cheque hors place";
            this.cbHorsPlace.UseVisualStyleBackColor = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(21, 90);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(86, 37);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(113, 90);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(86, 37);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(205, 90);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(86, 37);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(297, 90);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(86, 37);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(402, 90);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(86, 37);
            this.btnImprimer.TabIndex = 5;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmidTitreBq,
            this.clmType,
            this.clmNumero,
            this.clmSociete,
            this.clmBanque,
            this.clmMontant,
            this.clmRemise});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(505, 341);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // clmidTitreBq
            // 
            this.clmidTitreBq.DataPropertyName = "idTitreBq";
            this.clmidTitreBq.HeaderText = "idTitreBq";
            this.clmidTitreBq.Name = "clmidTitreBq";
            this.clmidTitreBq.ReadOnly = true;
            this.clmidTitreBq.Visible = false;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "Type";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            // 
            // clmNumero
            // 
            this.clmNumero.DataPropertyName = "numero";
            this.clmNumero.HeaderText = "Numéro";
            this.clmNumero.Name = "clmNumero";
            this.clmNumero.ReadOnly = true;
            // 
            // clmSociete
            // 
            this.clmSociete.DataPropertyName = "societeName";
            this.clmSociete.HeaderText = "Société";
            this.clmSociete.Name = "clmSociete";
            this.clmSociete.ReadOnly = true;
            // 
            // clmBanque
            // 
            this.clmBanque.DataPropertyName = "banqueName";
            this.clmBanque.HeaderText = "Banque";
            this.clmBanque.Name = "clmBanque";
            this.clmBanque.ReadOnly = true;
            // 
            // clmMontant
            // 
            this.clmMontant.DataPropertyName = "montant";
            this.clmMontant.HeaderText = "Montant";
            this.clmMontant.Name = "clmMontant";
            this.clmMontant.ReadOnly = true;
            // 
            // clmRemise
            // 
            this.clmRemise.DataPropertyName = "remiseID";
            this.clmRemise.HeaderText = "Numero Remise";
            this.clmRemise.Name = "clmRemise";
            this.clmRemise.ReadOnly = true;
            // 
            // frmListeTitresBancaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListeTitresBancaires";
            this.Text = "Liste Titres Bancaires";
            this.Load += new System.EventHandler(this.frmListeTitresBancaires_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbHorsPlace;
        private System.Windows.Forms.CheckBox cbSurPlace;
        private System.Windows.Forms.RadioButton rbCheques;
        private System.Windows.Forms.RadioButton rbEffet;
        private System.Windows.Forms.RadioButton rbTout;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmidTitreBq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSociete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBanque;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRemise;
    }
}