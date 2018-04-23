using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace SeriesPointsSorting {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #SeriesPointSorting
        private void Form1_Load(object sender, EventArgs e) {
            this.gSPTableAdapter.Fill(this.gspDataSet.GSP);

            SeriesBase seriesTemplate = chart.SeriesTemplate;
            seriesTemplate.SeriesPointsSorting = SortingMode.Ascending;
            seriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Value_1;
        }
        #endregion #SeriesPointSorting
    }
}
