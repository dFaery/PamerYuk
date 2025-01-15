using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_TambahOrganisasi : UserControl
    {
        MainForm mainForm;
        UC_TambahKisahHidup uc;
        public UC_TambahOrganisasi(UC_TambahKisahHidup uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_TambahOrganisasi_Load(object sender, EventArgs e)
        {
            comboBoxKota.DataSource = FormUtama.service.ListKota;
            comboBoxKota.DisplayMember = "Nama";
            comboBoxKota.SelectedIndex = -1;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string namaOrganisasi = textBoxOrganisasi.Text;
                Kota selectedKota = (Kota)comboBoxKota.SelectedItem;
                if (namaOrganisasi == null || selectedKota == null)
                {
                    MessageBox.Show("Data tidak boleh dikosongi");
                }
                Organisasi newOrganisasi = new Organisasi(namaOrganisasi, selectedKota);
                MainForm.service.Tambah_Organisasi(newOrganisasi);
                MessageBox.Show("Organisasi berhasil ditambahkan");

                textBoxOrganisasi.Clear();
                comboBoxKota.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}