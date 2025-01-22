namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_KontenDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KontenDetail));
            this.labelTanggalUpload = new System.Windows.Forms.Label();
            this.labelLikeQuantity = new System.Windows.Forms.Label();
            this.buttonLike = new System.Windows.Forms.PictureBox();
            this.listBoxKomentar = new System.Windows.Forms.ListBox();
            this.btnKirim = new System.Windows.Forms.PictureBox();
            this.textBoxKomen = new System.Windows.Forms.TextBox();
            this.labelTag = new System.Windows.Forms.Label();
            this.comboBoxTag = new System.Windows.Forms.ComboBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.pictureBoxKonten = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxCaption = new System.Windows.Forms.ListBox();
            this.pictureBoxShare = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShare)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTanggalUpload
            // 
            this.labelTanggalUpload.AutoSize = true;
            this.labelTanggalUpload.Location = new System.Drawing.Point(1879, 840);
            this.labelTanggalUpload.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTanggalUpload.Name = "labelTanggalUpload";
            this.labelTanggalUpload.Size = new System.Drawing.Size(216, 32);
            this.labelTanggalUpload.TabIndex = 134;
            this.labelTanggalUpload.Text = "Tanggal Upload";
            // 
            // labelLikeQuantity
            // 
            this.labelLikeQuantity.AutoSize = true;
            this.labelLikeQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikeQuantity.Location = new System.Drawing.Point(1221, 818);
            this.labelLikeQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLikeQuantity.Name = "labelLikeQuantity";
            this.labelLikeQuantity.Size = new System.Drawing.Size(169, 31);
            this.labelLikeQuantity.TabIndex = 133;
            this.labelLikeQuantity.Text = "Jumlah Like";
            // 
            // buttonLike
            // 
            this.buttonLike.BackColor = System.Drawing.Color.Transparent;
            this.buttonLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLike.Image = global::PamerYukFormsApp.Properties.Resources.Like_false;
            this.buttonLike.Location = new System.Drawing.Point(1129, 800);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(80, 71);
            this.buttonLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonLike.TabIndex = 132;
            this.buttonLike.TabStop = false;
            // 
            // listBoxKomentar
            // 
            this.listBoxKomentar.FormattingEnabled = true;
            this.listBoxKomentar.ItemHeight = 31;
            this.listBoxKomentar.Location = new System.Drawing.Point(1129, 445);
            this.listBoxKomentar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listBoxKomentar.Name = "listBoxKomentar";
            this.listBoxKomentar.Size = new System.Drawing.Size(962, 252);
            this.listBoxKomentar.TabIndex = 131;
            // 
            // btnKirim
            // 
            this.btnKirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKirim.Image = global::PamerYukFormsApp.Properties.Resources.SendMessage;
            this.btnKirim.Location = new System.Drawing.Point(2018, 716);
            this.btnKirim.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(76, 71);
            this.btnKirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnKirim.TabIndex = 130;
            this.btnKirim.TabStop = false;
            // 
            // textBoxKomen
            // 
            this.textBoxKomen.Location = new System.Drawing.Point(1129, 716);
            this.textBoxKomen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxKomen.Multiline = true;
            this.textBoxKomen.Name = "textBoxKomen";
            this.textBoxKomen.Size = new System.Drawing.Size(875, 69);
            this.textBoxKomen.TabIndex = 129;
            // 
            // labelTag
            // 
            this.labelTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(1120, 312);
            this.labelTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(321, 39);
            this.labelTag.TabIndex = 128;
            this.labelTag.Text = "Orang di konten ini";
            // 
            // comboBoxTag
            // 
            this.comboBoxTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxTag.FormattingEnabled = true;
            this.comboBoxTag.Location = new System.Drawing.Point(1129, 364);
            this.comboBoxTag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(962, 46);
            this.comboBoxTag.TabIndex = 127;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Image = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(1129, 25);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(110, 96);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfilePicture.TabIndex = 125;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUser.Location = new System.Drawing.Point(1273, 53);
            this.labelCurrentUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(258, 46);
            this.labelCurrentUser.TabIndex = 124;
            this.labelCurrentUser.Text = "Current_User";
            // 
            // pictureBoxKonten
            // 
            this.pictureBoxKonten.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.Tambahkonten_false;
            this.pictureBoxKonten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxKonten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKonten.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxKonten.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxKonten.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBoxKonten.Name = "pictureBoxKonten";
            this.pictureBoxKonten.Size = new System.Drawing.Size(1051, 930);
            this.pictureBoxKonten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxKonten.TabIndex = 122;
            this.pictureBoxKonten.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(64, 46);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(540, 538);
            this.axWindowsMediaPlayer1.TabIndex = 123;
            // 
            // listBoxCaption
            // 
            this.listBoxCaption.FormattingEnabled = true;
            this.listBoxCaption.ItemHeight = 31;
            this.listBoxCaption.Location = new System.Drawing.Point(1129, 146);
            this.listBoxCaption.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listBoxCaption.Name = "listBoxCaption";
            this.listBoxCaption.Size = new System.Drawing.Size(962, 159);
            this.listBoxCaption.TabIndex = 135;
            // 
            // pictureBoxShare
            // 
            this.pictureBoxShare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxShare.Image = global::PamerYukFormsApp.Properties.Resources.SendMessage;
            this.pictureBoxShare.Location = new System.Drawing.Point(1400, 801);
            this.pictureBoxShare.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxShare.Name = "pictureBoxShare";
            this.pictureBoxShare.Size = new System.Drawing.Size(76, 71);
            this.pictureBoxShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShare.TabIndex = 136;
            this.pictureBoxShare.TabStop = false;
            this.pictureBoxShare.Click += new System.EventHandler(this.pictureBoxShare_Click);
            // 
            // UC_KontenDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBoxShare);
            this.Controls.Add(this.listBoxCaption);
            this.Controls.Add(this.labelTanggalUpload);
            this.Controls.Add(this.labelLikeQuantity);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.listBoxKomentar);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.textBoxKomen);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.comboBoxTag);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.labelCurrentUser);
            this.Controls.Add(this.pictureBoxKonten);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_KontenDetail";
            this.Size = new System.Drawing.Size(2135, 930);
            this.Load += new System.EventHandler(this.UC_KontenDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTanggalUpload;
        private System.Windows.Forms.Label labelLikeQuantity;
        private System.Windows.Forms.PictureBox buttonLike;
        private System.Windows.Forms.ListBox listBoxKomentar;
        private System.Windows.Forms.PictureBox btnKirim;
        private System.Windows.Forms.TextBox textBoxKomen;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.ComboBox comboBoxTag;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.PictureBox pictureBoxKonten;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBoxCaption;
        private System.Windows.Forms.PictureBox pictureBoxShare;
    }
}
