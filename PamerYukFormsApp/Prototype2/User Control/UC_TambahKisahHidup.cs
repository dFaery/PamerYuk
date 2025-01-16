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
    public partial class UC_TambahKisahHidup : UserControl
    {
        MainForm mainForm;
        UC_Profile uc;
        public UC_TambahKisahHidup(UC_Profile uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_TambahKisahHidup_Load(object sender, EventArgs e)
        {
            comboBoxOrganisasi.DataSource = MainForm.service.ListOrganisasi;
            comboBoxOrganisasi.DisplayMember = "Nama";
        }

        private void buttonTambahOrganisasi_Click(object sender, EventArgs e)
        {
            this.panelKonten.Controls.Clear();

            UC_TambahOrganisasi uC_TambahOrganisasi = new UC_TambahOrganisasi(this);
            this.panelKonten.Controls.Remove(this);
            uC_TambahOrganisasi.Dock = DockStyle.Fill;
            this.panelKonten.Controls.Add(uC_TambahOrganisasi);
        }

        private void buttonTambahKisahHidup_Click(object sender, EventArgs e)
        {
            try
            {
                Organisasi selected_organisasi = (Organisasi)comboBoxOrganisasi.SelectedItem;
                string deskripsi = richTextBoxDeskripsi.Text;
                int tahun_awal = (int)numericUpDownTahunAwal.Value;
                int tahun_akhir = (int)numericUpDownTahunAkhir.Value;
                MainForm.service.Tambah_KisahHidup(selected_organisasi, tahun_awal, tahun_akhir, deskripsi);
                MessageBox.Show("Berhasil membuat kisah hidup");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelKonten_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}