using PamerYukFormsApp.Prototype2.User_Control.FiturChat;
using PamerYukLibrary.Entity;
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
    public partial class UC_TambahBroadCast : UserControl
    {
        UC_ChatNew uc;
        public UC_TambahBroadCast(UC_ChatNew uc)
        {
            InitializeComponent();
            this.uc = uc;
            
        }

        private void UC_TambahBroadCast_Load(object sender, EventArgs e)
        {

        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            string message = textBoxBroadcast.Text;
            MainForm.service.Kirim_Chat_BroadCast(message);
            MessageBox.Show("Pesan telah berhasil dikirimkan ke semua teman anda.");
        }
    }
}
