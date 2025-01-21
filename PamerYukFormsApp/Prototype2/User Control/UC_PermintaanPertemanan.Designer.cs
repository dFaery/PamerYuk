namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_PermintaanPertemanan
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
            this.labelPertemananTerkirim = new System.Windows.Forms.Label();
            this.labelPertemananMasuk = new System.Windows.Forms.Label();
            this.labelRequestPertemanan = new System.Windows.Forms.Label();
            this.flowLayoutPanelRequestPertemanan = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRequestPertemenan = new System.Windows.Forms.Panel();
            this.panelRequestPertemenan.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPertemananTerkirim
            // 
            this.labelPertemananTerkirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPertemananTerkirim.AutoSize = true;
            this.labelPertemananTerkirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPertemananTerkirim.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPertemananTerkirim.Location = new System.Drawing.Point(657, 52);
            this.labelPertemananTerkirim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPertemananTerkirim.Name = "labelPertemananTerkirim";
            this.labelPertemananTerkirim.Size = new System.Drawing.Size(90, 25);
            this.labelPertemananTerkirim.TabIndex = 46;
            this.labelPertemananTerkirim.Text = "Terkirim";
            this.labelPertemananTerkirim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPertemananTerkirim.Click += new System.EventHandler(this.labelPertemananTerkirim_Click);
            // 
            // labelPertemananMasuk
            // 
            this.labelPertemananMasuk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPertemananMasuk.AutoSize = true;
            this.labelPertemananMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPertemananMasuk.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPertemananMasuk.Location = new System.Drawing.Point(508, 52);
            this.labelPertemananMasuk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPertemananMasuk.Name = "labelPertemananMasuk";
            this.labelPertemananMasuk.Size = new System.Drawing.Size(76, 25);
            this.labelPertemananMasuk.TabIndex = 45;
            this.labelPertemananMasuk.Text = "Masuk";
            this.labelPertemananMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPertemananMasuk.Click += new System.EventHandler(this.labelPertemananMasuk_Click);
            // 
            // labelRequestPertemanan
            // 
            this.labelRequestPertemanan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelRequestPertemanan.AutoSize = true;
            this.labelRequestPertemanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestPertemanan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRequestPertemanan.Location = new System.Drawing.Point(508, 15);
            this.labelRequestPertemanan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequestPertemanan.Name = "labelRequestPertemanan";
            this.labelRequestPertemanan.Size = new System.Drawing.Size(258, 29);
            this.labelRequestPertemanan.TabIndex = 42;
            this.labelRequestPertemanan.Text = "Request Pertemenan";
            this.labelRequestPertemanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelRequestPertemanan
            // 
            this.flowLayoutPanelRequestPertemanan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelRequestPertemanan.Location = new System.Drawing.Point(-1, 98);
            this.flowLayoutPanelRequestPertemanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelRequestPertemanan.Name = "flowLayoutPanelRequestPertemanan";
            this.flowLayoutPanelRequestPertemanan.Size = new System.Drawing.Size(1278, 562);
            this.flowLayoutPanelRequestPertemanan.TabIndex = 44;
            // 
            // panelRequestPertemenan
            // 
            this.panelRequestPertemenan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRequestPertemenan.Controls.Add(this.labelPertemananTerkirim);
            this.panelRequestPertemenan.Controls.Add(this.labelPertemananMasuk);
            this.panelRequestPertemenan.Controls.Add(this.labelRequestPertemanan);
            this.panelRequestPertemenan.Controls.Add(this.flowLayoutPanelRequestPertemanan);
            this.panelRequestPertemenan.Location = new System.Drawing.Point(1, 9);
            this.panelRequestPertemenan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRequestPertemenan.Name = "panelRequestPertemenan";
            this.panelRequestPertemenan.Size = new System.Drawing.Size(1277, 660);
            this.panelRequestPertemenan.TabIndex = 49;
            // 
            // UC_PermintaanPertemanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelRequestPertemenan);
            this.Name = "UC_PermintaanPertemanan";
            this.Size = new System.Drawing.Size(1278, 678);
            this.Load += new System.EventHandler(this.UC_PermintaanPertemanan_Load);
            this.panelRequestPertemenan.ResumeLayout(false);
            this.panelRequestPertemenan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPertemananTerkirim;
        private System.Windows.Forms.Label labelPertemananMasuk;
        private System.Windows.Forms.Label labelRequestPertemanan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRequestPertemanan;
        private System.Windows.Forms.Panel panelRequestPertemenan;
    }
}
