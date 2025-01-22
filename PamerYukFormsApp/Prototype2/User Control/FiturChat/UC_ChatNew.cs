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
        private Group penerimaGroup;
        private List<int> cariIndex = new List<int>();
        private List<Chat> listChat = new List<Chat>();
        private List<GroupChat> listGroupChat = new List<GroupChat>();
        private List<Size> BubbleSize = new List<Size>(); //BUat yang cari chat
        public string namaPenerima = "";
        private string currentType = "Chat";
        private string currentReceiverType = "teman";
        private int reply_pesan_id=0;
        public UC_ChatNew(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UC_ChatNew_Load(object sender, EventArgs e)
        {
            if(MainForm.service.ListTeman.Count >0)
            {
                DisplayAllFriend();
            }
            labelReply.Visible = false;
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            if(currentReceiverType== "teman")
            {
                string pesan = textBoxMessage.Text;
                if (this.currentType == "Reply")
                {
                    ReplyChatChanger(pesan, this.reply_pesan_id);
                }
                Chat newChat = new Chat(textBoxMessage.Text, MainForm.service.Current_user.Username, this.penerimaUser.Username, this.currentType);
                MainForm.service.Kirim_Chat(newChat);
                //After Send To Service
                this.currentType = "Chat";
            }
            if(currentReceiverType=="group")
            {

            }
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

            UC_NotesChat uC_Daftar = new UC_NotesChat(this,this.penerimaUser.Username);
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

        public void Open_Chat_Room(string receiver)
        {
            flowLayoutPanelChatHistory.Controls.Clear();
            if (receiver != "")
            {
                this.penerimaUser = MainForm.service.Cari_AkunTeman(receiver);
                this.labelContactName.Text = penerimaUser.Username;
                this.listChat = MainForm.service.Buka_Chat(receiver);
                pictureBoxProfile.Image = new Bitmap(penerimaUser.FotoProfil);
                pictureBoxProfile.BackgroundImageLayout = ImageLayout.Zoom;
                DisplayChat();
            }
        }

        public void Open_Chat_Room_Group(string receiver)
        {
            flowLayoutPanelChatHistory.Controls.Clear();
            if (receiver != "")
            {
                //Ganti semua jadi group
                this.penerimaGroup = MainForm.service.Cari_Group(receiver);
                this.labelContactName.Text = penerimaGroup.Nama;
                this.listGroupChat = MainForm.service.Buka_Group_Chat(receiver);
                pictureBoxProfile.Image = new Bitmap(penerimaGroup.FotoProfil);
                pictureBoxProfile.BackgroundImageLayout = ImageLayout.Zoom;
                DisplayGroupChat();
            }
        }


        private void RefreshChat()
        {
            flowLayoutPanelChatHistory.Controls.Clear();
            DisplayChat();
        }

        private void RefreshGroupChart()
        {
            flowLayoutPanelChatHistory.Controls.Clear();
            DisplayGroupChat();
        }

        private void DisplayChat()
        {
            foreach (Chat chat in this.listChat)
            {
                if (chat.TipePesan == "Chat")
                {
                    UC_BubbleChat uc = new UC_BubbleChat(this, chat, false);
                    flowLayoutPanelChatHistory.Controls.Add(uc);   
                }
                if (chat.TipePesan == "Media")
                {
                    UC_BubbleChatShareImage uc = new UC_BubbleChatShareImage(this, chat);
                    flowLayoutPanelChatHistory.Controls.Add(uc);
                }
                if (chat.TipePesan == "Konten")
                {
                    UC_BubbleChatShareKonten uc = new UC_BubbleChatShareKonten(this, chat);
                    flowLayoutPanelChatHistory.Controls.Add(uc);
                }
                if (chat.TipePesan == "Reply")
                {
                    UC_BubbleChat uc = new UC_BubbleChat(this, chat,true);
                    flowLayoutPanelChatHistory.Controls.Add(uc);
                }
            }
        }

        private void DisplayGroupChat()
        {
            foreach (GroupChat groupChat in this.listGroupChat)
            {
                if (groupChat.TipePesan == "Chat")
                {
                    UC_BubbleChat uc = new UC_BubbleChat(this, groupChat, false);
                    flowLayoutPanelChatHistory.Controls.Add(uc);
                }
                if (groupChat.TipePesan == "Media")
                {
                    UC_BubbleChatShareImage uc = new UC_BubbleChatShareImage(this, groupChat);
                    flowLayoutPanelChatHistory.Controls.Add(uc);
                }
                if (groupChat.TipePesan == "Konten")
                {
                    UC_BubbleChatShareKonten uc = new UC_BubbleChatShareKonten(this, groupChat);
                    flowLayoutPanelChatHistory.Controls.Add(uc);
                }
                if (groupChat.TipePesan == "Reply")
                {
                    UC_BubbleChat uc = new UC_BubbleChat(this, groupChat, true);
                    flowLayoutPanelChatHistory.Controls.Add(uc);
                }
            }
        }

        private void DisplayAllFriend()
        {
            foreach (Teman teman in MainForm.service.ListTeman)
            {
                UC_ChatListItem uc = new UC_ChatListItem(this);
                uc.Name1 = teman.Username;
                flowLayoutPanelChat.Controls.Add(uc);
            }
        }

        private void DisplayAllGroup()
        {
            foreach (Group group in MainForm.service.ListGroup)
            {
                UC_ChatListItem uc = new UC_ChatListItem(this);
                uc.Name1 = group.Id.ToString();
                uc.type="group";
                flowLayoutPanelChat.Controls.Add(uc);
            }
        }

        private void ChangeToGroup()
        {
            this.currentReceiverType = "group";
        }

        private void btnShareImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                FormKirimGambar frm = new FormKirimGambar(this.penerimaUser.Username, fd);
                frm.Owner = mainForm;
                frm.ShowDialog();
            }
        }

        public void Now_Reply(int id, string msg)
        {
            this.reply_pesan_id = id;
            labelReply.Text = "Replying : " + msg;
            labelReply.Visible = true;
        }
        private void ReplyChatChanger(string pesan,int id)
        {
            pesan = id.ToString().PadLeft(10,'0')+" "+pesan;
        }

        private void pictureBoxGroup_Click(object sender, EventArgs e)
        {
            flowLayoutPanelChat.Controls.Clear();
            DisplayAllGroup();
        }
    }
}
