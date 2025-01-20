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
    public partial class UC_ProfileNew : UserControl
    {
        MainForm mainForm;
        public UC_ProfileNew(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UC_ProfileNew_Load(object sender, EventArgs e)
        {
            UC_ProfilePanel content = new UC_ProfilePanel(this);

            this.flowLayoutPanelProfileContent.Controls.Add(content);
        }
    }
}
