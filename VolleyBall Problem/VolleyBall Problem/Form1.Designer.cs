namespace VolleyBall_Problem
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
            this.Hitung = new System.Windows.Forms.Button();
            this.Hasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Teks2 = new System.Windows.Forms.TextBox();
            this.Teks1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hitung
            // 
            this.Hitung.Location = new System.Drawing.Point(122, 94);
            this.Hitung.Name = "Hitung";
            this.Hitung.Size = new System.Drawing.Size(75, 23);
            this.Hitung.TabIndex = 13;
            this.Hitung.Text = "Hitung";
            this.Hitung.UseVisualStyleBackColor = true;
            this.Hitung.Click += new System.EventHandler(this.Hitung_Click);
            // 
            // Hasil
            // 
            this.Hasil.Enabled = false;
            this.Hasil.Location = new System.Drawing.Point(80, 151);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(167, 20);
            this.Hasil.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hasil";
            // 
            // Teks2
            // 
            this.Teks2.Location = new System.Drawing.Point(80, 57);
            this.Teks2.Name = "Teks2";
            this.Teks2.Size = new System.Drawing.Size(167, 20);
            this.Teks2.TabIndex = 10;
            // 
            // Teks1
            // 
            this.Teks1.Location = new System.Drawing.Point(80, 12);
            this.Teks1.Name = "Teks1";
            this.Teks1.Size = new System.Drawing.Size(167, 20);
            this.Teks1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Skor B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Skor A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 193);
            this.Controls.Add(this.Hitung);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Teks2);
            this.Controls.Add(this.Teks1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hitung;
        private System.Windows.Forms.TextBox Hasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Teks2;
        private System.Windows.Forms.TextBox Teks1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

