using PamerYukFormsApp.Prototype2.User_Control.FiturChat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PamerYukLibrary.Entity;
using PamerYukLibrary;
using System.IO;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_TambahGroup : UserControl
    {
        UC_ChatNew uc;
        private OpenFileDialog fd;
        private Group buffer;
        public UC_TambahGroup(UC_ChatNew uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_TambahGroup_Load(object sender, EventArgs e)
        {
            buffer = new Group();
            buffer.Members.Add(MainForm.service.Current_user);
            buffer.FotoProfil = "null";
            dataGridViewTeman.DataSource = MainForm.service.ListTeman;
            if(dataGridViewTeman.ColumnCount == 3)
            {
                DataGridViewButtonColumn buttonTambahMember = new DataGridViewButtonColumn();
                buttonTambahMember.Text = "Tambah Member";
                buttonTambahMember.HeaderText = "Aksi";
                buttonTambahMember.UseColumnTextForButtonValue = true;
                buttonTambahMember.Name = "buttonTambahMember";
                dataGridViewTeman.Columns.Add(buttonTambahMember);
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBuatGroup_Click(object sender, EventArgs e)
        {
            buffer.Nama = textBoxNamaGroup.Text;
            buffer.TglDibuat = DateTime.Now;
            MainForm.service.Buat_Group(buffer);
        }

        private void dataGridViewTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewTeman.Columns["buttonTambahMember"].Index)
            {
                string username = dataGridViewTeman.CurrentRow.Cells["username"].Value.ToString();
                buffer.Members.Add(MainForm.service.Cari_AkunTeman(username));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fd = new OpenFileDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(fd.FileName) == ".jpg")
                {
                    Image selectedFoto = new Bitmap(fd.FileName);
                    pictureBoxIconGroup.BackgroundImage = selectedFoto;
                    pictureBoxIconGroup.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxIconGroup.Visible = true;
                    buffer.FotoProfil = fd.FileName;
                }
            }
        }
    }
}
