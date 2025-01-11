using PamerYukLibrary;
using PamerYukLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_Chat : UserControl
    {
        MainForm mainForm;
        public string penerima ="";
        private User penerimaUser;
        public UC_Chat(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public void UC_Chat_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanelChat.Controls.Clear();
            if (penerima!="")
            {
                penerimaUser = MainForm.service.Cari_AkunTeman(penerima);
                labelContactName.Text = this.penerima;
                 listBoxChat.DataSource = MainForm.service.Buka_Chat(this.penerima);
                pictureBoxProfile.Image = new Bitmap(penerimaUser.FotoProfil);
                pictureBoxProfile.BackgroundImageLayout = ImageLayout.Zoom;
            }
            /* mainForm.panel1.Show();
             mainForm.panel1.BringToFront();
 */
            flowLayoutPanelChat.AutoScroll = true;
            flowLayoutPanelChat.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelChat.WrapContents = false;

            if(MainForm.service.ListTeman.Count>0)
            {

                foreach (Teman teman in MainForm.service.ListTeman)
                {
                    string username = teman.Username;

                    UC_ChatListItem uc_cl = new UC_ChatListItem(this);

                    uc_cl.Name1 = username;

                    this.flowLayoutPanelChat.Controls.Add(uc_cl);
                }
            }
                    
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            string pesan = textBoxMessage.Text;
            MainForm.service.Kirim_Chat(new Chat(pesan, MainForm.service.Current_user.Username, penerima));
            UC_Chat_Load(sender, e);
        }

        private void panelContactHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
