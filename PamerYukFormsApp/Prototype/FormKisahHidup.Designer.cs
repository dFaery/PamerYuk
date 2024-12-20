﻿namespace PamerYukFormsApp.Prototype
{
    partial class FormKisahHidup
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
            this.labelTangalLahir = new System.Windows.Forms.Label();
            this.labelKota = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxDeskripsi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFormDaftar = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.numericUpDownTahunAkhir = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTahunAwal = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOrganisasi = new System.Windows.Forms.ComboBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahunAkhir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahunAwal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTangalLahir
            // 
            this.labelTangalLahir.AutoSize = true;
            this.labelTangalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTangalLahir.Location = new System.Drawing.Point(142, 341);
            this.labelTangalLahir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTangalLahir.Name = "labelTangalLahir";
            this.labelTangalLahir.Size = new System.Drawing.Size(153, 29);
            this.labelTangalLahir.TabIndex = 39;
            this.labelTangalLahir.Text = "Tahun Akhir :";
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelKota.Location = new System.Drawing.Point(142, 268);
            this.labelKota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(157, 29);
            this.labelKota.TabIndex = 36;
            this.labelKota.Text = "Tahun Awal : ";
            // 
            // buttonInput
            // 
            this.buttonInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonInput.Location = new System.Drawing.Point(625, 381);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(178, 39);
            this.buttonInput.TabIndex = 35;
            this.buttonInput.Text = "Input Kisah";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxDeskripsi
            // 
            this.textBoxDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxDeskripsi.Location = new System.Drawing.Point(403, 185);
            this.textBoxDeskripsi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDeskripsi.Name = "textBoxDeskripsi";
            this.textBoxDeskripsi.Size = new System.Drawing.Size(402, 34);
            this.textBoxDeskripsi.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(142, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Deskripsi :";
            // 
            // labelFormDaftar
            // 
            this.labelFormDaftar.AutoSize = true;
            this.labelFormDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelFormDaftar.Location = new System.Drawing.Point(322, 11);
            this.labelFormDaftar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormDaftar.Name = "labelFormDaftar";
            this.labelFormDaftar.Size = new System.Drawing.Size(330, 63);
            this.labelFormDaftar.TabIndex = 29;
            this.labelFormDaftar.Text = "Kisah Hidup";
            this.labelFormDaftar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUsername.Location = new System.Drawing.Point(142, 83);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(147, 29);
            this.labelUsername.TabIndex = 26;
            this.labelUsername.Text = "Organisasi : ";
            // 
            // numericUpDownTahunAkhir
            // 
            this.numericUpDownTahunAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownTahunAkhir.Location = new System.Drawing.Point(403, 340);
            this.numericUpDownTahunAkhir.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTahunAkhir.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownTahunAkhir.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownTahunAkhir.Name = "numericUpDownTahunAkhir";
            this.numericUpDownTahunAkhir.Size = new System.Drawing.Size(155, 34);
            this.numericUpDownTahunAkhir.TabIndex = 40;
            this.numericUpDownTahunAkhir.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // numericUpDownTahunAwal
            // 
            this.numericUpDownTahunAwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownTahunAwal.Location = new System.Drawing.Point(403, 266);
            this.numericUpDownTahunAwal.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTahunAwal.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownTahunAwal.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownTahunAwal.Name = "numericUpDownTahunAwal";
            this.numericUpDownTahunAwal.Size = new System.Drawing.Size(155, 34);
            this.numericUpDownTahunAwal.TabIndex = 41;
            this.numericUpDownTahunAwal.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // comboBoxOrganisasi
            // 
            this.comboBoxOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxOrganisasi.FormattingEnabled = true;
            this.comboBoxOrganisasi.Location = new System.Drawing.Point(403, 82);
            this.comboBoxOrganisasi.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOrganisasi.Name = "comboBoxOrganisasi";
            this.comboBoxOrganisasi.Size = new System.Drawing.Size(423, 37);
            this.comboBoxOrganisasi.TabIndex = 42;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonTambah.Location = new System.Drawing.Point(704, 128);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(122, 45);
            this.buttonTambah.TabIndex = 43;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(392, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tidak ada organisasi anda?";
            // 
            // FormKisahHidup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.comboBoxOrganisasi);
            this.Controls.Add(this.numericUpDownTahunAwal);
            this.Controls.Add(this.numericUpDownTahunAkhir);
            this.Controls.Add(this.labelTangalLahir);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textBoxDeskripsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFormDaftar);
            this.Controls.Add(this.labelUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKisahHidup";
            this.Text = "FormKisahHidup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKisahHidup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahunAkhir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahunAwal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTangalLahir;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxDeskripsi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFormDaftar;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.NumericUpDown numericUpDownTahunAkhir;
        private System.Windows.Forms.NumericUpDown numericUpDownTahunAwal;
        private System.Windows.Forms.ComboBox comboBoxOrganisasi;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
    }
}