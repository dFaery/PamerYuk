namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_TambahGroup
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
            this.dataGridViewTeman = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNamaGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuatGroup = new System.Windows.Forms.PictureBox();
            this.buttonBatal = new System.Windows.Forms.PictureBox();
            this.pictureBoxIconGroup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBuatGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeman
            // 
            this.dataGridViewTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeman.Location = new System.Drawing.Point(228, 524);
            this.dataGridViewTeman.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dataGridViewTeman.Name = "dataGridViewTeman";
            this.dataGridViewTeman.RowHeadersWidth = 62;
            this.dataGridViewTeman.Size = new System.Drawing.Size(1828, 302);
            this.dataGridViewTeman.TabIndex = 102;
            this.dataGridViewTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeman_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(219, 467);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 38);
            this.label3.TabIndex = 101;
            this.label3.Text = "Tambah Anggota Group";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNamaGroup
            // 
            this.textBoxNamaGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNamaGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaGroup.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNamaGroup.Location = new System.Drawing.Point(539, 228);
            this.textBoxNamaGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxNamaGroup.Multiline = true;
            this.textBoxNamaGroup.Name = "textBoxNamaGroup";
            this.textBoxNamaGroup.Size = new System.Drawing.Size(1508, 71);
            this.textBoxNamaGroup.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(238, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 32);
            this.label2.TabIndex = 99;
            this.label2.Text = "Tambah Icon Group";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(528, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 46);
            this.label1.TabIndex = 98;
            this.label1.Text = "Masukan Nama Group Anda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBuatGroup
            // 
            this.buttonBuatGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBuatGroup.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuatGroup.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.btnBuatGroup_True;
            this.buttonBuatGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBuatGroup.Location = new System.Drawing.Point(1705, 857);
            this.buttonBuatGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonBuatGroup.Name = "buttonBuatGroup";
            this.buttonBuatGroup.Size = new System.Drawing.Size(348, 85);
            this.buttonBuatGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonBuatGroup.TabIndex = 104;
            this.buttonBuatGroup.TabStop = false;
            this.buttonBuatGroup.Click += new System.EventHandler(this.buttonBuatGroup_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBatal.BackColor = System.Drawing.Color.Transparent;
            this.buttonBatal.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.btnBuatGroup_False;
            this.buttonBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBatal.Location = new System.Drawing.Point(1335, 857);
            this.buttonBatal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(348, 85);
            this.buttonBatal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonBatal.TabIndex = 103;
            this.buttonBatal.TabStop = false;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // pictureBoxIconGroup
            // 
            this.pictureBoxIconGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxIconGroup.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIconGroup.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.NewGroup_GroupIcon;
            this.pictureBoxIconGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxIconGroup.Location = new System.Drawing.Point(228, 107);
            this.pictureBoxIconGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBoxIconGroup.Name = "pictureBoxIconGroup";
            this.pictureBoxIconGroup.Size = new System.Drawing.Size(292, 234);
            this.pictureBoxIconGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconGroup.TabIndex = 97;
            this.pictureBoxIconGroup.TabStop = false;
            // 
            // UC_TambahGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.buttonBuatGroup);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.dataGridViewTeman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNamaGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxIconGroup);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_TambahGroup";
            this.Size = new System.Drawing.Size(2272, 1049);
            this.Load += new System.EventHandler(this.UC_TambahGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBuatGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonBuatGroup;
        private System.Windows.Forms.PictureBox buttonBatal;
        private System.Windows.Forms.DataGridView dataGridViewTeman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNamaGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxIconGroup;
    }
}
