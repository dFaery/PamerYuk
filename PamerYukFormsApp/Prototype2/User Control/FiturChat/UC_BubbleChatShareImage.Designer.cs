namespace PamerYukFormsApp.Prototype2.User_Control.FiturChat
{
    partial class UC_BubbleChatShareImage
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnReply = new System.Windows.Forms.PictureBox();
            this.labelSentDate = new System.Windows.Forms.Label();
            this.panelReceiverProfilePicture = new System.Windows.Forms.Panel();
            this.pictureBoxReceiverProfileBorder = new System.Windows.Forms.PictureBox();
            this.panelSenderProfilePicture = new System.Windows.Forms.Panel();
            this.pictureBoxSenderProfileBorder = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReply)).BeginInit();
            this.panelReceiverProfilePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceiverProfileBorder)).BeginInit();
            this.panelSenderProfilePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderProfileBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Controls.Add(this.pictureBoxPhoto);
            this.panelContainer.Controls.Add(this.btnReply);
            this.panelContainer.Controls.Add(this.labelSentDate);
            this.panelContainer.Location = new System.Drawing.Point(144, 33);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(555, 325);
            this.panelContainer.TabIndex = 6;
            // 
            // btnReply
            // 
            this.btnReply.BackColor = System.Drawing.Color.Transparent;
            this.btnReply.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.btnReply.Image = global::PamerYukFormsApp.Properties.Resources.btnReplyChat;
            this.btnReply.Location = new System.Drawing.Point(509, 278);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(25, 25);
            this.btnReply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReply.TabIndex = 2;
            this.btnReply.TabStop = false;
            // 
            // labelSentDate
            // 
            this.labelSentDate.BackColor = System.Drawing.Color.Transparent;
            this.labelSentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelSentDate.Location = new System.Drawing.Point(365, 278);
            this.labelSentDate.Name = "labelSentDate";
            this.labelSentDate.Size = new System.Drawing.Size(138, 23);
            this.labelSentDate.TabIndex = 1;
            this.labelSentDate.Text = "Send Date";
            this.labelSentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelReceiverProfilePicture
            // 
            this.panelReceiverProfilePicture.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.panelReceiverProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelReceiverProfilePicture.Controls.Add(this.pictureBoxReceiverProfileBorder);
            this.panelReceiverProfilePicture.Location = new System.Drawing.Point(705, 33);
            this.panelReceiverProfilePicture.Name = "panelReceiverProfilePicture";
            this.panelReceiverProfilePicture.Size = new System.Drawing.Size(100, 100);
            this.panelReceiverProfilePicture.TabIndex = 5;
            // 
            // pictureBoxReceiverProfileBorder
            // 
            this.pictureBoxReceiverProfileBorder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxReceiverProfileBorder.Image = global::PamerYukFormsApp.Properties.Resources.Asset_ProfileBorder;
            this.pictureBoxReceiverProfileBorder.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxReceiverProfileBorder.Name = "pictureBoxReceiverProfileBorder";
            this.pictureBoxReceiverProfileBorder.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxReceiverProfileBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReceiverProfileBorder.TabIndex = 0;
            this.pictureBoxReceiverProfileBorder.TabStop = false;
            // 
            // panelSenderProfilePicture
            // 
            this.panelSenderProfilePicture.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.panelSenderProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelSenderProfilePicture.Controls.Add(this.pictureBoxSenderProfileBorder);
            this.panelSenderProfilePicture.Location = new System.Drawing.Point(38, 33);
            this.panelSenderProfilePicture.Name = "panelSenderProfilePicture";
            this.panelSenderProfilePicture.Size = new System.Drawing.Size(100, 100);
            this.panelSenderProfilePicture.TabIndex = 4;
            // 
            // pictureBoxSenderProfileBorder
            // 
            this.pictureBoxSenderProfileBorder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSenderProfileBorder.Image = global::PamerYukFormsApp.Properties.Resources.Asset_ProfileBorder;
            this.pictureBoxSenderProfileBorder.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSenderProfileBorder.Name = "pictureBoxSenderProfileBorder";
            this.pictureBoxSenderProfileBorder.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxSenderProfileBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSenderProfileBorder.TabIndex = 0;
            this.pictureBoxSenderProfileBorder.TabStop = false;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(19, 20);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(515, 242);
            this.pictureBoxPhoto.TabIndex = 3;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // UC_BubbleChatShareImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelReceiverProfilePicture);
            this.Controls.Add(this.panelSenderProfilePicture);
            this.Name = "UC_BubbleChatShareImage";
            this.Size = new System.Drawing.Size(836, 500);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReply)).EndInit();
            this.panelReceiverProfilePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceiverProfileBorder)).EndInit();
            this.panelSenderProfilePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderProfileBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox btnReply;
        private System.Windows.Forms.Label labelSentDate;
        private System.Windows.Forms.Panel panelReceiverProfilePicture;
        private System.Windows.Forms.PictureBox pictureBoxReceiverProfileBorder;
        private System.Windows.Forms.Panel panelSenderProfilePicture;
        private System.Windows.Forms.PictureBox pictureBoxSenderProfileBorder;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
    }
}
