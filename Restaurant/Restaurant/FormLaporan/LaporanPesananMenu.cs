using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.FormLaporan
{
    public partial class LaporanPesananMenu : Form
    {
        private string[] temp = new string[2];

        public LaporanPesananMenu()
        {
            InitializeComponent();
            string tanggalHariIni = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime tanggalHari = DateTime.ParseExact(tanggalHariIni, "dd/MM/yyyy", null);

            temp[0] = tanggalHari.Month.ToString();
            temp[1] = tanggalHari.Year.ToString();

            reportViewer1.LocalReport.SetParameters(new ReportParameter("bulan", temp[0]));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("tahun", temp[1]));
        }

        private void LaporanPesananMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_RestaurantDataSet.tr_pesanan' table. You can move, or remove it, as needed.
            //this.tr_pesananTableAdapter.Fill(this.dB_RestaurantDataSet.tr_pesanan, );
            // TODO: This line of code loads data into the 'dB_RestaurantDataSet1.ms_menu' table. You can move, or remove it, as needed.
            //this.ms_menuTableAdapter.Fill(this.dB_RestaurantDataSet1.ms_menu);

            this.reportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tglAwal = dtAwal.Value.ToString("yyyy-MM-dd");
            string tglAkhir = dtAkhir.Value.ToString("yyyy-MM-dd");

            this.tr_pesananTableAdapter.Fill(dB_RestaurantDataSet.tr_pesanan, tglAwal, tglAkhir);

            this.reportViewer1.RefreshReport();
        }
    }
}
