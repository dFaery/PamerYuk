﻿namespace PamerYukFormsApp.Prototype2.User_Control.FiturChat
{
    partial class UC_ChatNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeaderChat = new System.Windows.Forms.Panel();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.buttonNewGroup = new System.Windows.Forms.PictureBox();
            this.btnBroadCast = new System.Windows.Forms.PictureBox();
            this.numericUpDownCariChat = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerChatDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxCariChat = new System.Windows.Forms.TextBox();
            this.panelContactHeader = new System.Windows.Forms.Panel();
            this.btnCariChat = new System.Windows.Forms.PictureBox();
            this.labelContactName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.btnCloseChat = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelChat = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelChatHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.PictureBox();
            this.btnShareImage = new System.Windows.Forms.PictureBox();
            this.labelReply = new System.Windows.Forms.Label();
            this.panelHeaderChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNewGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBroadCast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCariChat)).BeginInit();
            this.panelContactHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCariChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShareImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 51);
            this.label1.TabIndex = 61;
            this.label1.Text = "Chats";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHeaderChat
            // 
            this.panelHeaderChat.BackColor = System.Drawing.Color.AliceBlue;
            this.panelHeaderChat.Controls.Add(this.pictureBoxGroup);
            this.panelHeaderChat.Controls.Add(this.label1);
            this.panelHeaderChat.Controls.Add(this.buttonNewGroup);
            this.panelHeaderChat.Controls.Add(this.btnBroadCast);
            this.panelHeaderChat.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeaderChat.Name = "panelHeaderChat";
            this.panelHeaderChat.Size = new System.Drawing.Size(590, 111);
            this.panelHeaderChat.TabIndex = 66;
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxGroup.Image = global::PamerYukFormsApp.Properties.Resources.DefaultGroupIcon;
            this.pictureBoxGroup.Location = new System.Drawing.Point(312, 19);
            this.pictureBoxGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(74, 63);
            this.pictureBoxGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGroup.TabIndex = 62;
            this.pictureBoxGroup.TabStop = false;
            this.pictureBoxGroup.Click += new System.EventHandler(this.pictureBoxGroup_Click);
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewGroup.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewGroup.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.NewGroupBtn;
            this.buttonNewGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNewGroup.Location = new System.Drawing.Point(496, 13);
            this.buttonNewGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(72, 81);
            this.buttonNewGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonNewGroup.TabIndex = 60;
            this.buttonNewGroup.TabStop = false;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click);
            // 
            // btnBroadCast
            // 
            this.btnBroadCast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBroadCast.Image = global::PamerYukFormsApp.Properties.Resources.btnBroadCast;
            this.btnBroadCast.Location = new System.Drawing.Point(401, 19);
            this.btnBroadCast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBroadCast.Name = "btnBroadCast";
            this.btnBroadCast.Size = new System.Drawing.Size(74, 63);
            this.btnBroadCast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBroadCast.TabIndex = 11;
            this.btnBroadCast.TabStop = false;
            this.btnBroadCast.Click += new System.EventHandler(this.btnBroadCast_Click);
            // 
            // numericUpDownCariChat
            // 
            this.numericUpDownCariChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownCariChat.Location = new System.Drawing.Point(941, 31);
            this.numericUpDownCariChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownCariChat.Name = "numericUpDownCariChat";
            this.numericUpDownCariChat.Size = new System.Drawing.Size(65, 50);
            this.numericUpDownCariChat.TabIndex = 15;
            this.numericUpDownCariChat.ValueChanged += new System.EventHandler(this.numericUpDownCariChat_ValueChanged);
            // 
            // dateTimePickerChatDate
            // 
            this.dateTimePickerChatDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerChatDate.Location = new System.Drawing.Point(489, 36);
            this.dateTimePickerChatDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerChatDate.Name = "dateTimePickerChatDate";
            this.dateTimePickerChatDate.Size = new System.Drawing.Size(179, 38);
            this.dateTimePickerChatDate.TabIndex = 17;
            this.dateTimePickerChatDate.ValueChanged += new System.EventHandler(this.dateTimePickerChatDate_ValueChanged);
            // 
            // textBoxCariChat
            // 
            this.textBoxCariChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCariChat.Location = new System.Drawing.Point(692, 36);
            this.textBoxCariChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCariChat.Name = "textBoxCariChat";
            this.textBoxCariChat.Size = new System.Drawing.Size(228, 38);
            this.textBoxCariChat.TabIndex = 16;
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
            this.panelContactHeader.Location = new System.Drawing.Point(590, 0);
            this.panelContactHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContactHeader.Name = "panelContactHeader";
            this.panelContactHeader.Size = new System.Drawing.Size(1114, 111);
            this.panelContactHeader.TabIndex = 63;
            this.panelContactHeader.Click += new System.EventHandler(this.panelContactHeader_Click);
            // 
            // btnCariChat
            // 
            this.btnCariChat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCariChat.Image = global::PamerYukFormsApp.Properties.Resources.Search_button;
            this.btnCariChat.Location = new System.Drawing.Point(1024, 30);
            this.btnCariChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCariChat.Name = "btnCariChat";
            this.btnCariChat.Size = new System.Drawing.Size(53, 50);
            this.btnCariChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCariChat.TabIndex = 10;
            this.btnCariChat.TabStop = false;
            this.btnCariChat.Click += new System.EventHandler(this.btnCariChat_Click);
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactName.Location = new System.Drawing.Point(170, 36);
            this.labelContactName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(223, 37);
            this.labelContactName.TabIndex = 4;
            this.labelContactName.Text = "Contact Name";
            this.labelContactName.Click += new System.EventHandler(this.labelContactName_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.pictureBoxProfile.Location = new System.Drawing.Point(27, 6);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 94);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            // 
            // btnCloseChat
            // 
            this.btnCloseChat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseChat.Image = global::PamerYukFormsApp.Properties.Resources.Close_Button;
            this.btnCloseChat.Location = new System.Drawing.Point(1024, 31);
            this.btnCloseChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseChat.Name = "btnCloseChat";
            this.btnCloseChat.Size = new System.Drawing.Size(46, 44);
            this.btnCloseChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseChat.TabIndex = 18;
            this.btnCloseChat.TabStop = false;
            // 
            // flowLayoutPanelChat
            // 
            this.flowLayoutPanelChat.AutoScroll = true;
            this.flowLayoutPanelChat.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanelChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelChat.Location = new System.Drawing.Point(0, 109);
            this.flowLayoutPanelChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            this.flowLayoutPanelChat.Size = new System.Drawing.Size(590, 838);
            this.flowLayoutPanelChat.TabIndex = 62;
            this.flowLayoutPanelChat.WrapContents = false;
            // 
            // flowLayoutPanelChatHistory
            // 
            this.flowLayoutPanelChatHistory.AutoScroll = true;
            this.flowLayoutPanelChatHistory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelChatHistory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelChatHistory.Location = new System.Drawing.Point(616, 114);
            this.flowLayoutPanelChatHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelChatHistory.Name = "flowLayoutPanelChatHistory";
            this.flowLayoutPanelChatHistory.Size = new System.Drawing.Size(1050, 579);
            this.flowLayoutPanelChatHistory.TabIndex = 67;
            this.flowLayoutPanelChatHistory.WrapContents = false;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.Location = new System.Drawing.Point(699, 759);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(876, 56);
            this.textBoxMessage.TabIndex = 7;
            // 
            // btnKirim
            // 
            this.btnKirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKirim.Image = global::PamerYukFormsApp.Properties.Resources.SendMessage;
            this.btnKirim.Location = new System.Drawing.Point(1582, 738);
            this.btnKirim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(67, 63);
            this.btnKirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnKirim.TabIndex = 9;
            this.btnKirim.TabStop = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // btnShareImage
            // 
            this.btnShareImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShareImage.Image = global::PamerYukFormsApp.Properties.Resources.ShareImageInChat;
            this.btnShareImage.Location = new System.Drawing.Point(616, 738);
            this.btnShareImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShareImage.Name = "btnShareImage";
            this.btnShareImage.Size = new System.Drawing.Size(67, 63);
            this.btnShareImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShareImage.TabIndex = 10;
            this.btnShareImage.TabStop = false;
            this.btnShareImage.Click += new System.EventHandler(this.btnShareImage_Click);
            // 
            // labelReply
            // 
            this.labelReply.AutoSize = true;
            this.labelReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReply.Location = new System.Drawing.Point(610, 697);
            this.labelReply.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReply.Name = "labelReply";
            this.labelReply.Size = new System.Drawing.Size(163, 37);
            this.labelReply.TabIndex = 19;
            this.labelReply.Text = "labelReply";
            // 
            // UC_ChatNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labelReply);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.flowLayoutPanelChatHistory);
            this.Controls.Add(this.btnShareImage);
            this.Controls.Add(this.panelHeaderChat);
            this.Controls.Add(this.panelContactHeader);
            this.Controls.Add(this.flowLayoutPanelChat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_ChatNew";
            this.Size = new System.Drawing.Size(1704, 973);
            this.Load += new System.EventHandler(this.UC_ChatNew_Load);
            this.panelHeaderChat.ResumeLayout(false);
            this.panelHeaderChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNewGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBroadCast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCariChat)).EndInit();
            this.panelContactHeader.ResumeLayout(false);
            this.panelContactHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCariChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShareImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonNewGroup;
        private System.Windows.Forms.PictureBox btnCariChat;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCloseChat;
        private System.Windows.Forms.Panel panelHeaderChat;
        private System.Windows.Forms.NumericUpDown numericUpDownCariChat;
        private System.Windows.Forms.DateTimePicker dateTimePickerChatDate;
        private System.Windows.Forms.TextBox textBoxCariChat;
        private System.Windows.Forms.Panel panelContactHeader;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChatHistory;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.PictureBox btnKirim;
        private System.Windows.Forms.PictureBox btnShareImage;
        private System.Windows.Forms.PictureBox btnBroadCast;
        private System.Windows.Forms.Label labelReply;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
    }
}
