using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PamerYukLibrary.Database;
using PamerYukFormsApp.Prototype2.User_Control;
using PamerYukFormsApp.Prototype2.User_Control.FiturChat;

namespace PamerYukFormsApp.Prototype2
{
    public partial class MainForm : Form
    {
        public static Service service = new Service();
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            //biar wkt load, yg lgsg ke load uC_Login
            this.Visible = false;
            try
            {
                KoneksiDatabase connectToDatabase = new KoneksiDatabase(PamerYuk.Default.Server, PamerYuk.Default.Database, PamerYuk.Default.User, PamerYuk.Default.Password);
                MessageBox.Show("Koneksi ke Database Berhasil.\n" + "Terhubung dengan, " + PamerYuk.Default.Server + " : " + PamerYuk.Default.Database);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi ke Database Gagal : \n" + ex.Message);
            }
            this.Visible = true;

            //Menampilkan user control Login di panelUtama
            UC_Login uC_Login = new UC_Login(this);
            panelUtama.Controls.Add(uC_Login);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelUtama.Controls.Clear();
            panelUtama.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            UC_HomeNew uc_home = new UC_HomeNew(this);
            AddUserControl(uc_home);
            ResetNavigationBar();
            this.buttonHome.Image = Properties.Resources.newBtnHome_True;
        }

        private void buttonTambahKonten_Click(object sender, EventArgs e)
        {
            UC_TambahKontenNew uc_tambah = new UC_TambahKontenNew(this);
            AddUserControl(uc_tambah);
            ResetNavigationBar();
            this.buttonTambahKonten.Image = Properties.Resources.newBtnAddContent_True;
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            UC_ChatNew uc_chat = new UC_ChatNew(this);
            AddUserControl(uc_chat);
            ResetNavigationBar();
            this.buttonChat.Image = Properties.Resources.newBtnChat_True;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            UC_ProfileNew uc_profile = new UC_ProfileNew(this);
            AddUserControl(uc_profile);
            ResetNavigationBar();
            this.buttonProfile.Image = Properties.Resources.newBtnProfile_True;
        }

        private void ResetNavigationBar()
        {
            this.buttonHome.Image = Properties.Resources.newBtnHome_False;
            this.buttonChat.Image = Properties.Resources.newBtnChat_False;
            this.buttonTambahKonten.Image = Properties.Resources.newBtnAddContent_False;
            this.buttonProfile.Image = Properties.Resources.newBtnProfile_False;
        }

        private void panelUtama_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}