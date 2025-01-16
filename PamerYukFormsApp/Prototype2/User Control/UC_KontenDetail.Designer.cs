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
            this.labelLikeQuantity = new System.Windows.Forms.Label();
            this.buttonLike = new System.Windows.Forms.PictureBox();
            this.btnKirim = new System.Windows.Forms.PictureBox();
            this.textBoxKomen = new System.Windows.Forms.TextBox();
            this.pictureBoxKonten = new System.Windows.Forms.PictureBox();
            this.listBoxCaption = new System.Windows.Forms.ListBox();
            this.listBoxKomentar = new System.Windows.Forms.ListBox();
            this.comboBoxTag = new System.Windows.Forms.ComboBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLikeQuantity
            // 
            this.labelLikeQuantity.AutoSize = true;
            this.labelLikeQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikeQuantity.Location = new System.Drawing.Point(169, 612);
            this.labelLikeQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLikeQuantity.Name = "labelLikeQuantity";
            this.labelLikeQuantity.Size = new System.Drawing.Size(169, 31);
            this.labelLikeQuantity.TabIndex = 90;
            this.labelLikeQuantity.Text = "Jumlah Like";
            // 
            // buttonLike
            // 
            this.buttonLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLike.Image = global::PamerYukFormsApp.Properties.Resources.Like_false;
            this.buttonLike.Location = new System.Drawing.Point(87, 589);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(80, 71);
            this.buttonLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonLike.TabIndex = 89;
            this.buttonLike.TabStop = false;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // btnKirim
            // 
            this.btnKirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKirim.Image = global::PamerYukFormsApp.Properties.Resources.SendMessage;
            this.btnKirim.Location = new System.Drawing.Point(1385, 612);
            this.btnKirim.Margin = new System.Windows.Forms.Padding(5);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(64, 56);
            this.btnKirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnKirim.TabIndex = 88;
            this.btnKirim.TabStop = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // textBoxKomen
            // 
            this.textBoxKomen.Location = new System.Drawing.Point(720, 603);
            this.textBoxKomen.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxKomen.Multiline = true;
            this.textBoxKomen.Name = "textBoxKomen";
            this.textBoxKomen.Size = new System.Drawing.Size(660, 69);
            this.textBoxKomen.TabIndex = 87;
            // 
            // pictureBoxKonten
            // 
            this.pictureBoxKonten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxKonten.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.Tambahkonten_false;
            this.pictureBoxKonten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxKonten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKonten.Location = new System.Drawing.Point(87, 36);
            this.pictureBoxKonten.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxKonten.Name = "pictureBoxKonten";
            this.pictureBoxKonten.Size = new System.Drawing.Size(540, 540);
            this.pictureBoxKonten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxKonten.TabIndex = 84;
            this.pictureBoxKonten.TabStop = false;
            // 
            // listBoxCaption
            // 
            this.listBoxCaption.FormattingEnabled = true;
            this.listBoxCaption.ItemHeight = 31;
            this.listBoxCaption.Location = new System.Drawing.Point(720, 101);
            this.listBoxCaption.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxCaption.Name = "listBoxCaption";
            this.listBoxCaption.Size = new System.Drawing.Size(726, 128);
            this.listBoxCaption.TabIndex = 91;
            // 
            // listBoxKomentar
            // 
            this.listBoxKomentar.FormattingEnabled = true;
            this.listBoxKomentar.ItemHeight = 31;
            this.listBoxKomentar.Location = new System.Drawing.Point(720, 260);
            this.listBoxKomentar.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxKomentar.Name = "listBoxKomentar";
            this.listBoxKomentar.Size = new System.Drawing.Size(726, 314);
            this.listBoxKomentar.TabIndex = 92;
            // 
            // comboBoxTag
            // 
            this.comboBoxTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxTag.FormattingEnabled = true;
            this.comboBoxTag.Location = new System.Drawing.Point(720, 36);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(729, 46);
            this.comboBoxTag.TabIndex = 93;
            this.comboBoxTag.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(87, 36);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(540, 538);
            this.axWindowsMediaPlayer1.TabIndex = 94;
            // 
            // UC_KontenDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBoxKonten);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.comboBoxTag);
            this.Controls.Add(this.listBoxKomentar);
            this.Controls.Add(this.listBoxCaption);
            this.Controls.Add(this.labelLikeQuantity);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.textBoxKomen);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_KontenDetail";
            this.Size = new System.Drawing.Size(1557, 775);
            this.Load += new System.EventHandler(this.UC_KontenDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLikeQuantity;
        private System.Windows.Forms.PictureBox buttonLike;
        private System.Windows.Forms.PictureBox btnKirim;
        private System.Windows.Forms.TextBox textBoxKomen;
        private System.Windows.Forms.PictureBox pictureBoxKonten;
        private System.Windows.Forms.ListBox listBoxCaption;
        private System.Windows.Forms.ListBox listBoxKomentar;
        private System.Windows.Forms.ComboBox comboBoxTag;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
