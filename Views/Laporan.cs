using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7.Views
{
    public partial class Laporan : MetroFramework.Forms.MetroForm
    {

        Config.Connection connection;
        Controllers.Laporan laporan;

        public Laporan()
        {
            InitializeComponent();
            this.connection = Config.Connection.getInstance();
            this.laporan = new Controllers.Laporan();
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            metroComboBox1.Items.Add("Harian");
            metroComboBox1.Items.Add("Bulan");
            metroComboBox1.Items.Add("Tahun");
            metroDateTime1.Format = DateTimePickerFormat.Custom;
            metroDateTime1.CustomFormat = "yyyy-MM-dd";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            getHarian(null);
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void getHarian(string hari)
        {
            dataGridView1.DataSource = this.laporan.SaleReportByDay(hari);
        }private void getBulan(string bulan, string tahun)
        {
            dataGridView1.DataSource = this.laporan.SaleReportByMonth(bulan, tahun);
        }private void getYear(string year)
        {
            dataGridView1.DataSource = this.laporan.SaleReportByYear(year);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(metroComboBox1.SelectedItem.ToString() == "Harian")
            {
                int hari = int.Parse(metroDateTime1.Value.Day.ToString());
                int bulan = int.Parse(metroDateTime1.Value.Month.ToString());
                string konversi = metroDateTime1.Value.Day.ToString();
                string Konversibulan = metroDateTime1.Value.Month.ToString();

                if (hari < 10)
                {
                    konversi = "0" + hari.ToString();
                }
                if (bulan < 10) {
                    Konversibulan = "0" + bulan.ToString();
                }
                string date = metroDateTime1.Value.Year.ToString() + "-" + Konversibulan + "-" + konversi;
                getHarian(date);

            } else if(metroComboBox1.SelectedItem.ToString() == "Bulan")
            {
                string bulan = metroDateTime1.Value.Month.ToString();
                string tahun = metroDateTime1.Value.Year.ToString();
                getBulan(bulan, tahun);
            } else if(metroComboBox1.SelectedItem.ToString() == "Tahun")
            {
                string tahun = metroDateTime1.Value.Year.ToString();
                getYear(tahun);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
