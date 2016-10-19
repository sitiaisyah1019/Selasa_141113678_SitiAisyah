namespace Latihan_1_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.teks2 = new System.Windows.Forms.Label();
            this.teks1 = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.vertikalmax = new System.Windows.Forms.VScrollBar();
            this.vertikalmin = new System.Windows.Forms.VScrollBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 366);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.teks2);
            this.tabPage1.Controls.Add(this.teks1);
            this.tabPage1.Controls.Add(this.tanggal);
            this.tabPage1.Controls.Add(this.vertikalmax);
            this.tabPage1.Controls.Add(this.vertikalmin);
            this.tabPage1.ImageKey = "di7o9Er6T.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(397, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // teks2
            // 
            this.teks2.AutoSize = true;
            this.teks2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teks2.Location = new System.Drawing.Point(319, 304);
            this.teks2.Name = "teks2";
            this.teks2.Size = new System.Drawing.Size(40, 18);
            this.teks2.TabIndex = 4;
            this.teks2.Text = "MAX";
            this.teks2.Click += new System.EventHandler(this.teks2_Click);
            // 
            // teks1
            // 
            this.teks1.AutoSize = true;
            this.teks1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teks1.Location = new System.Drawing.Point(29, 304);
            this.teks1.Name = "teks1";
            this.teks1.Size = new System.Drawing.Size(35, 18);
            this.teks1.TabIndex = 3;
            this.teks1.Text = "MIN";
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(98, 46);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(200, 20);
            this.tanggal.TabIndex = 2;
            // 
            // vertikalmax
            // 
            this.vertikalmax.LargeChange = 1;
            this.vertikalmax.Location = new System.Drawing.Point(329, 46);
            this.vertikalmax.Maximum = 10;
            this.vertikalmax.Name = "vertikalmax";
            this.vertikalmax.Size = new System.Drawing.Size(25, 240);
            this.vertikalmax.TabIndex = 1;
            this.vertikalmax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vertikalmax_Scroll);
            // 
            // vertikalmin
            // 
            this.vertikalmin.LargeChange = 1;
            this.vertikalmin.Location = new System.Drawing.Point(38, 46);
            this.vertikalmin.Maximum = 10;
            this.vertikalmin.Name = "vertikalmin";
            this.vertikalmin.Size = new System.Drawing.Size(25, 240);
            this.vertikalmin.TabIndex = 0;
            this.vertikalmin.Value = 10;
            this.vertikalmin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vertikalmin_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "play-icon.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Music";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "play-icon.png");
            this.imageList1.Images.SetKeyName(1, "di7o9Er6T.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 394);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label teks2;
        private System.Windows.Forms.Label teks1;
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.VScrollBar vertikalmax;
        private System.Windows.Forms.VScrollBar vertikalmin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

