namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_ProfileNew
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
            this.flowLayoutPanelProfileContent = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelProfileContent
            // 
            this.flowLayoutPanelProfileContent.AutoScroll = true;
            this.flowLayoutPanelProfileContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelProfileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProfileContent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelProfileContent.Name = "flowLayoutPanelProfileContent";
            this.flowLayoutPanelProfileContent.Size = new System.Drawing.Size(1278, 778);
            this.flowLayoutPanelProfileContent.TabIndex = 2;
            // 
            // UC_ProfileNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.flowLayoutPanelProfileContent);
            this.Name = "UC_ProfileNew";
            this.Size = new System.Drawing.Size(1278, 778);
            this.Load += new System.EventHandler(this.UC_ProfileNew_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProfileContent;
    }
}
