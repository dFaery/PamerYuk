namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_TambahKonten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TambahKonten));
            this.buttonTambahKonten = new System.Windows.Forms.Button();
            this.dataGridViewTeman = new System.Windows.Forms.DataGridView();
            this.labelTag = new System.Windows.Forms.Label();
            this.buttonUploadImage = new System.Windows.Forms.Label();
            this.textBoxCaption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBoxKonten = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTambahKonten
            // 
            this.buttonTambahKonten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTambahKonten.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTambahKonten.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonTambahKonten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTambahKonten.Location = new System.Drawing.Point(1072, 798);
            this.buttonTambahKonten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTambahKonten.Name = "buttonTambahKonten";
            this.buttonTambahKonten.Size = new System.Drawing.Size(1036, 115);
            this.buttonTambahKonten.TabIndex = 87;
            this.buttonTambahKonten.Text = "Tambah Konten";
            this.buttonTambahKonten.UseVisualStyleBackColor = false;
            this.buttonTambahKonten.Click += new System.EventHandler(this.buttonTambahKonten_Click);
            // 
            // dataGridViewTeman
            // 
            this.dataGridViewTeman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeman.Location = new System.Drawing.Point(1072, 484);
            this.dataGridViewTeman.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewTeman.Name = "dataGridViewTeman";
            this.dataGridViewTeman.RowHeadersWidth = 62;
            this.dataGridViewTeman.RowTemplate.Height = 28;
            this.dataGridViewTeman.Size = new System.Drawing.Size(1036, 285);
            this.dataGridViewTeman.TabIndex = 86;
            this.dataGridViewTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeman_CellContentClick);
            // 
            // labelTag
            // 
            this.labelTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(1063, 414);
            this.labelTag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(88, 46);
            this.labelTag.TabIndex = 85;
            this.labelTag.Text = "Tag";
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUploadImage.AutoSize = true;
            this.buttonUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadImage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonUploadImage.Location = new System.Drawing.Point(338, 888);
            this.buttonUploadImage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(375, 46);
            this.buttonUploadImage.TabIndex = 84;
            this.buttonUploadImage.Text = "UPLOAD KONTEN";
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaption.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCaption.Location = new System.Drawing.Point(1075, 210);
            this.textBoxCaption.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCaption.Multiline = true;
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(1033, 182);
            this.textBoxCaption.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1067, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 46);
            this.label1.TabIndex = 88;
            this.label1.Text = "Caption";
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(157, 138);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(720, 720);
            this.videoPlayer.TabIndex = 0;
            // 
            // pictureBoxKonten
            // 
            this.pictureBoxKonten.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.Tambahkonten_false;
            this.pictureBoxKonten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxKonten.Location = new System.Drawing.Point(157, 138);
            this.pictureBoxKonten.Name = "pictureBoxKonten";
            this.pictureBoxKonten.Size = new System.Drawing.Size(720, 720);
            this.pictureBoxKonten.TabIndex = 89;
            this.pictureBoxKonten.TabStop = false;
            // 
            // UC_TambahKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBoxKonten);
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTambahKonten);
            this.Controls.Add(this.dataGridViewTeman);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.textBoxCaption);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_TambahKonten";
            this.Size = new System.Drawing.Size(2272, 1051);
            this.Load += new System.EventHandler(this.UC_TambahKonten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTambahKonten;
        private System.Windows.Forms.DataGridView dataGridViewTeman;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label buttonUploadImage;
        private System.Windows.Forms.TextBox textBoxCaption;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.PictureBox pictureBoxKonten;
    }
}
