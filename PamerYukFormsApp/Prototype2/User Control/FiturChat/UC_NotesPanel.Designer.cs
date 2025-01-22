namespace PamerYukFormsApp.Prototype2.User_Control.FiturChat
{
    partial class UC_NotesPanel
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
            this.listBoxOutputNotes = new System.Windows.Forms.ListBox();
            this.labelHariPostNote = new System.Windows.Forms.Label();
            this.labelContactName = new System.Windows.Forms.Label();
            this.pictureBoxPengirim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPengirim)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxOutputNotes
            // 
            this.listBoxOutputNotes.FormattingEnabled = true;
            this.listBoxOutputNotes.ItemHeight = 31;
            this.listBoxOutputNotes.Location = new System.Drawing.Point(114, 166);
            this.listBoxOutputNotes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listBoxOutputNotes.Name = "listBoxOutputNotes";
            this.listBoxOutputNotes.Size = new System.Drawing.Size(2041, 562);
            this.listBoxOutputNotes.TabIndex = 53;
            // 
            // labelHariPostNote
            // 
            this.labelHariPostNote.AutoSize = true;
            this.labelHariPostNote.BackColor = System.Drawing.Color.Transparent;
            this.labelHariPostNote.Location = new System.Drawing.Point(277, 85);
            this.labelHariPostNote.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHariPostNote.Name = "labelHariPostNote";
            this.labelHariPostNote.Size = new System.Drawing.Size(254, 32);
            this.labelHariPostNote.TabIndex = 52;
            this.labelHariPostNote.Text = "DateTimePostNote";
            this.labelHariPostNote.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactName.Location = new System.Drawing.Point(272, 31);
            this.labelContactName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(276, 46);
            this.labelContactName.TabIndex = 51;
            this.labelContactName.Text = "Contact Name";
            // 
            // pictureBoxPengirim
            // 
            this.pictureBoxPengirim.Image = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.pictureBoxPengirim.Location = new System.Drawing.Point(114, 16);
            this.pictureBoxPengirim.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBoxPengirim.Name = "pictureBoxPengirim";
            this.pictureBoxPengirim.Size = new System.Drawing.Size(133, 116);
            this.pictureBoxPengirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPengirim.TabIndex = 50;
            this.pictureBoxPengirim.TabStop = false;
            // 
            // UC_NotesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.listBoxOutputNotes);
            this.Controls.Add(this.labelHariPostNote);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.pictureBoxPengirim);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_NotesPanel";
            this.Size = new System.Drawing.Size(2272, 780);
            this.Load += new System.EventHandler(this.UC_NotesPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPengirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOutputNotes;
        private System.Windows.Forms.Label labelHariPostNote;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.PictureBox pictureBoxPengirim;
    }
}
