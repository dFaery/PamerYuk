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
    public partial class FormKirimGambar : Form
    {
        private string penerima;
        private OpenFileDialog foto;
        public FormKirimGambar(string penerima, OpenFileDialog fd)
        {
            InitializeComponent();
            this.penerima = penerima;
            this.foto = fd;
        }

        private void FormKirimGambar_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImage = new Bitmap(this.foto.FileName);
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
               
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            Chat newChat = new Chat(this.foto.FileName, MainForm.service.Current_user.Username, penerima, "Media");
            MainForm.service.Kirim_Chat(newChat);
            this.Close();
        }
    }
}
