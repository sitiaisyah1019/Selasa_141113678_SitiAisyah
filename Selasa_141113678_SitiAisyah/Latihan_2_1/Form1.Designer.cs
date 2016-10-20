namespace Latihan_2_1
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
            this.bulan = new System.Windows.Forms.DomainUpDown();
            this.tanggal = new System.Windows.Forms.NumericUpDown();
            this.hapus = new System.Windows.Forms.Button();
            this.tambah = new System.Windows.Forms.Button();
            this.kalender = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.tanggal)).BeginInit();
            this.SuspendLayout();
            // 
            // bulan
            // 
            this.bulan.Items.Add("Januari");
            this.bulan.Items.Add("Februari");
            this.bulan.Items.Add("Maret");
            this.bulan.Items.Add("April");
            this.bulan.Items.Add("Mei");
            this.bulan.Items.Add("Juni");
            this.bulan.Items.Add("Juli");
            this.bulan.Items.Add("Agustus");
            this.bulan.Items.Add("September");
            this.bulan.Items.Add("Oktober");
            this.bulan.Items.Add("November");
            this.bulan.Items.Add("Desember");
            this.bulan.Location = new System.Drawing.Point(181, 22);
            this.bulan.Name = "bulan";
            this.bulan.Size = new System.Drawing.Size(120, 20);
            this.bulan.TabIndex = 11;
            this.bulan.SelectedItemChanged += new System.EventHandler(this.bulan_SelectedItemChanged);
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(9, 22);
            this.tanggal.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.tanggal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(120, 20);
            this.tanggal.TabIndex = 7;
            this.tanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(630, 16);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(75, 23);
            this.hapus.TabIndex = 10;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(521, 16);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 23);
            this.tambah.TabIndex = 10;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // kalender
            // 
            this.kalender.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.kalender.Location = new System.Drawing.Point(9, 63);
            this.kalender.Name = "kalender";
            this.kalender.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 389);
            this.Controls.Add(this.bulan);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.kalender);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tanggal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown bulan;
        private System.Windows.Forms.NumericUpDown tanggal;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.MonthCalendar kalender;
    }
}

