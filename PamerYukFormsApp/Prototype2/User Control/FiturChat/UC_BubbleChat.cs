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
        private bool isReply = false;
        public string replyContent = "";
        public UC_BubbleChat(UC_ChatNew bubbleChat, Chat chat, bool isReply)
        {
            InitializeComponent();
            this.uc_chatNew = bubbleChat;
            this.chat = chat;
            this. isReply = isReply;
        }

        private void UC_BubbleChat_Load(object sender, EventArgs e)
        {
            if(this.chat.Pengirim != MainForm.service.Current_user.Username)
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

        private Image DisplayChat(string pesan, DateTime tglKirim, string senderUSN)
        {
            if(isReply)
            {
                labelPesan.Text += "Replying\n" + replyContent + "\n";
            }
            labelPesan.Text = pesan;
            labelTanggal.Text = tglKirim.ToString();
            return new Bitmap(MainForm.service.Cari_AkunTeman(senderUSN).FotoProfil);
        }
    }
}
