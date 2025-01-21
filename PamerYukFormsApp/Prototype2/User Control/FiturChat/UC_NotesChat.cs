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
    public partial class UC_NotesChat : UserControl
    {
        UC_ChatNew uc;
        public UC_NotesChat(UC_ChatNew uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void buttonNewNote_Click(object sender, EventArgs e)
        {          
            this.panel.Controls.Clear();
            UC_TambahNotes uc_tambahNotes = new UC_TambahNotes(this);
            this.panel.Controls.Remove(this);
            this.panel.Controls.Add(uc_tambahNotes);
        }

        private void UC_NotesChat_Load(object sender, EventArgs e)
        {
            UC_NotesPanel notes = new UC_NotesPanel(this);

            this.flowLayoutPanelNotes.Controls.Add(notes);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
