using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            initializeRevenueChart();

        }
        private void initializeRevenueChart()
        {
            Series series = new Series("MyData");
            series.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series);
            DateTime currentDate = DateTime.Now;
            for (int i =11; i>=0; i--)
            {
                int year = currentDate.AddMonths(-i).Year;
                int month = currentDate.AddMonths(-i).Month;

                decimal revenue = getMonthRevenue(year, month);
                string x_axis = year.ToString()+"-"+month.ToString();
                series.Points.AddXY(x_axis, revenue);
            }
        }
        private decimal getMonthRevenue(int year,int month)
        {
            try
            {
                clsDatabase.openConnection();
                SqlCommand com = new SqlCommand("SELECT dbo.GetTotalMoneyForMonth(@year , @month)", clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@year", SqlDbType.Int);
                p1.Value = year;
                com.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@month", SqlDbType.Int);
                p2.Value = month;
                com.Parameters.Add(p2); 
                decimal revenue = Convert.ToDecimal(com.ExecuteScalar());
                clsDatabase.closeConnection();
                return revenue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            return -1;
        }
    }
}
