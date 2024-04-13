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

namespace NetGroupProject
{
    public partial class navigationPage : Form
    {
        Log log;
        string userID;
        public navigationPage(string userID)
        {
            InitializeComponent();
            log = new Log(txtLog);
            this.userID = userID;
            log.writeAndUpdate("User ID-"+userID+" logged into the system");

            clsDatabase.openConnection();
            SqlCommand com = new SqlCommand("select user_name from users where user_id=@user_id", clsDatabase.con);
            SqlParameter p1 = new SqlParameter("@user_id", SqlDbType.Int);
            p1.Value = Convert.ToInt32(this.userID);
            com.Parameters.Add(p1);
            lblWelcome.Text = "Welcome back, " + (string)com.ExecuteScalar();
            clsDatabase.closeConnection();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            log.writeLogFile("User ID-" + userID + " logged into the system");
            this.Hide();
            Form1 loginPage = new Form1();
            loginPage.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnInvoiceManagement_Click(object sender, EventArgs e)
        {
            InvoiceManagement invoiceManagementPage = new InvoiceManagement(userID);
            invoiceManagementPage.ShowDialog();
        }

        private void btnTableReservation_Click(object sender, EventArgs e)
        {
            TableReservation tableReservationPage = new TableReservation(userID);
            tableReservationPage.ShowDialog();
        }

        private void btnRevenueStatistic_Click(object sender, EventArgs e)
        {
            Statistic statisticPage = new Statistic();
            statisticPage.ShowDialog();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            User_Management user_Management_form = new User_Management();
            user_Management_form.ShowDialog();
        }
    }
}
