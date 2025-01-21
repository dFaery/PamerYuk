using PamerYukFormsApp.Prototype2.User_Control.FiturChat;
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

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_ChatListItem : UserControl
    {
        #region Data Member
        UC_ChatNew uc_Chat;
        Panel panel;

        private string name;
        private Image image;
        public string type = "teman";
        #endregion

        #region Properties
        public string Name1
        {
            get { return name; }
            set { name = value; labelContactName.Text = value; }
        }

        public Image Image
        {
            get { return image; }
            set { Image = value; profilePicture.Image = Properties.Resources.default_profile_picture; }
        }
        #endregion
        public UC_ChatListItem(UC_ChatNew uc_Chat)
        {
            InitializeComponent();
            this.uc_Chat = uc_Chat;
        }



        private void UC_ChatListItem_Load(object sender, EventArgs e)
        {
            profilePicture.BackgroundImage = new Bitmap(MainForm.service.Cari_AkunTeman(this.Name1).FotoProfil);
            profilePicture.BackgroundImageLayout = ImageLayout.Zoom;
        }


        private void UC_ChatListItem_Click(object sender, EventArgs e)
        {
        }

        private void labelContactName_Click(object sender, EventArgs e)
        {
            uc_Chat.Open_Chat_Room(this.Name1);
        }
    }
}

