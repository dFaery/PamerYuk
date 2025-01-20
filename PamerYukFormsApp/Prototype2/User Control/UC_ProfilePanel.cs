using PamerYukLibrary;
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
    public partial class UC_ProfilePanel : UserControl
    {
        UC_ProfileNew uc;
        MainForm mainForm;
        public UC_ProfilePanel(UC_ProfileNew uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_ProfilePanel_Load(object sender, EventArgs e)
        {
            DisplayOnLoad();
        }

        private void buttonTambahKisahHidup_Click(object sender, EventArgs e)
        {
            uc.flowLayoutPanelProfileContent.Controls.Clear();
            UC_TambahKisahHidup uC_TambahKisah = new UC_TambahKisahHidup(this);
            uc.flowLayoutPanelProfileContent.Controls.Remove(this);
            uc.flowLayoutPanelProfileContent.Controls.Add(uC_TambahKisah);
        }

        private void buttonUbahProfile_Click(object sender, EventArgs e)
        {
            uc.flowLayoutPanelProfileContent.Controls.Clear();
            UC_UbahProfile uc_ubahProfile = new UC_UbahProfile(this);
            uc.flowLayoutPanelProfileContent.Controls.Remove(this);
            uc.flowLayoutPanelProfileContent.Controls.Add(uc_ubahProfile);
        }

        #region Method
        private void DisplayOnLoad()
        {
            labelNamaLengkap.TextAlign = ContentAlignment.TopCenter;            

            labelNamaLengkap.Text = MainForm.service.Current_user.NamaLengkap;
            labelTanggalLahir.Text = MainForm.service.Current_user.TglLahir.ToString("d");
            labelUsername.Text = MainForm.service.Current_user.Username;
            labelNoKtp.Text = MainForm.service.Current_user.NoKTP;
            labelEmail.Text = MainForm.service.Current_user.Email;            

            labelKota.Text = MainForm.service.Current_user.Kota.Nama;

            Image profilePictureFotoDiri = new Bitmap(MainForm.service.Current_user.FotoDiri);
            pictureBoxFotoProfile.Image = profilePictureFotoDiri;
            pictureBoxFotoProfile.BackgroundImageLayout = ImageLayout.Zoom;

            Image profilePictureFotoProfil = new Bitmap(MainForm.service.Current_user.FotoProfil);
            panelFotoDiri.BackgroundImage = profilePictureFotoProfil;
            panelFotoDiri.BackgroundImageLayout = ImageLayout.Zoom;

            DisplayListKisahHidup();

            DisplayKontenSaya();
        }

        private void DisplayListKisahHidup()
        {
            foreach (KisahHidup kh in MainForm.service.Current_user.ListKisahHidup)
            {
                string[] buffer = new string[5];
                buffer = kh.ToString().Split('\n');
                foreach (string isiBuffer in buffer)
                {
                    listBoxKisahHidup.Items.Add(isiBuffer);

                }
                listBoxKisahHidup.Items.Add("====================");
            }
        }

        private void DisplayKontenSaya()
        {
            flowLayoutPanelKontenSaya.AutoScroll = true;
            flowLayoutPanelKontenSaya.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelKontenSaya.WrapContents = false;

            //Console.WriteLine("From UC_Chat Current User : "+MainForm.service.Current_user.ToString());

            //menyesuaikan jumlah konten yang sudah diuplaod pengguna
            foreach (Konten kSaya in MainForm.service.Current_user.ListKonten)
            {
                UC_KontenDetail cli = new UC_KontenDetail(this, kSaya);
                this.flowLayoutPanelKontenSaya.Controls.Add(cli);
            }
        }
        
        private void ShowKontenSayaOnClick()
        {
            pictureBoxKontenSaya.Image = Properties.Resources.btnKontenSaya_True;
            pictureBoxTag.Image = Properties.Resources.btnKontenTag_False;
            labelKontenSaya.ForeColor = SystemColors.MenuHighlight;
            labelTag.ForeColor = SystemColors.MenuText;
        }

        private void ShowTagOnClick()
        {
            pictureBoxKontenSaya.Image = Properties.Resources.btnKontenSaya_False;
            pictureBoxTag.Image = Properties.Resources.btnKontenTag_True;
            labelKontenSaya.ForeColor = SystemColors.MenuText;
            labelTag.ForeColor = SystemColors.MenuHighlight;
        }

        private void labelKontenSaya_Click(object sender, EventArgs e)
        {
            ShowKontenSayaOnClick();
        }

        private void labelTag_Click(object sender, EventArgs e)
        {
            ShowTagOnClick();
        }

        private void pictureBoxKontenSaya_Click(object sender, EventArgs e)
        {
            ShowKontenSayaOnClick();
        }

        private void pictureBoxTag_Click(object sender, EventArgs e)
        {
            ShowTagOnClick();
        }



        #endregion

        
    }
}
