using AxWMPLib;
using PamerYukFormsApp.Prototype;
using PamerYukLibrary;
using PamerYukLibrary.DAO;
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
    public partial class UC_TambahKonten : UserControl
    {
        UC_DaftarKonten uc;
        Konten buffer;
        OpenFileDialog fileDialog;
        //OpenFileDialog openFileDialogVideo;

        public UC_TambahKonten(UC_DaftarKonten uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_TambahKonten_Load(object sender, EventArgs e)
        {
            try
            {
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if(Path.GetExtension(fileDialog.FileName) == ".jpg")
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

        private void dataGridViewTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.ColumnIndex == dataGridViewTeman.Columns["buttonTambahTag"].Index)
                {
                    string username = dataGridViewTeman.CurrentRow.Cells["username"].Value.ToString();
                    buffer.Tag.Add(MainForm.service.Tambah_Tag(username));
                }
        }

        private void buttonTambahKonten_Click(object sender, EventArgs e)
        {
            buffer.Caption = textBoxCaption.Text;
            MainForm.service.Tambah_Konten(buffer);
        }

        #region METHOD
        #endregion
    }
}