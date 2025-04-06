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

namespace PamerYukFormsApp.Prototype2.User_Control.FiturChat
{
    public partial class UC_BubbleChat : UserControl
    {
        UC_ChatNew uc_chatNew;
        Chat chat;
        GroupChat groupChat;
        private bool isReply = false;
        private bool isGroup = false;
        public UC_BubbleChat(UC_ChatNew bubbleChat, Chat chat, bool isReply)
        {
            InitializeComponent();
            this.uc_chatNew = bubbleChat;
            this.chat = chat;
            this.isReply = isReply;
        }

        public UC_BubbleChat(UC_ChatNew bubbleChat, GroupChat groupChat, bool isReply)
        {
            InitializeComponent();
            this.uc_chatNew = bubbleChat;
            this.groupChat = groupChat;
            this.isReply = isReply;
            this.isGroup = true;
        }

        private void UC_BubbleChat_Load(object sender, EventArgs e)
        {
            if (!this.isGroup)
            {
                if (this.chat.Pengirim != MainForm.service.Current_user.Username)
                {
                    pictureBoxTeman.BackgroundImage = DisplayChat(this.chat.Pesan, this.chat.TglTerkirim, this.chat.Pengirim);
                    pictureBoxTeman.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxUIser.Visible = false;
                }
                else
                {
                    pictureBoxUIser.BackgroundImage = DisplayChat(this.chat.Pesan, this.chat.TglTerkirim, this.chat.Pengirim);
                    pictureBoxUIser.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxTeman.Visible = false;
                }
            }
            else
            {
                if (this.groupChat.Pengirim != MainForm.service.Current_user.Username)
                {
                    pictureBoxTeman.BackgroundImage = DisplayChat(this.groupChat.Pesan, this.groupChat.TglTerkirim, this.groupChat.Pengirim);
                    pictureBoxTeman.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxUIser.Visible = false;
                }
                else
                {
                    pictureBoxUIser.BackgroundImage = DisplayChat(this.groupChat.Pesan, this.groupChat.TglTerkirim, this.groupChat.Pengirim);
                    pictureBoxUIser.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxTeman.Visible = false;
                }
            }
        }

        private Image DisplayChat(string pesan, DateTime tglKirim, string senderUSN)
        {
            if(isReply)
            {
                Chat reply = MainForm.service.Buka_Reply(int.Parse(pesan.Substring(0, 10)));
                string buffer = reply.Pesan;
                if(reply.TipePesan=="Reply")
                {
                    buffer = ReplySplitter(pesan);
                }
                labelPesan.Text = "Replying : " + buffer + "\n-\n" + ReplySplitter(pesan);
            }
            else
            {
                labelPesan.Text = pesan;
            }
            labelTanggal.Text = tglKirim.ToString();
            return new Bitmap(MainForm.service.Cari_AkunTeman(senderUSN).FotoProfil);
        }

        private string ReplySplitter(string pesan)
        {
            return pesan.Substring(11);
        }

        private void btnReplyTeman_Click(object sender, EventArgs e)
        {
            uc_chatNew.Now_Reply(this.chat.Id, this.chat.Pesan);
        }
    }
}
