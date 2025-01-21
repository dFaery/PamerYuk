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
    public partial class UC_PermintaanPertemanan : UserControl
    {
        UC_HomeNew UC_HomeNew;
        public UC_PermintaanPertemanan(UC_HomeNew uC_HomeNew)
        {
            InitializeComponent();
            UC_HomeNew = uC_HomeNew;
        }
        private void UC_PermintaanPertemanan_Load(object sender, EventArgs e)
        {
            DisplayRequestPertemananMasuk();
        }

        private void labelPertemananMasuk_Click(object sender, EventArgs e)
        {
            flowLayoutPanelRequestPertemanan.Controls.Clear();
            labelPertemananTerkirim.ForeColor = Color.Gray;
            labelPertemananMasuk.ForeColor = SystemColors.MenuHighlight;

            DisplayRequestPertemananMasuk();
        }

        private void labelPertemananTerkirim_Click(object sender, EventArgs e)
        {
            flowLayoutPanelRequestPertemanan.Controls.Clear();
            labelPertemananMasuk.ForeColor = Color.Gray;
            labelPertemananTerkirim.ForeColor = SystemColors.MenuHighlight;

            DisplayKirimUlangRequestPertemanan();
        }
        
        #region Method
        private void DisplayKirimUlangRequestPertemanan()
        {
            List<Teman> listTeman = MainForm.service.Request_Pertemanan(true);

            int c = 0;
            foreach (Teman teman in listTeman)
            {
                string username = teman.Username;
                string tanggalKirim = teman.TglBerteman.ToString("dd MMM yyyy");

                UC_RequestPertemananTerkirim uc_masuk = new UC_RequestPertemananTerkirim(this);

                uc_masuk.Username = username;
                uc_masuk.DateTime = teman.TglBerteman;

                this.flowLayoutPanelRequestPertemanan.Controls.Add(uc_masuk);
                c++;
            }
        }

        private void DisplayRequestPertemananMasuk()
        {
            List<Teman> listTeman = MainForm.service.Request_Pertemanan(false);

            foreach (Teman teman in listTeman)
            {
                string username = teman.Username;
                string tanggalKirim = teman.TglBerteman.ToString("dd MMM yyyy");

                UC_RequestPertemananMasuk uc_masuk = new UC_RequestPertemananMasuk(this);

                uc_masuk.Username = username;
                uc_masuk.DateTime = teman.TglBerteman;

                this.flowLayoutPanelRequestPertemanan.Controls.Add(uc_masuk);
            }
        }
        #endregion

        
    }
}
