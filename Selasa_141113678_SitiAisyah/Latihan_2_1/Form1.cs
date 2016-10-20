using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bulan.SelectedItem = "April";

            DateTime awal = new DateTime(2010, 1, 1);
            DateTime akhir = new DateTime(2018, 12, 31);
            TimeSpan jarak = akhir - awal;
            int hari = jarak.Days;
            for (var i = 0; i <= hari; i++)
            {
                var bold = awal.AddDays(i);
                switch (bold.DayOfWeek)
                {
                    case DayOfWeek.Wednesday:
                        kalender.AddBoldedDate(bold);
                        break;
                    case DayOfWeek.Thursday:
                        kalender.AddBoldedDate(bold);
                        break;
                }

            }
            kalender.AddAnnuallyBoldedDate(new DateTime(1996, 04, 05));
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            kalender.AddAnnuallyBoldedDate(new DateTime(2016, bulan.SelectedIndex + 1, Convert.ToInt32(tanggal.Value)));
            kalender.UpdateBoldedDates();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            kalender.RemoveAnnuallyBoldedDate(new DateTime(2016, bulan.SelectedIndex + 1, Convert.ToInt32(tanggal.Value)));
            kalender.UpdateBoldedDates();
        }

        private void bulan_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
