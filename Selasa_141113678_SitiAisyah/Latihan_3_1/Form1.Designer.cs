namespace Latihan_3_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SizeHuruf = new System.Windows.Forms.ToolStripComboBox();
            this.TblBold = new System.Windows.Forms.ToolStripButton();
            this.TblItalic = new System.Windows.Forms.ToolStripButton();
            this.TblUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.JenisFont = new System.Windows.Forms.ToolStripComboBox();
            this.TblStrip = new System.Windows.Forms.ToolStripButton();
            this.Page = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.SizeHuruf,
            this.TblBold,
            this.TblItalic,
            this.TblUnderline,
            this.toolStripLabel1,
            this.JenisFont,
            this.TblStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(522, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabel2.Text = "Size";
            // 
            // SizeHuruf
            // 
            this.SizeHuruf.DropDownHeight = 200;
            this.SizeHuruf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeHuruf.IntegralHeight = false;
            this.SizeHuruf.Name = "SizeHuruf";
            this.SizeHuruf.Size = new System.Drawing.Size(121, 25);
            this.SizeHuruf.Click += new System.EventHandler(this.SizeHuruf_Click);
            // 
            // TblBold
            // 
            this.TblBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TblBold.Image = ((System.Drawing.Image)(resources.GetObject("TblBold.Image")));
            this.TblBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TblBold.Name = "TblBold";
            this.TblBold.Size = new System.Drawing.Size(23, 22);
            this.TblBold.Click += new System.EventHandler(this.TblBold_Click);
            // 
            // TblItalic
            // 
            this.TblItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TblItalic.Image = ((System.Drawing.Image)(resources.GetObject("TblItalic.Image")));
            this.TblItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TblItalic.Name = "TblItalic";
            this.TblItalic.Size = new System.Drawing.Size(23, 22);
            this.TblItalic.Text = "toolStripButton1";
            this.TblItalic.Click += new System.EventHandler(this.TblItalic_Click);
            // 
            // TblUnderline
            // 
            this.TblUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TblUnderline.Image = ((System.Drawing.Image)(resources.GetObject("TblUnderline.Image")));
            this.TblUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TblUnderline.Name = "TblUnderline";
            this.TblUnderline.Size = new System.Drawing.Size(23, 22);
            this.TblUnderline.Text = "toolStripButton1";
            this.TblUnderline.Click += new System.EventHandler(this.TblUnderline_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "Font";
            // 
            // JenisFont
            // 
            this.JenisFont.DropDownHeight = 200;
            this.JenisFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JenisFont.IntegralHeight = false;
            this.JenisFont.Name = "JenisFont";
            this.JenisFont.Size = new System.Drawing.Size(121, 25);
            this.JenisFont.Click += new System.EventHandler(this.JenisFont_Click);
            // 
            // TblStrip
            // 
            this.TblStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TblStrip.Image = ((System.Drawing.Image)(resources.GetObject("TblStrip.Image")));
            this.TblStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TblStrip.Name = "TblStrip";
            this.TblStrip.Size = new System.Drawing.Size(23, 22);
            this.TblStrip.Text = "toolStripButton1";
            this.TblStrip.Click += new System.EventHandler(this.TblStrip_Click);
            // 
            // Page
            // 
            this.Page.Location = new System.Drawing.Point(0, 28);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(510, 423);
            this.Page.TabIndex = 2;
            this.Page.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 370);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox SizeHuruf;
        private System.Windows.Forms.ToolStripButton TblBold;
        private System.Windows.Forms.ToolStripButton TblItalic;
        private System.Windows.Forms.ToolStripButton TblUnderline;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox JenisFont;
        private System.Windows.Forms.ToolStripButton TblStrip;
        private System.Windows.Forms.RichTextBox Page;
    }
}

