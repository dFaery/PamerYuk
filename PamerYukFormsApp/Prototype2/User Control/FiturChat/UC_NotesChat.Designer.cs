namespace PamerYukFormsApp.Prototype2.User_Control.FiturChat
{
    partial class UC_NotesChat
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
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxPencil = new System.Windows.Forms.PictureBox();
            this.buttonNewNote = new System.Windows.Forms.Button();
            this.flowLayoutPanelNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPencil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBoxPencil);
            this.panel.Controls.Add(this.buttonNewNote);
            this.panel.Controls.Add(this.flowLayoutPanelNotes);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1278, 778);
            this.panel.TabIndex = 0;
            // 
            // pictureBoxPencil
            // 
            this.pictureBoxPencil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxPencil.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPencil.BackgroundImage = global::PamerYukFormsApp.Properties.Resources.PencilEdit1;
            this.pictureBoxPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPencil.Location = new System.Drawing.Point(75, 40);
            this.pictureBoxPencil.Name = "pictureBoxPencil";
            this.pictureBoxPencil.Size = new System.Drawing.Size(27, 29);
            this.pictureBoxPencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPencil.TabIndex = 70;
            this.pictureBoxPencil.TabStop = false;
            // 
            // buttonNewNote
            // 
            this.buttonNewNote.Location = new System.Drawing.Point(59, 30);
            this.buttonNewNote.Name = "buttonNewNote";
            this.buttonNewNote.Size = new System.Drawing.Size(1172, 49);
            this.buttonNewNote.TabIndex = 69;
            this.buttonNewNote.Text = "          Buat catatan";
            this.buttonNewNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewNote.UseVisualStyleBackColor = true;
            this.buttonNewNote.Click += new System.EventHandler(this.buttonNewNote_Click);
            // 
            // flowLayoutPanelNotes
            // 
            this.flowLayoutPanelNotes.AutoScroll = true;
            this.flowLayoutPanelNotes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelNotes.Location = new System.Drawing.Point(0, 85);
            this.flowLayoutPanelNotes.Name = "flowLayoutPanelNotes";
            this.flowLayoutPanelNotes.Size = new System.Drawing.Size(1278, 664);
            this.flowLayoutPanelNotes.TabIndex = 68;
            // 
            // UC_NotesChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel);
            this.Name = "UC_NotesChat";
            this.Size = new System.Drawing.Size(1278, 778);
            this.Load += new System.EventHandler(this.UC_NotesChat_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPencil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxPencil;
        private System.Windows.Forms.Button buttonNewNote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNotes;
    }
}
