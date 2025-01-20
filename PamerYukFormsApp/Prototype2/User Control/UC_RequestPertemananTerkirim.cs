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
    public partial class UC_RequestPertemananTerkirim : UserControl
    {
        UC_PermintaanPertemanan uc;
        private string username;
        private DateTime dateTime;
        public UC_RequestPertemananTerkirim(UC_PermintaanPertemanan uc)
        {
            InitializeComponent();
            this.uc = uc;
        }
        
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
        private void UC_RequestPertemananTerkirim_Load(object sender, EventArgs e)
        {

        }

        private void buttonKirimUlang_Click(object sender, EventArgs e)
        {
            MainForm.service.KirimUlang_Pertemanan(this.Username);
            MessageBox.Show("Berhasil Mengirim Ulang Pertemanan.");
        }
    }
}
