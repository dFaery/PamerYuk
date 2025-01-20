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
    public partial class UC_TambahGroup : UserControl
    {
        UC_Chat uc;        
        public UC_TambahGroup(UC_Chat uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_TambahGroup_Load(object sender, EventArgs e)
        {

        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
