using PamerYukLibrary;
using PamerYukLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_Chat : UserControl
    {
        MainForm mainForm;
        public string pickChat;
        public UC_Chat(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UC_Chat_Load(object sender, EventArgs e)
        {
            /* mainForm.panel1.Show();
             mainForm.panel1.BringToFront();
 */
            flowLayoutPanelChat.AutoScroll = true;
            flowLayoutPanelChat.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelChat.WrapContents = false;

            List<Teman> listTeman = MainForm.service.ListTeman;

            labelContactName.Text = listTeman[0].Username;
            
            Console.WriteLine("Jumlah Teman : " + MainForm.service.ListTeman.Count);
            
            foreach (Teman teman in listTeman)
            {
                string username = teman.Username;

                UC_ChatListItem uc_cl = new UC_ChatListItem(this);

                uc_cl.Name1 = username;
                
                this.flowLayoutPanelChat.Controls.Add(uc_cl);                
            }            
                    
        }

    }
}
