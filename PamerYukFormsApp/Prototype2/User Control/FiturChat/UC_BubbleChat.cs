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
    public partial class UC_BubbleChat : UserControl
    {
        UC_ChatNew uc_chatNew;
        Chat chat;
        public UC_BubbleChat(UC_ChatNew bubbleChat, Chat chat)
        {
            InitializeComponent();
            this.uc_chatNew = bubbleChat;
            this.chat = chat;
        }

        private void UC_BubbleChat_Load(object sender, EventArgs e)
        {

        }
    }
}
