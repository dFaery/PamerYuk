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
    public partial class UC_NotesPanel : UserControl
    {
        UC_NotesChat uc_notesChat;
        public UC_NotesPanel(UC_NotesChat uc_notesChat)
        {
            InitializeComponent();
            this.uc_notesChat = uc_notesChat;
        }
    }
}
