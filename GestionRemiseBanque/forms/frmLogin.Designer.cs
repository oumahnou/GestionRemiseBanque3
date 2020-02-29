namespace GestionRemiseBanque
{
    partial class frmLogin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.tabServeur = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.cbSauvegarder = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPasswordSql = new System.Windows.Forms.TextBox();
            this.txtuserSql = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabServeur.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Controls.Add(this.tabServeur);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 254);
            this.tabControl1.TabIndex = 6;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.label2);
            this.tabUser.Controls.Add(this.label1);
            this.tabUser.Controls.Add(this.txtPassword);
            this.tabUser.Controls.Add(this.txtUser);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(344, 228);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "Utilisateur";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Utilisateur";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(126, 54);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(174, 20);
            this.txtUser.TabIndex = 6;
            // 
            // tabServeur
            // 
            this.tabServeur.Controls.Add(this.label6);
            this.tabServeur.Controls.Add(this.txtDatabase);
            this.tabServeur.Controls.Add(this.cbSauvegarder);
            this.tabServeur.Controls.Add(this.btnTest);
            this.tabServeur.Controls.Add(this.groupBox1);
            this.tabServeur.Controls.Add(this.btnActualiser);
            this.tabServeur.Controls.Add(this.label3);
            this.tabServeur.Controls.Add(this.cmbServer);
            this.tabServeur.Location = new System.Drawing.Point(4, 22);
            this.tabServeur.Name = "tabServeur";
            this.tabServeur.Padding = new System.Windows.Forms.Padding(3);
            this.tabServeur.Size = new System.Drawing.Size(344, 228);
            this.tabServeur.TabIndex = 1;
            this.tabServeur.Text = "Serveur";
            this.tabServeur.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(85, 46);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(192, 20);
            this.txtDatabase.TabIndex = 6;
            // 
            // cbSauvegarder
            // 
            this.cbSauvegarder.AutoSize = true;
            this.cbSauvegarder.Checked = true;
            this.cbSauvegarder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSauvegarder.Location = new System.Drawing.Point(20, 190);
            this.cbSauvegarder.Name = "cbSauvegarder";
            this.cbSauvegarder.Size = new System.Drawing.Size(87, 17);
            this.cbSauvegarder.TabIndex = 5;
            this.cbSauvegarder.Text = "Sauvegarder";
            this.cbSauvegarder.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(197, 188);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(120, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Tester Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPasswordSql);
            this.groupBox1.Controls.Add(this.txtuserSql);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sql Utilisateur";
            // 
            // txtPasswordSql
            // 
            this.txtPasswordSql.Location = new System.Drawing.Point(103, 58);
            this.txtPasswordSql.Name = "txtPasswordSql";
            this.txtPasswordSql.Size = new System.Drawing.Size(153, 20);
            this.txtPasswordSql.TabIndex = 3;
            // 
            // txtuserSql
            // 
            this.txtuserSql.Location = new System.Drawing.Point(103, 27);
            this.txtuserSql.Name = "txtuserSql";
            this.txtuserSql.Size = new System.Drawing.Size(153, 20);
            this.txtuserSql.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Utilisateur";
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(290, 17);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(27, 22);
            this.btnActualiser.TabIndex = 2;
            this.btnActualiser.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sql Serveur";
            // 
            // cmbServer
            // 
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(85, 19);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(192, 21);
            this.cmbServer.TabIndex = 0;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(198, 333);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(109, 51);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(54, 333);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(109, 51);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 407);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLogin";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabServeur.ResumeLayout(false);
            this.tabServeur.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TabPage tabServeur;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPasswordSql;
        private System.Windows.Forms.TextBox txtuserSql;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.CheckBox cbSauvegarder;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDatabase;
    }
}

