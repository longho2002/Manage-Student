using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace QL_Sinh_Vien
{
    public partial class Chart : Form
    {
        public double m;
        public double f;
        
        public Chart()
        {
            InitializeComponent();
            
        }

        private void test_Load(object sender, EventArgs e)
        {
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Male",
                    Values = new ChartValues<double> {m},
                    DataLabels = true,
                },
                new PieSeries
                {
                    Title = "Female",
                    Values = new ChartValues<double> {f},
                    DataLabels = true,
                },
            };
            pieChart1.LegendLocation = LegendLocation.Right;
        }
    }
}
