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
    public partial class UC_BubbleChatShareKonten : UserControl
    {
        UC_ChatNew uc;
        Chat chat;
        public UC_BubbleChatShareKonten(UC_ChatNew uc, Chat chat)
        {
            InitializeComponent();
            this.uc = uc;
            this.chat = chat;
        }

        private void UC_BubbleChatShareKonten_Load(object sender, EventArgs e)
        {

        }
    }
}
