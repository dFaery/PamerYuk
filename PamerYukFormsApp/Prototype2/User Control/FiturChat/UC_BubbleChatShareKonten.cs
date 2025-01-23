using PamerYukLibrary;
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
    public partial class UC_BubbleChatShareKonten : UserControl
    {
        UC_ChatNew uc;
        Chat chat;
        GroupChat groupChat;
        Konten selectedKonten;
        public UC_BubbleChatShareKonten(UC_ChatNew uc, Chat chat)
        {
            InitializeComponent();
            this.uc = uc;
            this.chat = chat;
        }

        public UC_BubbleChatShareKonten(UC_ChatNew uc, GroupChat groupChat)
        {
            InitializeComponent();
            this.uc = uc;
            this.groupChat = groupChat;
        }

        private void UC_BubbleChatShareKonten_Load(object sender, EventArgs e)
        {
            if (this.chat != null)
            {
                selectedKonten = MainForm.service.Lihat_Konten(int.Parse(this.chat.Pesan));
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
                selectedKonten = MainForm.service.Lihat_Konten(int.Parse(this.groupChat.Pesan));
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
            labelContentOwnerName.Text = MainForm.service.Lihat_PemilikKonten(this.selectedKonten.Id);
            pictureBoxContentOwnerBorder.BackgroundImage = new Bitmap(MainForm.service.Cari_AkunTeman(labelContentOwnerName.Text).FotoProfil);
            return new Bitmap(MainForm.service.Cari_AkunTeman(senderUSN).FotoProfil);
        }

        private void DisplayImage()
        {
            if(this.selectedKonten.Foto != "null")
            {
                panelContent.BackgroundImage = new Bitmap(this.selectedKonten.Foto);
                panelContent.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void buttonLihatKontenDetail_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxReply1_Click(object sender, EventArgs e)
        {

        }
    }
}
