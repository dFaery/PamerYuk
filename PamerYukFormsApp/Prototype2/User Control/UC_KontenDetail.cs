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

        public UC_KontenDetail(UC_KontenSaya uc, Konten konten)
        {
            this.uc = uc;
            this.selectedKonten = konten;
            InitializeComponent();
        }

        public UC_KontenDetail(UC_ProfilTeman uc, int konten_id)
        {
            this.uC_ProfilTeman = uc;
            this.selectedKonten = MainForm.service.Lihat_Konten(konten_id);
            InitializeComponent();
        }

        private void UC_KontenDetail_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.MaximumSize = new Size(300, 300);
            axWindowsMediaPlayer1.Size = new Size(300, 300);
            if (this.selectedKonten.Foto != "null")
            {
                if (File.Exists(this.selectedKonten.Foto))
                {
                    Image image = new Bitmap(File.OpenRead(this.selectedKonten.Foto));
                    pictureBoxKonten.BackgroundImage = image;
                    pictureBoxKonten.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else
                {
                    //Isi File Image
                }
            }
            else if (this.selectedKonten.Video != "null")
            {

                axWindowsMediaPlayer1.stretchToFit = true;
                axWindowsMediaPlayer1.URL = this.selectedKonten.Video;
                axWindowsMediaPlayer1.Ctlenabled = true;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.MaximumSize = new Size(300, 300);
                axWindowsMediaPlayer1.Size = new Size(300, 300);
                axWindowsMediaPlayer1.stretchToFit = true;
                axWindowsMediaPlayer1.Visible = true;
                var location = pictureBoxKonten.Location;
                axWindowsMediaPlayer1.Location = location;
                pictureBoxKonten.Visible = false;
            }
            if(this.selectedKonten.Tag.Count > 0)
            {
                comboBoxTag.DataSource = this.selectedKonten.Tag;
                comboBoxTag.SelectedIndex = -1;
                comboBoxTag.Text = "Tag";
            }
            labelLikeQuantity.Text = this.selectedKonten.Like.ToString();
            listBoxCaption.Items.Clear();
            listBoxCaption.Items.Add(this.selectedKonten.Caption);
            if(this.selectedKonten.Comment.Count >0)
            {
                listBoxKomentar.DataSource = this.selectedKonten.Comment;
            }
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
