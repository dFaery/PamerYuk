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
        public FormShareKonten()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kirim Konten ke username itu melalui chat (konten id jadi isi pesanya, tipe pesannya jadi konten
        }

        private void FormShareKonten_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MainForm.service.ListTeman;
            if(dataGridView1.Columns.Count ==3)
            {
                //Tambah Button
            }
        }
    }
}
