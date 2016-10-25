using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {

                JenisFont.Items.Add(font.Name.ToString());
            }

            for (int i = 2; i <= 115; i += 2)
            {
                SizeHuruf.Items.Add(i);

            }
            SizeHuruf.SelectedIndex = 5;
            JenisFont.Text = "Times New Roman";
        }

        private void TblBold_Click(object sender, EventArgs e)
        {
            Font Bold, NonBold;
            NonBold = Page.SelectionFont;
            if (NonBold.Bold)
            {
                Bold = new Font(NonBold, NonBold.Style & ~FontStyle.Bold);
                TblBold.Checked = false;
            }
            else
            {
                Bold = new Font(NonBold, NonBold.Style | FontStyle.Bold);
                TblBold.Checked = true;
            }
            Page.SelectionFont = Bold;
        }

        private void TblItalic_Click(object sender, EventArgs e)
        {
            Font Italic, NonItalic;
            NonItalic = Page.SelectionFont;
            if (NonItalic.Italic)
            {
                Italic = new Font(NonItalic, NonItalic.Style & ~FontStyle.Italic);
                TblItalic.Checked = false;
            }
            else
            {
                Italic = new Font(NonItalic, NonItalic.Style | FontStyle.Italic);
                TblItalic.Checked = true;
            }
            Page.SelectionFont = Italic;
        }

        private void TblStrip_Click(object sender, EventArgs e)
        {
            var Warna = new ColorDialog();
            Warna.ShowDialog();
            Page.ForeColor = Warna.Color;
        }

        private void SizeHuruf_Click(object sender, EventArgs e)
        {
            Page.Font = new Font(Page.Font.FontFamily, float.Parse(SizeHuruf.SelectedItem.ToString()));
        }

        private void JenisFont_Click(object sender, EventArgs e)
        {
            Page.Font = new Font(JenisFont.SelectedItem.ToString(), Page.Font.Size);
        }

        private void TblUnderline_Click(object sender, EventArgs e)
        {
            Font UnderLine, NonUnderline;
            NonUnderline = Page.SelectionFont;
            if (NonUnderline.Underline)
            {
                UnderLine = new Font(NonUnderline, NonUnderline.Style & ~FontStyle.Underline);
                TblUnderline.Checked = false;
            }
            else
            {
                UnderLine = new Font(NonUnderline, NonUnderline.Style | FontStyle.Underline);
                TblUnderline.Checked = true;
            }
            Page.SelectionFont = UnderLine;
        }
    }
}
