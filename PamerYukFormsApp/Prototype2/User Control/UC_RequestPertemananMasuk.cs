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
    public partial class UC_RequestPertemananMasuk : UserControl
    {
        UC_PermintaanPertemanan uc;
        public UC_RequestPertemananMasuk(UC_PermintaanPertemanan uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private string username;
        private DateTime dateTime;

        public string Username
        {
            get { return username; }
            set { username = value; labelUsername.Text = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; labelTanggalKirim.Text = dateTime.ToString(); }
        }        

        private void UC_RequestPertemananMasuk_Load(object sender, EventArgs e)
        {

        }

        private void buttonTerima_Click(object sender, EventArgs e)
        {
            MainForm.service.Terima_Pertemanan(this.Username);
            MessageBox.Show("Selamat! Anda sekarang berteman dengan " + this.Username);            
        }

        private void buttonTolak_Click(object sender, EventArgs e)
        {
            MainForm.service.Tolak_Pertemanan(this.Username);
            MessageBox.Show("Anda menolak pertemanan dari "+this.Username);
        }
    }
}
