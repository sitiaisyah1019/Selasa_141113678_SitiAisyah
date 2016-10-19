using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DateTime now = DateTime.Now;

        private void vertikalmin_Scroll(object sender, ScrollEventArgs e)
        {
            teks1.Text = (vertikalmin.Maximum - vertikalmin.Value).ToString();
            if (vertikalmax.Value > vertikalmin.Value)
            {
                vertikalmax.Value = vertikalmin.Value;
                teks1.Text = (vertikalmax.Maximum - vertikalmax.Value).ToString();
            }
            tanggal.MinDate = now.AddYears(vertikalmax.Value - vertikalmax.Maximum);
            tanggal.MaxDate = now.AddYears(vertikalmin.Value - vertikalmin.Maximum);
        }

        private void teks2_Click(object sender, EventArgs e)
        {

        }

        private void vertikalmax_Scroll(object sender, ScrollEventArgs e)
        {
            teks2.Text = (vertikalmax.Maximum - vertikalmax.Value).ToString();
            if (vertikalmax.Value > vertikalmin.Value)
            {
                vertikalmin.Value = vertikalmax.Value;
                teks1.Text = (vertikalmin.Maximum - vertikalmin.Value).ToString();
            }
            tanggal.MaxDate = now.AddYears(vertikalmin.Value - vertikalmin.Maximum);
            tanggal.MinDate = now.AddYears(vertikalmax.Value - vertikalmax.Maximum);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            tanggal.MaxDate = now.AddYears(vertikalmin.Value - vertikalmin.Maximum);
            tanggal.MinDate = now.AddYears(vertikalmax.Value - vertikalmax.Maximum);
        }

    }
}
