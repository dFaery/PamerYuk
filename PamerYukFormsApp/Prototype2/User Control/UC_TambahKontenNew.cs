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

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_TambahKontenNew : UserControl
    {
        MainForm uc;
        Konten buffer;
        OpenFileDialog fileDialog;
        public UC_TambahKontenNew(MainForm uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(fileDialog.FileName) == ".jpg")
                    {
                        Image selectedFoto = new Bitmap(fileDialog.FileName);
                        pictureBoxKonten.BackgroundImage = selectedFoto;
                        pictureBoxKonten.BackgroundImageLayout = ImageLayout.Zoom;
                        pictureBoxKonten.Visible = true;
                        buffer.Foto = fileDialog.FileName;
                    }
                    else if (Path.GetExtension(fileDialog.FileName) == ".mp4")
                    {
                        videoPlayer.stretchToFit = true;
                        videoPlayer.URL = fileDialog.FileName;
                        videoPlayer.MaximumSize = new Size(300, 300);
                        videoPlayer.Size = new Size(300, 300);
                        videoPlayer.stretchToFit = true;
                        videoPlayer.Ctlenabled = true;
                        videoPlayer.Ctlcontrols.play();
                        videoPlayer.Visible = true;
                        var location = pictureBoxKonten.Location;
                        videoPlayer.Location = location;
                        pictureBoxKonten.Visible = false;
                        buffer.Video = fileDialog.FileName;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_TambahKontenNew_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayOnLoad();

                buffer = new Konten();
                dataGridViewTeman.DataSource = MainForm.service.ListTeman;
                videoPlayer.Visible = false;
                if (dataGridViewTeman.Columns.Count == 3)
                {
                    DataGridViewButtonColumn buttonTambahTag = new DataGridViewButtonColumn();
                    buttonTambahTag.Text = "Tambah Tag";
                    buttonTambahTag.HeaderText = "Aksi";
                    buttonTambahTag.UseColumnTextForButtonValue = true;
                    buttonTambahTag.Name = "buttonTambahTag";
                    dataGridViewTeman.Columns.Add(buttonTambahTag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewTeman.Columns["buttonTambahTag"].Index)
            {
                string username = dataGridViewTeman.CurrentRow.Cells["username"].Value.ToString();
                buffer.Tag.Add(MainForm.service.Tambah_Tag(username));
            }
        }

        private void btnTambahKonten_Click(object sender, EventArgs e)
        {
            buffer.Caption = textBoxCaption.Text;
            MainForm.service.Tambah_Konten(buffer);
            MessageBox.Show("Konten Berhasil di Tambahkan");


            textBoxCaption.Clear();
            pictureBoxKonten.Image = null;
            pictureBoxKonten.Refresh();
        }

        #region Method
        private void DisplayOnLoad()
        {
            labelCurrentUser.Text = MainForm.service.Current_user.ToString();

            Image profilePictureFotoDiri = new Bitmap(MainForm.service.Current_user.FotoDiri);
            pictureBoxProfilePicture.Image = profilePictureFotoDiri;
            pictureBoxProfilePicture.BackgroundImageLayout = ImageLayout.Zoom;
        }
        #endregion
    }
}
