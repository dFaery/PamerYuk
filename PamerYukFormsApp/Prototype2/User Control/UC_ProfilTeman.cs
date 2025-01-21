using PamerYukFormsApp.Prototype;
using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_ProfilTeman : UserControl
    {
        UC_HomeNew uc;
        User selectedUser;
        Konten selectedKonten;
        MainForm mainForm;

        public UC_ProfilTeman(UC_HomeNew uc, Teman selectedTeman)
        {
            InitializeComponent();
            this.uc = uc;
            selectedUser = MainForm.service.Cari_AkunTeman_Data(selectedTeman.Username);
        }
        private void UC_ProfilTeman_Load(object sender, EventArgs e)
        {
            DisplayOnLoad();
            if (this.selectedUser.FotoProfil != "null")
            {
                if (File.Exists(this.selectedUser.FotoProfil))
                {
                    Image image = new Bitmap(File.OpenRead(this.selectedUser.FotoProfil));
                    panelFotoProfil.BackgroundImage = image;
                    panelFotoProfil.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }            
        }

        #region Method
        private void DisplayOnLoad()
        {            
            labelUsername.Text = selectedUser.Username;
            labelTanggalLahir.Text = selectedUser.TglLahir.ToString("yyyy-MM-dd");
            labelKota.Text = selectedUser.Kota.ToString();
            foreach (KisahHidup kisahHidup in selectedUser.ListKisahHidup)
            {
                string[] buffer = new string[5];
                buffer = kisahHidup.ToString().Split('\n');
                foreach (string s in buffer)
                {
                    listBoxKisahHidup.Items.Add(s);
                }
                listBoxKisahHidup.Items.Add("================");
            }
            DisplayDaftarKonten();
        }

        private void DisplayDaftarKonten()
        {

            dataGridViewKontenTeman.DataSource = selectedUser.ListKonten;
            dataGridViewKontenTeman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            if (dataGridViewKontenTeman.Columns.Count == 6)
            {
                DataGridViewButtonColumn btnLihat = new DataGridViewButtonColumn();
                btnLihat.Text = "Lihat";
                btnLihat.HeaderText = "Lihat Konten";
                btnLihat.UseColumnTextForButtonValue = true;
                btnLihat.Name = "btnLihat";
                dataGridViewKontenTeman.Columns.Add(btnLihat);
            }
        }
        #endregion

        private void dataGridViewKontenTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewKontenTeman.Columns["btnLihat"].Index)
            {
                int kid = int.Parse(dataGridViewKontenTeman.CurrentRow.Cells["id"].Value.ToString());

                panelKontenUtama.Controls.Clear();
                UC_KontenDetail uc_kontenDetail = new UC_KontenDetail(this, kid);
                panelKontenUtama.Controls.Remove(this);
                panelKontenUtama.Controls.Add(uc_kontenDetail);
                
            }
        }

        private void panelKontenUtama_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInformasiAkun_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxKisahHidup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
