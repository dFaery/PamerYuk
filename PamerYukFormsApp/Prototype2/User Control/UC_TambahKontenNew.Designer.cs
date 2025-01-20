namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_TambahKontenNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TambahKontenNew));
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.btnTambahKonten = new System.Windows.Forms.Label();
            this.labelCaption = new System.Windows.Forms.Label();
            this.dataGridViewTeman = new System.Windows.Forms.DataGridView();
            this.labelTag = new System.Windows.Forms.Label();
            this.buttonUploadImage = new System.Windows.Forms.Label();
            this.pictureBoxKonten = new System.Windows.Forms.PictureBox();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.textBoxCaption = new System.Windows.Forms.TextBox();
            this.panelInformasiKonten = new System.Windows.Forms.Panel();
            this.panelUploadKonten = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.panelInformasiKonten.SuspendLayout();
            this.panelUploadKonten.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUser.Location = new System.Drawing.Point(103, 32);
            this.labelCurrentUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(156, 29);
            this.labelCurrentUser.TabIndex = 109;
            this.labelCurrentUser.Text = "Current_User";
            // 
            // btnTambahKonten
            // 
            this.btnTambahKonten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambahKonten.AutoSize = true;
            this.btnTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahKonten.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTambahKonten.Location = new System.Drawing.Point(536, 516);
            this.btnTambahKonten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnTambahKonten.Name = "btnTambahKonten";
            this.btnTambahKonten.Size = new System.Drawing.Size(82, 29);
            this.btnTambahKonten.TabIndex = 108;
            this.btnTambahKonten.Text = "Share";
            this.btnTambahKonten.Click += new System.EventHandler(this.btnTambahKonten_Click);
            // 
            // labelCaption
            // 
            this.labelCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCaption.AutoSize = true;
            this.labelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaption.Location = new System.Drawing.Point(15, 97);
            this.labelCaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(96, 29);
            this.labelCaption.TabIndex = 106;
            this.labelCaption.Text = "Caption";
            // 
            // dataGridViewTeman
            // 
            this.dataGridViewTeman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeman.Location = new System.Drawing.Point(21, 319);
            this.dataGridViewTeman.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridViewTeman.Name = "dataGridViewTeman";
            this.dataGridViewTeman.RowHeadersWidth = 62;
            this.dataGridViewTeman.RowTemplate.Height = 28;
            this.dataGridViewTeman.Size = new System.Drawing.Size(597, 181);
            this.dataGridViewTeman.TabIndex = 105;
            this.dataGridViewTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeman_CellContentClick);
            // 
            // labelTag
            // 
            this.labelTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(15, 280);
            this.labelTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(105, 29);
            this.labelTag.TabIndex = 104;
            this.labelTag.Text = "Add Tag";
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUploadImage.AutoSize = true;
            this.buttonUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadImage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonUploadImage.Location = new System.Drawing.Point(84, 5);
            this.buttonUploadImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(207, 25);
            this.buttonUploadImage.TabIndex = 103;
            this.buttonUploadImage.Text = "Upload Foto/Video";
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // pictureBoxKonten
            // 
            this.pictureBoxKonten.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxKonten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxKonten.Location = new System.Drawing.Point(114, 40);
            this.pictureBoxKonten.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxKonten.Name = "pictureBoxKonten";
            this.pictureBoxKonten.Size = new System.Drawing.Size(376, 500);
            this.pictureBoxKonten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKonten.TabIndex = 107;
            this.pictureBoxKonten.TabStop = false;
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(518, 245);
            this.videoPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(621, 493);
            this.videoPlayer.TabIndex = 101;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Image = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(22, 14);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(62, 62);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfilePicture.TabIndex = 110;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Location = new System.Drawing.Point(21, 129);
            this.textBoxCaption.Multiline = true;
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(597, 129);
            this.textBoxCaption.TabIndex = 111;
            // 
            // panelInformasiKonten
            // 
            this.panelInformasiKonten.Controls.Add(this.textBoxCaption);
            this.panelInformasiKonten.Controls.Add(this.btnTambahKonten);
            this.panelInformasiKonten.Controls.Add(this.pictureBoxProfilePicture);
            this.panelInformasiKonten.Controls.Add(this.labelTag);
            this.panelInformasiKonten.Controls.Add(this.labelCurrentUser);
            this.panelInformasiKonten.Controls.Add(this.dataGridViewTeman);
            this.panelInformasiKonten.Controls.Add(this.labelCaption);
            this.panelInformasiKonten.Location = new System.Drawing.Point(495, 40);
            this.panelInformasiKonten.Name = "panelInformasiKonten";
            this.panelInformasiKonten.Size = new System.Drawing.Size(740, 562);
            this.panelInformasiKonten.TabIndex = 112;
            // 
            // panelUploadKonten
            // 
            this.panelUploadKonten.Controls.Add(this.buttonUploadImage);
            this.panelUploadKonten.Location = new System.Drawing.Point(114, 545);
            this.panelUploadKonten.Name = "panelUploadKonten";
            this.panelUploadKonten.Size = new System.Drawing.Size(375, 57);
            this.panelUploadKonten.TabIndex = 113;
            // 
            // UC_TambahKontenNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelInformasiKonten);
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.pictureBoxKonten);
            this.Controls.Add(this.panelUploadKonten);
            this.Name = "UC_TambahKontenNew";
            this.Size = new System.Drawing.Size(1278, 678);
            this.Load += new System.EventHandler(this.UC_TambahKontenNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.panelInformasiKonten.ResumeLayout(false);
            this.panelInformasiKonten.PerformLayout();
            this.panelUploadKonten.ResumeLayout(false);
            this.panelUploadKonten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Label btnTambahKonten;
        private System.Windows.Forms.PictureBox pictureBoxKonten;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.DataGridView dataGridViewTeman;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label buttonUploadImage;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.TextBox textBoxCaption;
        private System.Windows.Forms.Panel panelInformasiKonten;
        private System.Windows.Forms.Panel panelUploadKonten;
    }
}
