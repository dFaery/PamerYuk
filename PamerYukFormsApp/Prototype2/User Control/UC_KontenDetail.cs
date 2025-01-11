using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_KontenDetail : UserControl
    {
        UC_KontenSaya uc;
        UC_ProfilTeman uC_ProfilTeman;
        private Konten selectedKonten;

        public UC_KontenDetail(UC_KontenSaya uc, Konten kSaya)
        {
            InitializeComponent();
            this.uc = uc;
            selectedKonten = kSaya;
        }

        public UC_KontenDetail(UC_ProfilTeman uc, int konten_id)
        {
            InitializeComponent();
            this.uC_ProfilTeman = uc;
            this.selectedKonten = MainForm.service.Lihat_Konten(konten_id);
        }

        private void UC_KontenDetail_Load(object sender, EventArgs e)
        {
            if (this.selectedKonten.Foto != "null")
            {
                if (File.Exists(this.selectedKonten.Foto))
                {
                    Image image = new Bitmap(File.OpenRead(this.selectedKonten.Foto));
                    pictureBoxKonten.Image = image;
                    pictureBoxKonten.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            if(this.selectedKonten.Tag.Count >0)
            {
                comboBox1.DataSource = this.selectedKonten.Tag;
                comboBox1.SelectedIndex = -1;
                comboBox1.Text = "Tag";
            }
            labelLikeQuantity.Text = this.selectedKonten.Like.ToString();
            listBoxCaption.Items.Clear();
            listBoxCaption.Items.Add(this.selectedKonten.Caption);
            listBoxKomentar.DataSource = selectedKonten.Comment;
            if (!MainForm.service.Check_Like(this.selectedKonten.Id))
            {
                buttonLike.Image = Properties.Resources.Like_true;
                buttonLike.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                buttonLike.Image = Properties.Resources.Like_true;
                buttonLike.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            if (MainForm.service.Check_Like(this.selectedKonten.Id))
            {
                //Unlike                
                this.selectedKonten = MainForm.service.Delete_Like(this.selectedKonten.Id);
            }
            else
            {
                //Like              
                this.selectedKonten = MainForm.service.Tambah_Like(this.selectedKonten.Id);
            }
            UC_KontenDetail_Load(sender, e);
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            string comment = textBoxKomen.Text;
            Komen newKomen = new Komen(comment, DateTime.Now, MainForm.service.Current_user.Username);
            selectedKonten = MainForm.service.Tambah_Komen(newKomen, this.selectedKonten);
            UC_KontenDetail_Load(sender, e);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
