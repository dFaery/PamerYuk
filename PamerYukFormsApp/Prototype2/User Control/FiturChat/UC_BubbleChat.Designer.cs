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
            this.pictureBoxTeman = new System.Windows.Forms.PictureBox();
            this.btnReplyTeman = new System.Windows.Forms.PictureBox();
            this.labelPesan = new System.Windows.Forms.Label();
            this.pictureBoxUIser = new System.Windows.Forms.PictureBox();
            this.labelTanggal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplyTeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUIser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTeman
            // 
            this.pictureBoxTeman.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTeman.Location = new System.Drawing.Point(14, 42);
            this.pictureBoxTeman.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxTeman.Name = "pictureBoxTeman";
            this.pictureBoxTeman.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxTeman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTeman.TabIndex = 0;
            this.pictureBoxTeman.TabStop = false;
            // 
            // btnReplyTeman
            // 
            this.btnReplyTeman.BackColor = System.Drawing.Color.Transparent;
            this.btnReplyTeman.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.btnReplyTeman.Image = global::PamerYukFormsApp.Properties.Resources.btnReplyChat;
            this.btnReplyTeman.Location = new System.Drawing.Point(1230, 219);
            this.btnReplyTeman.Margin = new System.Windows.Forms.Padding(5);
            this.btnReplyTeman.Name = "btnReplyTeman";
            this.btnReplyTeman.Size = new System.Drawing.Size(59, 48);
            this.btnReplyTeman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReplyTeman.TabIndex = 3;
            this.btnReplyTeman.TabStop = false;
            // 
            // labelPesan
            // 
            this.labelPesan.AutoSize = true;
            this.labelPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPesan.Location = new System.Drawing.Point(201, 42);
            this.labelPesan.Name = "labelPesan";
            this.labelPesan.Size = new System.Drawing.Size(254, 54);
            this.labelPesan.TabIndex = 5;
            this.labelPesan.Text = "labelPesan";
            // 
            // pictureBoxUIser
            // 
            this.pictureBoxUIser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUIser.Location = new System.Drawing.Point(1310, 42);
            this.pictureBoxUIser.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxUIser.Name = "pictureBoxUIser";
            this.pictureBoxUIser.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxUIser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUIser.TabIndex = 0;
            this.pictureBoxUIser.TabStop = false;
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelTanggal.Location = new System.Drawing.Point(187, 219);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(169, 31);
            this.labelTanggal.TabIndex = 6;
            this.labelTanggal.Text = "labelTanggal";
            // 
            // UC_BubbleChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.pictureBoxTeman);
            this.Controls.Add(this.pictureBoxUIser);
            this.Controls.Add(this.labelPesan);
            this.Controls.Add(this.btnReplyTeman);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_BubbleChat";
            this.Size = new System.Drawing.Size(1486, 282);
            this.Load += new System.EventHandler(this.UC_BubbleChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplyTeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUIser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTeman;
        private System.Windows.Forms.PictureBox btnReplyTeman;
        private System.Windows.Forms.Label labelPesan;
        private System.Windows.Forms.PictureBox pictureBoxUIser;
        private System.Windows.Forms.Label labelTanggal;
    }
}
