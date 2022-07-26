namespace GeckoFXInterceptRequestCaptureResponse
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnFwd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.btnNavigate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelWB = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnFwd,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.txtUrl,
            this.btnNavigate,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = global::GeckoFXInterceptRequestCaptureResponse.Properties.Resources.back;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 22);
            this.btnBack.Text = "toolStripButton2";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.AutoSize = false;
            this.btnFwd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFwd.Image = global::GeckoFXInterceptRequestCaptureResponse.Properties.Resources.fwd;
            this.btnFwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(29, 22);
            this.btnFwd.Text = "toolStripButton3";
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.AutoSize = false;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(220, 25);
            this.txtUrl.Text = "https://example.org";
            // 
            // btnNavigate
            // 
            this.btnNavigate.AutoSize = false;
            this.btnNavigate.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnNavigate.Image = global::GeckoFXInterceptRequestCaptureResponse.Properties.Resources.nav;
            this.btnNavigate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(54, 22);
            this.btnNavigate.Text = "Go";
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelWB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 425);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GeckoFX v60.0.55.0";
            // 
            // panelWB
            // 
            this.panelWB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWB.Location = new System.Drawing.Point(3, 18);
            this.panelWB.Name = "panelWB";
            this.panelWB.Size = new System.Drawing.Size(794, 404);
            this.panelWB.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnFwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtUrl;
        private System.Windows.Forms.ToolStripButton btnNavigate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelWB;
    }
}

