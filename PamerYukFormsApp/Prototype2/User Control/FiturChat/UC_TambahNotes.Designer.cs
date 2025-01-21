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
            this.buttonKirim.Location = new System.Drawing.Point(956, 615);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(196, 55);
            this.buttonKirim.TabIndex = 121;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = false;
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(748, 615);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(196, 55);
            this.buttonBatal.TabIndex = 120;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(127, 108);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(1025, 476);
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
            this.labelTambahNote.Location = new System.Drawing.Point(120, 49);
            this.labelTambahNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTambahNote.Name = "labelTambahNote";
            this.labelTambahNote.Size = new System.Drawing.Size(224, 37);
            this.labelTambahNote.TabIndex = 122;
            this.labelTambahNote.Text = "Tambah Note";
            this.labelTambahNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_TambahNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labelTambahNote);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.textBoxNotes);
            this.Name = "UC_TambahNotes";
            this.Size = new System.Drawing.Size(1278, 778);
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
