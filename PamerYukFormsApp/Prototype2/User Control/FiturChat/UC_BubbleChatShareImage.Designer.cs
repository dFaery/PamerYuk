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
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnReply = new System.Windows.Forms.PictureBox();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.pictureBoxTeman = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Controls.Add(this.pictureBoxPhoto);
            this.panelContainer.Controls.Add(this.btnReply);
            this.panelContainer.Controls.Add(this.labelTanggal);
            this.panelContainer.Location = new System.Drawing.Point(250, 60);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(5);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(987, 504);
            this.panelContainer.TabIndex = 6;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(34, 31);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(916, 375);
            this.pictureBoxPhoto.TabIndex = 3;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // btnReply
            // 
            this.btnReply.BackColor = System.Drawing.Color.Transparent;
            this.btnReply.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.btnReply.Image = global::PamerYukFormsApp.Properties.Resources.btnReplyChat;
            this.btnReply.Location = new System.Drawing.Point(905, 431);
            this.btnReply.Margin = new System.Windows.Forms.Padding(5);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(44, 39);
            this.btnReply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReply.TabIndex = 2;
            this.btnReply.TabStop = false;
            // 
            // labelTanggal
            // 
            this.labelTanggal.BackColor = System.Drawing.Color.Transparent;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelTanggal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelTanggal.Location = new System.Drawing.Point(649, 431);
            this.labelTanggal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(245, 36);
            this.labelTanggal.TabIndex = 1;
            this.labelTanggal.Text = "Send Date";
            this.labelTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxTeman
            // 
            this.pictureBoxTeman.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTeman.Image = global::PamerYukFormsApp.Properties.Resources.Asset_ProfileBorder;
            this.pictureBoxTeman.Location = new System.Drawing.Point(50, 60);
            this.pictureBoxTeman.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxTeman.Name = "pictureBoxTeman";
            this.pictureBoxTeman.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxTeman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTeman.TabIndex = 7;
            this.pictureBoxTeman.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUser.Image = global::PamerYukFormsApp.Properties.Resources.Asset_ProfileBorder;
            this.pictureBoxUser.Location = new System.Drawing.Point(1300, 60);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 8;
            this.pictureBoxUser.TabStop = false;
            // 
            // UC_BubbleChatShareImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.pictureBoxTeman);
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_BubbleChatShareImage";
            this.Size = new System.Drawing.Size(1486, 598);
            this.Load += new System.EventHandler(this.UC_BubbleChatShareImage_Load);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox btnReply;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.PictureBox pictureBoxTeman;
        private System.Windows.Forms.PictureBox pictureBoxUser;
    }
}
