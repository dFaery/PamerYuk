using PamerYukFormsApp.Prototype2.User_Control.FiturChat;
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
    public partial class UC_TambahBroadCast : UserControl
    {
        UC_ChatNew uc;
        public UC_TambahBroadCast(UC_ChatNew uc)
        {
            InitializeComponent();
            this.uc = uc;
            
        }
    }
}
