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
        private User penerimaUser;
        private List<int> cariIndex = new List<int>();
        private List<Chat> chat = new List<Chat> ();
        public UC_Chat(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UC_Chat_Load(object sender, EventArgs e)
        {
            flowLayoutPanelChat.AutoScroll = true;
            flowLayoutPanelChat.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelChat.WrapContents = false;
            SearchChatOnLoad();

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
            MainForm.service.Kirim_Chat(new Chat(pesan, MainForm.service.Current_user.Username, this.penerimaUser.Username));
            Refresh_Chat_Room();
        }

        private void panelContactHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Open_Chat_Room(string receiver)
        {
            listBoxChat.DataSource = new List<Chat>();
            if(receiver !="")
            {
                this.penerimaUser = MainForm.service.Cari_AkunTeman(receiver);
                this.labelContactName.Text = penerimaUser.Username;
                this.chat = MainForm.service.Buka_Chat(receiver);
                listBoxChat.DataSource = this.chat;
                pictureBoxProfile.Image = new Bitmap(penerimaUser.FotoProfil);
                pictureBoxProfile.BackgroundImageLayout = ImageLayout.Zoom;
                Make_Chat_On_Top(Newest_Chat());
            }
        }

        private void Refresh_Chat_Room()
        {
            listBoxChat.DataSource = new List<Chat>();
            this.chat = MainForm.service.Buka_Chat(this.penerimaUser.Username);
            listBoxChat.DataSource = this.chat;
            this.textBoxMessage.Clear();
            this.textBoxMessage.Focus();
            Make_Chat_On_Top(Newest_Chat());
        }
        private void Make_Chat_On_Top(int index)
        {
            //Agar chat terbaru selalu dibawah dan terlihat
            int visibleItems = listBoxChat.ClientSize.Height / listBoxChat.ItemHeight;
            listBoxChat.TopIndex = Math.Max(index - visibleItems + 1, 0);
        }

        private void Make_Chat_On_Top2(int index)
        {
            listBoxChat.TopIndex = index;
            listBoxChat.SelectedIndex = index;
        }

        private int Newest_Chat()
        {
            return listBoxChat.Items.Count;
        }

        private void SearchChatOnLoad()
        {
            btnCloseChat.Visible = false;
        }

        private void btnSearchChatClicked()
        {
        }

        private void pictureBoxCari_Click(object sender, EventArgs e)
        {
            btnCariChat.Visible = false;
            btnCloseChat.Visible = true;
            string pesan = textBoxCariChat.Text;
            cariIndex = MainForm.service.Cari_Chat(this.chat, this.penerimaUser.Username, pesan);
            if(cariIndex.Count >0)
            {
                numericUpDownCariChat.Value = cariIndex.Count;
                Make_Chat_On_Top2(cariIndex[(int)numericUpDownCariChat.Value - 1]);
            }
            else
            {
                textBoxCariChat.Clear();
                numericUpDownCariChat.Value = 0;
                btnCloseChat_Click(sender, e);
            }
        }

        private void numericUpDownCariChat_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownCariChat.Value<1)
            {
                numericUpDownCariChat.Value = cariIndex.Count;
            }
            if(numericUpDownCariChat.Value>cariIndex.Count)
            {
                numericUpDownCariChat.Value = 1;
            }
            if(numericUpDownCariChat.Value!=0)
            {
                Make_Chat_On_Top2(cariIndex[(int)numericUpDownCariChat.Value - 1]);
            }
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            cariIndex = new List<int>();
            numericUpDownCariChat.Value = 0;
        }    

        private void btnCloseChat_Click(object sender, EventArgs e)
        {
            btnCariChat.Visible = true;
            textBoxCariChat.Clear();
            numericUpDownCariChat.Value = 0;
        }

        private void dateTimePickerChatDate_ValueChanged(object sender, EventArgs e)
        {
            cariIndex = MainForm.service.Cari_Chat_ByTanggal(this.chat,dateTimePickerChatDate.Value);
            if(cariIndex.Count >0)
            {
                numericUpDownCariChat.Value = cariIndex.Count;
                Make_Chat_On_Top2(cariIndex[(int)numericUpDownCariChat.Value - 1]);
            }
            else
            {
                numericUpDownCariChat.Value = 0;
                btnCloseChat_Click(sender, e);
            }
        }
    }
}
