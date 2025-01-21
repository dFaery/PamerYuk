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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxOutputNotes
            // 
            this.listBoxOutputNotes.FormattingEnabled = true;
            this.listBoxOutputNotes.ItemHeight = 20;
            this.listBoxOutputNotes.Location = new System.Drawing.Point(64, 107);
            this.listBoxOutputNotes.Name = "listBoxOutputNotes";
            this.listBoxOutputNotes.Size = new System.Drawing.Size(1150, 364);
            this.listBoxOutputNotes.TabIndex = 53;
            // 
            // labelHariPostNote
            // 
            this.labelHariPostNote.AutoSize = true;
            this.labelHariPostNote.BackColor = System.Drawing.Color.Transparent;
            this.labelHariPostNote.Location = new System.Drawing.Point(156, 55);
            this.labelHariPostNote.Name = "labelHariPostNote";
            this.labelHariPostNote.Size = new System.Drawing.Size(144, 20);
            this.labelHariPostNote.TabIndex = 52;
            this.labelHariPostNote.Text = "DateTimePostNote";
            this.labelHariPostNote.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactName.Location = new System.Drawing.Point(153, 20);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(165, 29);
            this.labelContactName.TabIndex = 51;
            this.labelContactName.Text = "Contact Name";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.pictureBoxProfile.Location = new System.Drawing.Point(64, 10);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 50;
            this.pictureBoxProfile.TabStop = false;
            // 
            // UC_NotesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.listBoxOutputNotes);
            this.Controls.Add(this.labelHariPostNote);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Name = "UC_NotesPanel";
            this.Size = new System.Drawing.Size(1278, 503);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOutputNotes;
        private System.Windows.Forms.Label labelHariPostNote;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
    }
}
