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
    public partial class FormShareKonten : Form
    {
        private int selectedKonten_Id = 0;
        public FormShareKonten(int kid)
        {
            InitializeComponent();
            this.selectedKonten_Id = kid;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kirim Konten ke username itu melalui chat (konten id jadi isi pesanya, tipe pesannya jadi konten
            
            if (e.ColumnIndex == dataGridView1.Columns["buttonKirimKonten"].Index)
            {
                string username = dataGridView1.CurrentRow.Cells["username"].Value.ToString();
                Chat newChat = new Chat(this.selectedKonten_Id.ToString(), MainForm.service.Current_user.Username, username, "Konten");
                MainForm.service.Kirim_Chat(newChat);
            }
        }

        private void FormShareKonten_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MainForm.service.ListTeman;
            if(dataGridView1.Columns.Count ==3)
            {
                //Tambah Button
                DataGridViewButtonColumn buttonKirimKonten = new DataGridViewButtonColumn();
                buttonKirimKonten.Text = "Kirim Konten";
                buttonKirimKonten.HeaderText = "Aksi";
                buttonKirimKonten.UseColumnTextForButtonValue = true;
                buttonKirimKonten.Name = "buttonKirimKonten";
                dataGridView1.Columns.Add(buttonKirimKonten);
            }
        }
    }
}
