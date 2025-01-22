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
    public partial class UC_NotesPanel : UserControl
    {
        UC_NotesChat uc_notesChat;
        Chat chat;
        public UC_NotesPanel(UC_NotesChat uc_notesChat, Chat chat)
        {
            InitializeComponent();
            this.uc_notesChat = uc_notesChat;
            this.chat = chat;
        }

        private void UC_NotesPanel_Load(object sender, EventArgs e)
        {
            pictureBoxPengirim.BackgroundImage = DisplayChat(this.chat.Pesan, this.chat.TglTerkirim, this.chat.Pengirim);
            pictureBoxPengirim.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private Image DisplayChat(string pesan, DateTime tglKirim, string senderUSN)
        {
            labelHariPostNote.Text = tglKirim.ToString();
            return new Bitmap(MainForm.service.Cari_AkunTeman(senderUSN).FotoProfil);
        }

        private void DisplayNotes()
        {
            List<string> noteContent = new List<string>();
            foreach (string isi in this.chat.Pesan.Split('\n'))
            {
                noteContent.Add(isi);
            }
        }
    }
}
