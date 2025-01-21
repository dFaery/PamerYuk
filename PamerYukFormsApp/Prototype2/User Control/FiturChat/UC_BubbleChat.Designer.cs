namespace PamerYukFormsApp.Prototype2.User_Control.FiturChat
{
    partial class UC_BubbleChat
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
            this.panelBubbleChat = new System.Windows.Forms.Panel();
            this.panelReceiverProfilePicture = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSenderProfilePicture = new System.Windows.Forms.Panel();
            this.pictureBoxProfileBorder = new System.Windows.Forms.PictureBox();
            this.panelReceiverProfilePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSenderProfilePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBubbleChat
            // 
            this.panelBubbleChat.BackColor = System.Drawing.Color.Transparent;
            this.panelBubbleChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBubbleChat.Location = new System.Drawing.Point(157, 27);
            this.panelBubbleChat.Name = "panelBubbleChat";
            this.panelBubbleChat.Size = new System.Drawing.Size(524, 100);
            this.panelBubbleChat.TabIndex = 3;
            // 
            // panelReceiverProfilePicture
            // 
            this.panelReceiverProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelReceiverProfilePicture.Controls.Add(this.pictureBox1);
            this.panelReceiverProfilePicture.Location = new System.Drawing.Point(698, 27);
            this.panelReceiverProfilePicture.Name = "panelReceiverProfilePicture";
            this.panelReceiverProfilePicture.Size = new System.Drawing.Size(100, 100);
            this.panelReceiverProfilePicture.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelSenderProfilePicture
            // 
            this.panelSenderProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelSenderProfilePicture.Controls.Add(this.pictureBoxProfileBorder);
            this.panelSenderProfilePicture.Location = new System.Drawing.Point(31, 27);
            this.panelSenderProfilePicture.Name = "panelSenderProfilePicture";
            this.panelSenderProfilePicture.Size = new System.Drawing.Size(100, 100);
            this.panelSenderProfilePicture.TabIndex = 1;
            // 
            // pictureBoxProfileBorder
            // 
            this.pictureBoxProfileBorder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfileBorder.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProfileBorder.Name = "pictureBoxProfileBorder";
            this.pictureBoxProfileBorder.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxProfileBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfileBorder.TabIndex = 0;
            this.pictureBoxProfileBorder.TabStop = false;
            // 
            // UC_BubbleChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelBubbleChat);
            this.Controls.Add(this.panelReceiverProfilePicture);
            this.Controls.Add(this.panelSenderProfilePicture);
            this.Name = "UC_BubbleChat";
            this.Size = new System.Drawing.Size(836, 163);
            this.panelReceiverProfilePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSenderProfilePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileBorder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfileBorder;
        private System.Windows.Forms.Panel panelSenderProfilePicture;
        private System.Windows.Forms.Panel panelReceiverProfilePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBubbleChat;
    }
}
