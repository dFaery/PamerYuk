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
    public partial class UC_HomeNew : UserControl
    {
        MainForm mainForm;
        public UC_HomeNew(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnLihatPermintaanPertemanan_Click(object sender, EventArgs e)
        {
            mainForm.panelUtama.Controls.Clear();

            UC_PermintaanPertemanan uc_permintaanPertemanan = new UC_PermintaanPertemanan(this);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uc_permintaanPertemanan);
        }

        private void UC_HomeNew_Load(object sender, EventArgs e)
        {
            mainForm.panel1.Show();
            mainForm.panel1.BringToFront();

            DisplayOnLoad();
        }

        private void dataGridViewDaftarTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarTeman.Columns["buttonLihatAkun"].Index)
            {
                string username = dataGridViewDaftarTeman.CurrentRow.Cells["username"].Value.ToString();
                DateTime tglBerteman = DateTime.Parse(dataGridViewDaftarTeman.CurrentRow.Cells["tglBerteman"].Value.ToString());
                string status = dataGridViewDaftarTeman.CurrentRow.Cells["status"].Value.ToString();

                mainForm.panelUtama.Controls.Clear();

                UC_ProfilTeman uc_profileTeman = new UC_ProfilTeman(this, new Teman(username, tglBerteman, status));
                mainForm.panelUtama.Controls.Remove(this);
                mainForm.panelUtama.Controls.Add(uc_profileTeman);
            }
        }

        private void buttonCariTeman_Click(object sender, EventArgs e)
        {
            mainForm.panelUtama.Controls.Clear();

            UC_CariTeman uC_Daftar = new UC_CariTeman(this);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uC_Daftar);
        }

        #region METHOD 
        private void DisplayOnLoad()
        {
            //Header
            labelCurrentUser.Text = MainForm.service.Current_user.Username;
            labelHariIni.Text = DateTime.Now.ToString("D");

            DisplayRequestPertemananMasuk();
            DisplayDaftarTeman();
        }

        private void DisplayDaftarTeman()
        {
            dataGridViewDaftarTeman.DataSource = MainForm.service.ListTeman;
            dataGridViewDaftarTeman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewDaftarTeman.Columns.Count == 3)
            {
                DataGridViewButtonColumn buttonLihatAkun = new DataGridViewButtonColumn();
                buttonLihatAkun.Text = "Lihat Profil";
                buttonLihatAkun.HeaderText = "Aksi";
                buttonLihatAkun.UseColumnTextForButtonValue = true;
                buttonLihatAkun.Name = "buttonLihatAkun";
                dataGridViewDaftarTeman.Columns.Add(buttonLihatAkun);
            }
        }

        private void DisplayRequestPertemananMasuk()
        {
            List<Teman> listTeman = MainForm.service.Request_Pertemanan(false);
            int jumlahPermintaanMasuk = 0;

            foreach (Teman teman in listTeman)
            {                
                UC_PermintaanPertemanan uc_masuk = new UC_PermintaanPertemanan(this);
                jumlahPermintaanMasuk++;
            }           

            if (jumlahPermintaanMasuk > 0)
            {
                labelJumlahPermintaanMasuk.Text = jumlahPermintaanMasuk.ToString() + " Permintaan Pertemanan Masuk";
            }
            else if (jumlahPermintaanMasuk <= 0)
            {
                labelJumlahPermintaanMasuk.Text = "Tidak Ada Permintaan Pertemanan Baru";
            }           
        }
        #endregion


    }
}
