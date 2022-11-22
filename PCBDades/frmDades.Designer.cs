namespace PCBDades
{
    partial class frmDades
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
            this.cmdGetData = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCerca = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBandol = new System.Windows.Forms.ComboBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.grpCerca.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGetData
            // 
            this.cmdGetData.Location = new System.Drawing.Point(440, 149);
            this.cmdGetData.Name = "cmdGetData";
            this.cmdGetData.Size = new System.Drawing.Size(82, 23);
            this.cmdGetData.TabIndex = 23;
            this.cmdGetData.Text = "Get Data";
            this.cmdGetData.UseVisualStyleBackColor = true;
            this.cmdGetData.Click += new System.EventHandler(this.cmdGetData_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(440, 178);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(82, 23);
            this.cmdUpdate.TabIndex = 22;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Location = new System.Drawing.Point(44, 149);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.ReadOnly = true;
            this.dtgUsers.Size = new System.Drawing.Size(377, 168);
            this.dtgUsers.TabIndex = 21;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(76, 80);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(243, 20);
            this.txtNom.TabIndex = 20;
            this.txtNom.Tag = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nom";
            // 
            // grpCerca
            // 
            this.grpCerca.Controls.Add(this.label2);
            this.grpCerca.Controls.Add(this.cmbBandol);
            this.grpCerca.Location = new System.Drawing.Point(44, 12);
            this.grpCerca.Name = "grpCerca";
            this.grpCerca.Size = new System.Drawing.Size(243, 50);
            this.grpCerca.TabIndex = 26;
            this.grpCerca.TabStop = false;
            this.grpCerca.Text = "Opcions de cerca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Bàndol:";
            // 
            // cmbBandol
            // 
            this.cmbBandol.FormattingEnabled = true;
            this.cmbBandol.Items.AddRange(new object[] {
            "Rebel Alliance",
            "First Order"});
            this.cmbBandol.Location = new System.Drawing.Point(84, 19);
            this.cmbBandol.Name = "cmbBandol";
            this.cmbBandol.Size = new System.Drawing.Size(121, 21);
            this.cmbBandol.TabIndex = 26;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(76, 106);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(243, 20);
            this.txtIP.TabIndex = 28;
            this.txtIP.Tag = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "IP";
            // 
            // txtEdat
            // 
            this.txtEdat.Location = new System.Drawing.Point(364, 80);
            this.txtEdat.Name = "txtEdat";
            this.txtEdat.Size = new System.Drawing.Size(42, 20);
            this.txtEdat.TabIndex = 30;
            this.txtEdat.Tag = "Edat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Edat";
            // 
            // frmDades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 361);
            this.Controls.Add(this.txtEdat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCerca);
            this.Controls.Add(this.cmdGetData);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.dtgUsers);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label4);
            this.Name = "frmDades";
            this.Text = "Gestió de dades";
            this.Load += new System.EventHandler(this.frmDades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.grpCerca.ResumeLayout(false);
            this.grpCerca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGetData;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpCerca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBandol;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdat;
        private System.Windows.Forms.Label label3;
    }
}