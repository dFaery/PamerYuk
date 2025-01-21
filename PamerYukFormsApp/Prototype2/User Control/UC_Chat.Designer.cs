namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_Chat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelContactName = new System.Windows.Forms.Label();
            this.panelContactHeader = new System.Windows.Forms.Panel();
            this.numericUpDownCariChat = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerChatDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxCariChat = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelChat = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.panelSendMessage = new System.Windows.Forms.Panel();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.panelHeaderChat = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKirim = new System.Windows.Forms.PictureBox();
            this.btnCariChat = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.btnCloseChat = new System.Windows.Forms.PictureBox();
            this.buttonNewGroup = new System.Windows.Forms.PictureBox();
            this.btnShareImage = new System.Windows.Forms.PictureBox();
            this.panelContactHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCariChat)).BeginInit();
            this.panelSendMessage.SuspendLayout();
            this.panelHeaderChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCariChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNewGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShareImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactName.Location = new System.Drawing.Point(127, 29);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(165, 29);
            this.labelContactName.TabIndex = 4;
            this.labelContactName.Text = "Contact Name";
            // 
            // panelContactHeader
            // 
            this.panelContactHeader.Controls.Add(this.btnCariChat);
            this.panelContactHeader.Controls.Add(this.numericUpDownCariChat);
            this.panelContactHeader.Controls.Add(this.dateTimePickerChatDate);
            this.panelContactHeader.Controls.Add(this.textBoxCariChat);
            this.panelContactHeader.Controls.Add(this.labelContactName);
            this.panelContactHeader.Controls.Add(this.pictureBoxProfile);
            this.panelContactHeader.Controls.Add(this.btnCloseChat);
            this.panelContactHeader.Location = new System.Drawing.Point(442, 0);
            this.panelContactHeader.Name = "panelContactHeader";
            this.panelContactHeader.Size = new System.Drawing.Size(836, 89);
            this.panelContactHeader.TabIndex = 7;
            this.panelContactHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContactHeader_Paint);
            // 
            // numericUpDownCariChat
            // 
            this.numericUpDownCariChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownCariChat.Location = new System.Drawing.Point(706, 25);
            this.numericUpDownCariChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownCariChat.Name = "numericUpDownCariChat";
            this.numericUpDownCariChat.Size = new System.Drawing.Size(49, 39);
            this.numericUpDownCariChat.TabIndex = 15;
            this.numericUpDownCariChat.ValueChanged += new System.EventHandler(this.numericUpDownCariChat_ValueChanged);
            // 
            // dateTimePickerChatDate
            // 
            this.dateTimePickerChatDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerChatDate.Location = new System.Drawing.Point(367, 29);
            this.dateTimePickerChatDate.Name = "dateTimePickerChatDate";
            this.dateTimePickerChatDate.Size = new System.Drawing.Size(135, 30);
            this.dateTimePickerChatDate.TabIndex = 17;
            this.dateTimePickerChatDate.ValueChanged += new System.EventHandler(this.dateTimePickerChatDate_ValueChanged);
            // 
            // textBoxCariChat
            // 
            this.textBoxCariChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCariChat.Location = new System.Drawing.Point(519, 29);
            this.textBoxCariChat.Name = "textBoxCariChat";
            this.textBoxCariChat.Size = new System.Drawing.Size(172, 30);
            this.textBoxCariChat.TabIndex = 16;
            // 
            // flowLayoutPanelChat
            // 
            this.flowLayoutPanelChat.AutoScroll = true;
            this.flowLayoutPanelChat.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanelChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelChat.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            this.flowLayoutPanelChat.Size = new System.Drawing.Size(442, 596);
            this.flowLayoutPanelChat.TabIndex = 6;
            this.flowLayoutPanelChat.WrapContents = false;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.Location = new System.Drawing.Point(100, 20);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(628, 44);
            this.textBoxMessage.TabIndex = 7;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // panelSendMessage
            // 
            this.panelSendMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSendMessage.Controls.Add(this.btnShareImage);
            this.panelSendMessage.Controls.Add(this.btnKirim);
            this.panelSendMessage.Controls.Add(this.textBoxMessage);
            this.panelSendMessage.Location = new System.Drawing.Point(442, 587);
            this.panelSendMessage.Name = "panelSendMessage";
            this.panelSendMessage.Size = new System.Drawing.Size(836, 191);
            this.panelSendMessage.TabIndex = 9;
            // 
            // listBoxChat
            // 
            this.listBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 29;
            this.listBoxChat.Location = new System.Drawing.Point(442, 117);
            this.listBoxChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(819, 410);
            this.listBoxChat.TabIndex = 10;
            // 
            // panelHeaderChat
            // 
            this.panelHeaderChat.BackColor = System.Drawing.Color.AliceBlue;
            this.panelHeaderChat.Controls.Add(this.label1);
            this.panelHeaderChat.Controls.Add(this.buttonNewGroup);
            this.panelHeaderChat.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderChat.Name = "panelHeaderChat";
            this.panelHeaderChat.Size = new System.Drawing.Size(442, 89);
            this.panelHeaderChat.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "Chats";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnKirim
            // 
            this.btnKirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKirim.Image = global::PamerYukFormsApp.Properties.Resources.SendMessage;
            this.btnKirim.Location = new System.Drawing.Point(758, 18);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(50, 50);
            this.btnKirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnKirim.TabIndex = 9;
            this.btnKirim.TabStop = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // btnCariChat
            // 
            this.btnCariChat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCariChat.Image = global::PamerYukFormsApp.Properties.Resources.Search_button;
            this.btnCariChat.Location = new System.Drawing.Point(768, 24);
            this.btnCariChat.Name = "btnCariChat";
            this.btnCariChat.Size = new System.Drawing.Size(40, 40);
            this.btnCariChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCariChat.TabIndex = 10;
            this.btnCariChat.TabStop = false;
            this.btnCariChat.Click += new System.EventHandler(this.pictureBoxCari_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.pictureBoxProfile.Location = new System.Drawing.Point(20, 5);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            // 
            // btnCloseChat
            // 
            this.btnCloseChat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseChat.Image = global::PamerYukFormsApp.Properties.Resources.Close_Button;
            this.btnCloseChat.Location = new System.Drawing.Point(768, 25);
            this.btnCloseChat.Name = "btnCloseChat";
            this.btnCloseChat.Size = new System.Drawing.Size(35, 35);
            this.btnCloseChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseChat.TabIndex = 18;
            this.btnCloseChat.TabStop = false;
            this.btnCloseChat.Click += new System.EventHandler(this.btnCloseChat_Click);
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewGroup.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewGroup.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.NewGroupBtn;
            this.buttonNewGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNewGroup.Location = new System.Drawing.Point(372, 10);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(54, 65);
            this.buttonNewGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonNewGroup.TabIndex = 60;
            this.buttonNewGroup.TabStop = false;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click);
            // 
            // btnShareImage
            // 
            this.btnShareImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShareImage.Image = global::PamerYukFormsApp.Properties.Resources.ShareImageInChat;
            this.btnShareImage.Location = new System.Drawing.Point(23, 15);
            this.btnShareImage.Name = "btnShareImage";
            this.btnShareImage.Size = new System.Drawing.Size(50, 50);
            this.btnShareImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShareImage.TabIndex = 10;
            this.btnShareImage.TabStop = false;
            // 
            // UC_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.panelSendMessage);
            this.Controls.Add(this.flowLayoutPanelChat);
            this.Controls.Add(this.panelContactHeader);
            this.Controls.Add(this.panelHeaderChat);
            this.Name = "UC_Chat";
            this.Size = new System.Drawing.Size(1278, 778);
            this.Load += new System.EventHandler(this.UC_Chat_Load);
            this.panelContactHeader.ResumeLayout(false);
            this.panelContactHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCariChat)).EndInit();
            this.panelSendMessage.ResumeLayout(false);
            this.panelSendMessage.PerformLayout();
            this.panelHeaderChat.ResumeLayout(false);
            this.panelHeaderChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCariChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNewGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShareImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.Panel panelContactHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChat;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Panel panelSendMessage;
        private System.Windows.Forms.PictureBox btnKirim;
        private System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.PictureBox btnCariChat;
        private System.Windows.Forms.NumericUpDown numericUpDownCariChat;
        private System.Windows.Forms.DateTimePicker dateTimePickerChatDate;
        private System.Windows.Forms.TextBox textBoxCariChat;
        private System.Windows.Forms.PictureBox btnCloseChat;
        private System.Windows.Forms.PictureBox buttonNewGroup;
        private System.Windows.Forms.Panel panelHeaderChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnShareImage;
    }
}
