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
    public partial class UC_CariTeman : UserControl
    {
        UC_Home uc;
        Organisasi selectedOrganisasi = new Organisasi();
        public UC_CariTeman(UC_Home uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_CariTeman_Load(object sender, EventArgs e)
        {
            comboBoxOrganisasi.DataSource = MainForm.service.ListOrganisasi;
            comboBoxOrganisasi.DisplayMember = "Nama";
            comboBoxOrganisasi.SelectedIndex = -1;            
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string usn = textBoxUsername.Text;
            if (textBoxUsername.Text != "")
            {
                dataGridViewCariTeman.DataSource = MainForm.service.Cari_Teman(usn);
                dataGridViewCariTeman.Columns.RemoveAt(1);
            }
            if (comboBoxOrganisasi.SelectedIndex != -1)
            {
                dataGridViewCariTeman.DataSource = MainForm.service.Cari_Teman(selectedOrganisasi);                
                dataGridViewCariTeman.Columns.RemoveAt(1);                
            }
            if (dataGridViewCariTeman.Columns.Count == 8)
            {
                DataGridViewButtonColumn buttonTambahTeman = new DataGridViewButtonColumn();
                buttonTambahTeman.Text = "Kirim Permintaan Pertemanan";
                buttonTambahTeman.HeaderText = "Tambah Teman";
                buttonTambahTeman.UseColumnTextForButtonValue = true;
                buttonTambahTeman.Name = "buttonTambahTeman";
                dataGridViewCariTeman.Columns.Add(buttonTambahTeman);
            }            
        }

        private void comboBoxOrganisasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOrganisasi = (Organisasi)comboBoxOrganisasi.SelectedItem;
        }

        private void dataGridViewCariTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCariTeman.Columns["buttonTambahTeman"].Index)
            {
                string username = dataGridViewCariTeman.CurrentRow.Cells["username"].Value.ToString();
                MainForm.service.Request_Pertemanan(username);
                MessageBox.Show("Berhasil Mengajukan Pertemanan");
            }
        }
    }
}
