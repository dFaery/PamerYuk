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
    public partial class UC_TambahNotes : UserControl
    {
        UC_NotesChat uc;
        string penerima;
        public UC_TambahNotes(UC_NotesChat uc, string penerima)
        {
            InitializeComponent();
            this.uc = uc;
            this.penerima = penerima;
        }

        private void UC_TambahNotes_Load(object sender, EventArgs e)
        {
            string notes = textBoxNotes.Text;
            //SERVICE KE DAO CATETAN
        }
    }
}
