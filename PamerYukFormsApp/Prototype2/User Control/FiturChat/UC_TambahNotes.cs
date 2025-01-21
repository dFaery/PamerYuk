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
        public UC_TambahNotes(UC_NotesChat uc)
        {
            InitializeComponent();
            this.uc = uc;
        }
    }
}
