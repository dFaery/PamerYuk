namespace PamerYukFormsApp.Prototype2.User_Control.FiturChat
{
    partial class UC_TambahNotes
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
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelTambahNote = new System.Windows.Forms.Label();
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
            this.buttonKirim.TabIndex = 121;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = false;
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(1330, 953);
            this.buttonBatal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(348, 85);
            this.buttonBatal.TabIndex = 120;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(226, 167);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(1819, 736);
            this.textBoxNotes.TabIndex = 119;
            this.textBoxNotes.Text = "Tulis catatan";
            // 
            // labelTambahNote
            // 
            this.labelTambahNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTambahNote.AutoSize = true;
            this.labelTambahNote.BackColor = System.Drawing.Color.Transparent;
            this.labelTambahNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambahNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTambahNote.Location = new System.Drawing.Point(213, 76);
            this.labelTambahNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTambahNote.Name = "labelTambahNote";
            this.labelTambahNote.Size = new System.Drawing.Size(364, 63);
            this.labelTambahNote.TabIndex = 122;
            this.labelTambahNote.Text = "Tambah Note";
            this.labelTambahNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_TambahNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labelTambahNote);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.textBoxNotes);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_TambahNotes";
            this.Size = new System.Drawing.Size(2272, 1206);
            this.Load += new System.EventHandler(this.UC_TambahNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelTambahNote;
    }
}
