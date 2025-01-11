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
        UC_Chat uc_Chat;
        Panel panel;

         string name;        
        private Image image;
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
        public UC_ChatListItem(UC_Chat uc_Chat)
        {
            InitializeComponent();
            this.uc_Chat = uc_Chat;
        }



        private void UC_ChatListItem_Load(object sender, EventArgs e)
        {
            profilePicture.Image = new Bitmap(MainForm.service.Cari_AkunTeman(this.Name1).FotoProfil);
            profilePicture.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public void Testing(int index)
        {
            if (index == 0)
            {
                labelContactName.Text = "Nama1";
            }
            else if (index == 1)
            {
                labelContactName.Text = "Nama2";
            }
        }

        private void UC_ChatListItem_Click(object sender, EventArgs e)
        {
            uc_Chat.penerima = this.Name1;
            uc_Chat.UC_Chat_Load(sender, e);
        }

        private void labelContactName_Click(object sender, EventArgs e)
        {

            uc_Chat.penerima = this.Name1;
            uc_Chat.UC_Chat_Load(sender, e);
        }
    }
}
