using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NetGroupProject
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
            // Create a Series object and add it to the chart
            Series series = new Series("MyData");
            series.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series);

            // Add data points to the series
            series.Points.AddXY(1, 10);
            series.Points.AddXY(2, 20);
            series.Points.AddXY(3, 30);
            series.Points.AddXY(4, 40);
            series.Points.AddXY(7, 40);

        }
    }
}
