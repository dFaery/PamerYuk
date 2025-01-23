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
    public partial class UC_BubbleChatShareImage : UserControl
    {
        UC_ChatNew uc_chatNew;
        Chat chat;
        GroupChat groupChat;
        private bool isGroup = false;

        public UC_BubbleChatShareImage(UC_ChatNew bubbleChat, Chat chat)
        {
            InitializeComponent();
            this.uc_chatNew = bubbleChat;
            this.chat=chat;
        }

        public UC_BubbleChatShareImage(UC_ChatNew bubbleChat, GroupChat groupChat)
        {
            InitializeComponent();
            this.uc_chatNew = bubbleChat;
            this.groupChat = groupChat;
            this.isGroup = true;
        }

        private void UC_BubbleChatShareImage_Load(object sender, EventArgs e)
        {
            if (!this.isGroup)
            {
                if (this.chat.Pengirim != MainForm.service.Current_user.Username)
                {
                    pictureBoxTeman.BackgroundImage = DisplayChat(this.chat.Pesan, this.chat.TglTerkirim, this.chat.Pengirim);
                    pictureBoxTeman.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxUser.Visible = false;
                }
                else
                {
                    pictureBoxUser.BackgroundImage = DisplayChat(this.chat.Pesan, this.chat.TglTerkirim, this.chat.Pengirim);
                    pictureBoxUser.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxTeman.Visible = false;
                }
            }
            else
            {
                if (this.groupChat.Pengirim != MainForm.service.Current_user.Username)
                {
                    pictureBoxTeman.BackgroundImage = DisplayChat(this.groupChat.Pesan, this.groupChat.TglTerkirim, this.groupChat.Pengirim);
                    pictureBoxTeman.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxUser.Visible = false;
                }
                else
                {
                    pictureBoxUser.BackgroundImage = DisplayChat(this.groupChat.Pesan, this.groupChat.TglTerkirim, this.groupChat.Pengirim);
                    pictureBoxUser.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxTeman.Visible = false;
                }
            }
            DisplayImage();
        }

        private Image DisplayChat(string pesan, DateTime tglKirim, string senderUSN)
        {
            labelTanggal.Text = tglKirim.ToString();
            return new Bitmap(MainForm.service.Cari_AkunTeman(senderUSN).FotoProfil);
        }

        private void DisplayImage()
        {
            if(!this.isGroup)
            {
                if (this.chat.Pesan != "null")
                {
                    pictureBoxPhoto.BackgroundImage = new Bitmap(this.chat.Pesan);
                    pictureBoxPhoto.BackgroundImageLayout = ImageLayout.Zoom;
                }

            }
            else
            {
                if (this.groupChat.Pesan != "null")
                {
                    pictureBoxPhoto.BackgroundImage = new Bitmap(this.groupChat.Pesan);
                    pictureBoxPhoto.BackgroundImageLayout = ImageLayout.Zoom;
                }

            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {

            uc_chatNew.Now_Reply(this.chat.Id, this.chat.Pesan + " Media");
        }
    }
}
