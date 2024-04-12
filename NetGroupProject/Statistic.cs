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
            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            int month = currentDate.Month;
            int day = currentDate.Day;
            tbTodayRevenue.Text = getDayRevenue(year,month,day).ToString();
            tbThisMonthRevenue.Text = getMonthRevenue(year,month).ToString();
            tbThisYearRevenue.Text = getYearRevenue(year).ToString();
            tbSalaryCost.Text = getMonthlySalaryCost().ToString();
        }
        private void initializeRevenueChart()
        {
            Series series = new Series("Revenue");
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
        private decimal getDayRevenue(int year, int month,int day)
        {
            try
            {
                clsDatabase.openConnection();
                SqlCommand com = new SqlCommand("SELECT ISNULL(SUM(total_money), 0) "+
                                            "FROM invoices "+
                                            "WHERE DATEPART(YEAR, invoice_date) = @year " +
                                            "AND DATEPART(MONTH, invoice_date) = @month "+
                                            "And DATEPART(DAY, invoice_date) = @day", clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@year", SqlDbType.Int);
                p1.Value = year;
                com.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@month", SqlDbType.Int);
                p2.Value = month;
                com.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@day", SqlDbType.Int);
                p3.Value = day;
                com.Parameters.Add(p3);
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

        private decimal getYearRevenue(int year)
        {
            try
            {
                clsDatabase.openConnection();
                SqlCommand com = new SqlCommand("SELECT ISNULL(SUM(total_money), 0) " +
                                            "FROM invoices " +
                                            "WHERE DATEPART(YEAR, invoice_date) = @year", clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@year", SqlDbType.Int);
                p1.Value = year;
                com.Parameters.Add(p1);
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
        private int getMonthlySalaryCost()
        {
            try
            {
                clsDatabase.openConnection();
                SqlCommand com = new SqlCommand("SELECT ISNULL(SUM(salary), 0) " +
                                            "FROM users ", clsDatabase.con);
                int sum = Convert.ToInt32(com.ExecuteScalar());
                clsDatabase.closeConnection();
                return sum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            return -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
