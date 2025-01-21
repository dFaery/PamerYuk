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
        UC_ChatNew bubbleChat;
        public UC_BubbleChat(UC_ChatNew bubbleChat)
        {
            InitializeComponent();
            this.bubbleChat = bubbleChat;
        }
    }
}
