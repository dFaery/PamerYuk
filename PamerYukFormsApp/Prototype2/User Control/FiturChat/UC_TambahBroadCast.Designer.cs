namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_TambahBroadCast
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
            this.buttonKirim = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.textBoxBroadcast = new System.Windows.Forms.TextBox();
            this.labelTambahBroadCast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKirim
            // 
            this.buttonKirim.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonKirim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKirim.Location = new System.Drawing.Point(1700, 953);
            this.buttonKirim.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(348, 85);
            this.buttonKirim.TabIndex = 124;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = false;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(1330, 953);
            this.buttonBatal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(348, 85);
            this.buttonBatal.TabIndex = 123;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            // 
            // textBoxBroadcast
            // 
            this.textBoxBroadcast.Location = new System.Drawing.Point(226, 167);
            this.textBoxBroadcast.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxBroadcast.Multiline = true;
            this.textBoxBroadcast.Name = "textBoxBroadcast";
            this.textBoxBroadcast.Size = new System.Drawing.Size(1819, 736);
            this.textBoxBroadcast.TabIndex = 122;
            this.textBoxBroadcast.Text = "Tulis pesan untuk semua teman";
            // 
            // labelTambahBroadCast
            // 
            this.labelTambahBroadCast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTambahBroadCast.AutoSize = true;
            this.labelTambahBroadCast.BackColor = System.Drawing.Color.Transparent;
            this.labelTambahBroadCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambahBroadCast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTambahBroadCast.Location = new System.Drawing.Point(213, 85);
            this.labelTambahBroadCast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTambahBroadCast.Name = "labelTambahBroadCast";
            this.labelTambahBroadCast.Size = new System.Drawing.Size(510, 63);
            this.labelTambahBroadCast.TabIndex = 125;
            this.labelTambahBroadCast.Text = "Tambah BroadCast";
            this.labelTambahBroadCast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_TambahBroadCast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labelTambahBroadCast);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.textBoxBroadcast);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_TambahBroadCast";
            this.Size = new System.Drawing.Size(2272, 1206);
            this.Load += new System.EventHandler(this.UC_TambahBroadCast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.TextBox textBoxBroadcast;
        private System.Windows.Forms.Label labelTambahBroadCast;
    }
}
