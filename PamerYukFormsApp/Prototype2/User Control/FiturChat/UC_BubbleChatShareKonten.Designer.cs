namespace PamerYukFormsApp.Prototype2.User_Control.FiturChat
{
    partial class UC_BubbleChatShareKonten
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnReply = new System.Windows.Forms.PictureBox();
            this.labelSentDate = new System.Windows.Forms.Label();
            this.panelReceiverProfilePicture = new System.Windows.Forms.Panel();
            this.pictureBoxReceiverProfileBorder = new System.Windows.Forms.PictureBox();
            this.panelSenderProfilePicture = new System.Windows.Forms.Panel();
            this.pictureBoxSenderProfileBorder = new System.Windows.Forms.PictureBox();
            this.pictureBoxContent = new System.Windows.Forms.PictureBox();
            this.buttonLihatKontenDetail = new System.Windows.Forms.Button();
            this.pictureBoxContentOwnerBorder = new System.Windows.Forms.PictureBox();
            this.panelContentOwner = new System.Windows.Forms.Panel();
            this.labelContentOwnerName = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReply)).BeginInit();
            this.panelReceiverProfilePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceiverProfileBorder)).BeginInit();
            this.panelSenderProfilePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderProfileBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContentOwnerBorder)).BeginInit();
            this.panelContentOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Controls.Add(this.labelContentOwnerName);
            this.panelContent.Controls.Add(this.panelContentOwner);
            this.panelContent.Controls.Add(this.buttonLihatKontenDetail);
            this.panelContent.Controls.Add(this.pictureBoxContent);
            this.panelContent.Controls.Add(this.btnReply);
            this.panelContent.Controls.Add(this.labelSentDate);
            this.panelContent.Location = new System.Drawing.Point(141, 38);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(555, 433);
            this.panelContent.TabIndex = 6;
            // 
            // btnReply
            // 
            this.btnReply.BackColor = System.Drawing.Color.Transparent;
            this.btnReply.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.btnReply.Image = global::PamerYukFormsApp.Properties.Resources.btnReplyChat;
            this.btnReply.Location = new System.Drawing.Point(513, 65);
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
            this.labelSentDate.Location = new System.Drawing.Point(369, 65);
            this.labelSentDate.Name = "labelSentDate";
            this.labelSentDate.Size = new System.Drawing.Size(138, 23);
            this.labelSentDate.TabIndex = 1;
            this.labelSentDate.Text = "label2";
            this.labelSentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelReceiverProfilePicture
            // 
            this.panelReceiverProfilePicture.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.panelReceiverProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelReceiverProfilePicture.Controls.Add(this.pictureBoxReceiverProfileBorder);
            this.panelReceiverProfilePicture.Location = new System.Drawing.Point(702, 38);
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
            this.panelSenderProfilePicture.Location = new System.Drawing.Point(35, 38);
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
            // pictureBoxContent
            // 
            this.pictureBoxContent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxContent.Location = new System.Drawing.Point(0, 65);
            this.pictureBoxContent.Name = "pictureBoxContent";
            this.pictureBoxContent.Size = new System.Drawing.Size(555, 368);
            this.pictureBoxContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxContent.TabIndex = 3;
            this.pictureBoxContent.TabStop = false;
            // 
            // buttonLihatKontenDetail
            // 
            this.buttonLihatKontenDetail.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonLihatKontenDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatKontenDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLihatKontenDetail.Location = new System.Drawing.Point(28, 354);
            this.buttonLihatKontenDetail.Name = "buttonLihatKontenDetail";
            this.buttonLihatKontenDetail.Size = new System.Drawing.Size(500, 66);
            this.buttonLihatKontenDetail.TabIndex = 4;
            this.buttonLihatKontenDetail.Text = "Lihat Konten";
            this.buttonLihatKontenDetail.UseVisualStyleBackColor = false;
            // 
            // pictureBoxContentOwnerBorder
            // 
            this.pictureBoxContentOwnerBorder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxContentOwnerBorder.Image = global::PamerYukFormsApp.Properties.Resources.Asset_ProfileBorder;
            this.pictureBoxContentOwnerBorder.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxContentOwnerBorder.Name = "pictureBoxContentOwnerBorder";
            this.pictureBoxContentOwnerBorder.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxContentOwnerBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxContentOwnerBorder.TabIndex = 7;
            this.pictureBoxContentOwnerBorder.TabStop = false;
            // 
            // panelContentOwner
            // 
            this.panelContentOwner.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.panelContentOwner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelContentOwner.Controls.Add(this.pictureBoxContentOwnerBorder);
            this.panelContentOwner.Location = new System.Drawing.Point(3, 9);
            this.panelContentOwner.Name = "panelContentOwner";
            this.panelContentOwner.Size = new System.Drawing.Size(50, 50);
            this.panelContentOwner.TabIndex = 8;
            // 
            // labelContentOwnerName
            // 
            this.labelContentOwnerName.AutoSize = true;
            this.labelContentOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContentOwnerName.Location = new System.Drawing.Point(59, 20);
            this.labelContentOwnerName.Name = "labelContentOwnerName";
            this.labelContentOwnerName.Size = new System.Drawing.Size(145, 25);
            this.labelContentOwnerName.TabIndex = 9;
            this.labelContentOwnerName.Text = "Content_owner";
            // 
            // UC_BubbleChatShareKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelReceiverProfilePicture);
            this.Controls.Add(this.panelSenderProfilePicture);
            this.Name = "UC_BubbleChatShareKonten";
            this.Size = new System.Drawing.Size(836, 500);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReply)).EndInit();
            this.panelReceiverProfilePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceiverProfileBorder)).EndInit();
            this.panelSenderProfilePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderProfileBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContentOwnerBorder)).EndInit();
            this.panelContentOwner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox btnReply;
        private System.Windows.Forms.Label labelSentDate;
        private System.Windows.Forms.Panel panelReceiverProfilePicture;
        private System.Windows.Forms.PictureBox pictureBoxReceiverProfileBorder;
        private System.Windows.Forms.Panel panelSenderProfilePicture;
        private System.Windows.Forms.PictureBox pictureBoxSenderProfileBorder;
        private System.Windows.Forms.PictureBox pictureBoxContent;
        private System.Windows.Forms.Button buttonLihatKontenDetail;
        private System.Windows.Forms.Label labelContentOwnerName;
        private System.Windows.Forms.Panel panelContentOwner;
        private System.Windows.Forms.PictureBox pictureBoxContentOwnerBorder;
    }
}
