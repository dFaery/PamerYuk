namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_UbahProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxFotoProfile = new System.Windows.Forms.PictureBox();
            this.panelFotoDiri = new System.Windows.Forms.Panel();
            this.buttonEditFotoProfil = new System.Windows.Forms.Button();
            this.buttonEditFotoDiri = new System.Windows.Forms.Button();
            this.dateTimePickerTglLahir = new System.Windows.Forms.DateTimePicker();
            this.comboBoxKota = new System.Windows.Forms.ComboBox();
            this.textBoxNoKtp = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxNamaLengkap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSimpanUpdateProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoProfile)).BeginInit();
            this.panelFotoDiri.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxFotoProfile
            // 
            this.pictureBoxFotoProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFotoProfile.Image = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.pictureBoxFotoProfile.Location = new System.Drawing.Point(510, 78);
            this.pictureBoxFotoProfile.Name = "pictureBoxFotoProfile";
            this.pictureBoxFotoProfile.Size = new System.Drawing.Size(256, 258);
            this.pictureBoxFotoProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFotoProfile.TabIndex = 0;
            this.pictureBoxFotoProfile.TabStop = false;
            // 
            // panelFotoDiri
            // 
            this.panelFotoDiri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelFotoDiri.Controls.Add(this.buttonEditFotoProfil);
            this.panelFotoDiri.Controls.Add(this.buttonEditFotoDiri);
            this.panelFotoDiri.Controls.Add(this.pictureBoxFotoProfile);
            this.panelFotoDiri.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFotoDiri.Location = new System.Drawing.Point(0, 0);
            this.panelFotoDiri.Name = "panelFotoDiri";
            this.panelFotoDiri.Size = new System.Drawing.Size(1295, 507);
            this.panelFotoDiri.TabIndex = 1;
            // 
            // buttonEditFotoProfil
            // 
            this.buttonEditFotoProfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditFotoProfil.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditFotoProfil.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.PencilEdit;
            this.buttonEditFotoProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditFotoProfil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEditFotoProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditFotoProfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEditFotoProfil.Location = new System.Drawing.Point(1132, 454);
            this.buttonEditFotoProfil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditFotoProfil.Name = "buttonEditFotoProfil";
            this.buttonEditFotoProfil.Size = new System.Drawing.Size(50, 51);
            this.buttonEditFotoProfil.TabIndex = 82;
            this.buttonEditFotoProfil.UseVisualStyleBackColor = false;
            this.buttonEditFotoProfil.Click += new System.EventHandler(this.buttonEditFotoProfil_Click);
            // 
            // buttonEditFotoDiri
            // 
            this.buttonEditFotoDiri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditFotoDiri.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditFotoDiri.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.PencilEdit;
            this.buttonEditFotoDiri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditFotoDiri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEditFotoDiri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditFotoDiri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEditFotoDiri.Location = new System.Drawing.Point(716, 285);
            this.buttonEditFotoDiri.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditFotoDiri.Name = "buttonEditFotoDiri";
            this.buttonEditFotoDiri.Size = new System.Drawing.Size(50, 51);
            this.buttonEditFotoDiri.TabIndex = 81;
            this.buttonEditFotoDiri.UseVisualStyleBackColor = false;
            this.buttonEditFotoDiri.Click += new System.EventHandler(this.buttonEditFotoDiri_Click);
            // 
            // dateTimePickerTglLahir
            // 
            this.dateTimePickerTglLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTimePickerTglLahir.Location = new System.Drawing.Point(697, 693);
            this.dateTimePickerTglLahir.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTglLahir.Name = "dateTimePickerTglLahir";
            this.dateTimePickerTglLahir.Size = new System.Drawing.Size(485, 39);
            this.dateTimePickerTglLahir.TabIndex = 135;
            // 
            // comboBoxKota
            // 
            this.comboBoxKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxKota.FormattingEnabled = true;
            this.comboBoxKota.Location = new System.Drawing.Point(697, 798);
            this.comboBoxKota.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKota.Name = "comboBoxKota";
            this.comboBoxKota.Size = new System.Drawing.Size(485, 40);
            this.comboBoxKota.TabIndex = 134;
            // 
            // textBoxNoKtp
            // 
            this.textBoxNoKtp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNoKtp.BackColor = System.Drawing.Color.White;
            this.textBoxNoKtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNoKtp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNoKtp.Location = new System.Drawing.Point(697, 589);
            this.textBoxNoKtp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNoKtp.Name = "textBoxNoKtp";
            this.textBoxNoKtp.Size = new System.Drawing.Size(485, 39);
            this.textBoxNoKtp.TabIndex = 133;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEmail.Location = new System.Drawing.Point(128, 798);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(485, 39);
            this.textBoxEmail.TabIndex = 132;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUsername.Location = new System.Drawing.Point(128, 693);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(485, 39);
            this.textBoxUsername.TabIndex = 131;
            // 
            // textBoxNamaLengkap
            // 
            this.textBoxNamaLengkap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNamaLengkap.BackColor = System.Drawing.Color.White;
            this.textBoxNamaLengkap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNamaLengkap.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNamaLengkap.Location = new System.Drawing.Point(128, 589);
            this.textBoxNamaLengkap.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamaLengkap.Name = "textBoxNamaLengkap";
            this.textBoxNamaLengkap.Size = new System.Drawing.Size(485, 39);
            this.textBoxNamaLengkap.TabIndex = 130;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 760);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 29);
            this.label8.TabIndex = 129;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 548);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 29);
            this.label7.TabIndex = 128;
            this.label7.Text = "Nama Lengkap:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 646);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 127;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 548);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 126;
            this.label2.Text = "No KTP:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(692, 760);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 125;
            this.label4.Text = "Kota:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 646);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 124;
            this.label3.Text = "Tanggal Lahir:";
            // 
            // buttonSimpanUpdateProfile
            // 
            this.buttonSimpanUpdateProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSimpanUpdateProfile.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSimpanUpdateProfile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSimpanUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpanUpdateProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSimpanUpdateProfile.Location = new System.Drawing.Point(112, 885);
            this.buttonSimpanUpdateProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimpanUpdateProfile.Name = "buttonSimpanUpdateProfile";
            this.buttonSimpanUpdateProfile.Size = new System.Drawing.Size(1070, 68);
            this.buttonSimpanUpdateProfile.TabIndex = 123;
            this.buttonSimpanUpdateProfile.Text = "Simpan";
            this.buttonSimpanUpdateProfile.UseVisualStyleBackColor = false;
            this.buttonSimpanUpdateProfile.Click += new System.EventHandler(this.buttonSimpanUpdateProfile_Click);
            // 
            // UC_UbahProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dateTimePickerTglLahir);
            this.Controls.Add(this.comboBoxKota);
            this.Controls.Add(this.textBoxNoKtp);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxNamaLengkap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSimpanUpdateProfile);
            this.Controls.Add(this.panelFotoDiri);
            this.Name = "UC_UbahProfile";
            this.Size = new System.Drawing.Size(1295, 1214);
            this.Load += new System.EventHandler(this.UC_UbahProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoProfile)).EndInit();
            this.panelFotoDiri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFotoProfile;
        private System.Windows.Forms.Panel panelFotoDiri;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglLahir;
        private System.Windows.Forms.ComboBox comboBoxKota;
        private System.Windows.Forms.TextBox textBoxNoKtp;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxNamaLengkap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSimpanUpdateProfile;
        private System.Windows.Forms.Button buttonEditFotoProfil;
        private System.Windows.Forms.Button buttonEditFotoDiri;
    }
}
