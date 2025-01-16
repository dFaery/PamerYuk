namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_ProfilTeman
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
            this.panelFotoProfil = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxKisahHidup = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelKisahHidup = new System.Windows.Forms.Label();
            this.panelInformasiAkun = new System.Windows.Forms.Panel();
            this.labelTanggalLahir = new System.Windows.Forms.Label();
            this.labelKota = new System.Windows.Forms.Label();
            this.panelKontenUtama = new System.Windows.Forms.Panel();
            this.dataGridViewKontenTeman = new System.Windows.Forms.DataGridView();
            this.labelKonten = new System.Windows.Forms.Label();
            this.panelInformasiAkun.SuspendLayout();
            this.panelKontenUtama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontenTeman)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFotoProfil
            // 
            this.panelFotoProfil.Location = new System.Drawing.Point(144, 76);
            this.panelFotoProfil.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelFotoProfil.Name = "panelFotoProfil";
            this.panelFotoProfil.Size = new System.Drawing.Size(300, 301);
            this.panelFotoProfil.TabIndex = 104;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(151, 397);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(260, 46);
            this.labelUsername.TabIndex = 106;
            this.labelUsername.Text = "Nama Teman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 564);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 39);
            this.label2.TabIndex = 109;
            this.label2.Text = "Tanggal Lahir : ";
            // 
            // listBoxKisahHidup
            // 
            this.listBoxKisahHidup.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxKisahHidup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxKisahHidup.FormattingEnabled = true;
            this.listBoxKisahHidup.ItemHeight = 31;
            this.listBoxKisahHidup.Location = new System.Drawing.Point(35, 685);
            this.listBoxKisahHidup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxKisahHidup.Name = "listBoxKisahHidup";
            this.listBoxKisahHidup.Size = new System.Drawing.Size(526, 217);
            this.listBoxKisahHidup.TabIndex = 112;
            this.listBoxKisahHidup.SelectedIndexChanged += new System.EventHandler(this.listBoxKisahHidup_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 504);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 39);
            this.label4.TabIndex = 107;
            this.label4.Text = "Kota : ";
            // 
            // labelKisahHidup
            // 
            this.labelKisahHidup.AutoSize = true;
            this.labelKisahHidup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKisahHidup.Location = new System.Drawing.Point(28, 626);
            this.labelKisahHidup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKisahHidup.Name = "labelKisahHidup";
            this.labelKisahHidup.Size = new System.Drawing.Size(229, 39);
            this.labelKisahHidup.TabIndex = 111;
            this.labelKisahHidup.Text = "Kisah Hidup : ";
            // 
            // panelInformasiAkun
            // 
            this.panelInformasiAkun.BackColor = System.Drawing.Color.AliceBlue;
            this.panelInformasiAkun.Controls.Add(this.labelTanggalLahir);
            this.panelInformasiAkun.Controls.Add(this.labelKota);
            this.panelInformasiAkun.Controls.Add(this.panelFotoProfil);
            this.panelInformasiAkun.Controls.Add(this.labelUsername);
            this.panelInformasiAkun.Controls.Add(this.label2);
            this.panelInformasiAkun.Controls.Add(this.listBoxKisahHidup);
            this.panelInformasiAkun.Controls.Add(this.label4);
            this.panelInformasiAkun.Controls.Add(this.labelKisahHidup);
            this.panelInformasiAkun.Location = new System.Drawing.Point(4, 2);
            this.panelInformasiAkun.Margin = new System.Windows.Forms.Padding(5);
            this.panelInformasiAkun.Name = "panelInformasiAkun";
            this.panelInformasiAkun.Size = new System.Drawing.Size(599, 1048);
            this.panelInformasiAkun.TabIndex = 118;
            this.panelInformasiAkun.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInformasiAkun_Paint);
            // 
            // labelTanggalLahir
            // 
            this.labelTanggalLahir.AutoSize = true;
            this.labelTanggalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggalLahir.Location = new System.Drawing.Point(347, 564);
            this.labelTanggalLahir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTanggalLahir.Name = "labelTanggalLahir";
            this.labelTanggalLahir.Size = new System.Drawing.Size(201, 39);
            this.labelTanggalLahir.TabIndex = 114;
            this.labelTanggalLahir.Text = "dd-MM-yyyy";
            this.labelTanggalLahir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKota.Location = new System.Drawing.Point(469, 504);
            this.labelKota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(87, 39);
            this.labelKota.TabIndex = 113;
            this.labelKota.Text = "Kota";
            this.labelKota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelKontenUtama
            // 
            this.panelKontenUtama.Controls.Add(this.dataGridViewKontenTeman);
            this.panelKontenUtama.Controls.Add(this.labelKonten);
            this.panelKontenUtama.Location = new System.Drawing.Point(608, 0);
            this.panelKontenUtama.Margin = new System.Windows.Forms.Padding(5);
            this.panelKontenUtama.Name = "panelKontenUtama";
            this.panelKontenUtama.Size = new System.Drawing.Size(1664, 1051);
            this.panelKontenUtama.TabIndex = 122;
            this.panelKontenUtama.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKontenUtama_Paint);
            // 
            // dataGridViewKontenTeman
            // 
            this.dataGridViewKontenTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontenTeman.Location = new System.Drawing.Point(92, 274);
            this.dataGridViewKontenTeman.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewKontenTeman.Name = "dataGridViewKontenTeman";
            this.dataGridViewKontenTeman.RowHeadersWidth = 62;
            this.dataGridViewKontenTeman.RowTemplate.Height = 28;
            this.dataGridViewKontenTeman.Size = new System.Drawing.Size(1479, 665);
            this.dataGridViewKontenTeman.TabIndex = 123;
            this.dataGridViewKontenTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKontenTeman_CellContentClick);
            // 
            // labelKonten
            // 
            this.labelKonten.AutoSize = true;
            this.labelKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelKonten.Location = new System.Drawing.Point(597, 112);
            this.labelKonten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKonten.Name = "labelKonten";
            this.labelKonten.Size = new System.Drawing.Size(397, 120);
            this.labelKonten.TabIndex = 122;
            this.labelKonten.Text = "Konten";
            this.labelKonten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_ProfilTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelInformasiAkun);
            this.Controls.Add(this.panelKontenUtama);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_ProfilTeman";
            this.Size = new System.Drawing.Size(2272, 1051);
            this.Load += new System.EventHandler(this.UC_ProfilTeman_Load);
            this.panelInformasiAkun.ResumeLayout(false);
            this.panelInformasiAkun.PerformLayout();
            this.panelKontenUtama.ResumeLayout(false);
            this.panelKontenUtama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontenTeman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFotoProfil;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxKisahHidup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelKisahHidup;
        private System.Windows.Forms.Panel panelInformasiAkun;
        private System.Windows.Forms.Label labelTanggalLahir;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.Panel panelKontenUtama;
        private System.Windows.Forms.DataGridView dataGridViewKontenTeman;
        private System.Windows.Forms.Label labelKonten;
    }
}
