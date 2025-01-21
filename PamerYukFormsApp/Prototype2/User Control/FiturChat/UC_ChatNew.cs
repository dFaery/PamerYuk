using PamerYukLibrary.Entity;
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

namespace PamerYukFormsApp.Prototype2.User_Control.FiturChat
{
    public partial class UC_ChatNew : UserControl
    {
        MainForm mainForm;
        private User penerimaUser;
        private List<int> cariIndex = new List<int>();
        private List<Chat> chat = new List<Chat>();
        public UC_ChatNew(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UC_ChatNew_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNewGroup_Click(object sender, EventArgs e)
        {
            mainForm.panelUtama.Controls.Clear();

            UC_TambahGroup uC_Daftar = new UC_TambahGroup(this);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uC_Daftar);
        }

        private void panelContactHeader_Click(object sender, EventArgs e)
        {
            mainForm.panelUtama.Controls.Clear();

            UC_NotesChat uC_Daftar = new UC_NotesChat(this);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uC_Daftar);
        }

        private void btnBroadCast_Click(object sender, EventArgs e)
        {
            mainForm.panelUtama.Controls.Clear();

            UC_TambahBroadCast uc_tambahBroadcast = new UC_TambahBroadCast(this);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uc_tambahBroadcast);
        }
    }
}
