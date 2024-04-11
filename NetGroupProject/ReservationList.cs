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
    public partial class ReservationList : Form
    {
        int tableID;
        string userID;
        public ReservationList(int tableID, string userID)
        {
            InitializeComponent();
            this.tableID = tableID;
            this.userID = userID;
            initialize_reservation_list();
        }
        private void initialize_reservation_list()
        {
            try
            {
                clsDatabase.openConnection();

                SqlCommand com = new SqlCommand(
                    "select reservation_id, user_name, customer_name, phone, t.email, reservation_date, reservation_duration " +
                    "from table_reservation as t " +
                    "join users as u on t.user_id = u.user_id " +
                    "where table_id=@tableID",
                    clsDatabase.con
                );
                SqlParameter p1 = new SqlParameter("@tableID", SqlDbType.Int);
                p1.Value = tableID;
                com.Parameters.Add(p1);

                SqlDataReader reader = com.ExecuteReader();
                DataTable datatable = new DataTable();
                datatable.Load(reader);

                dgvReservationList.DataSource = datatable;
                clsDatabase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void clearAllBox()
        {
            tbReservationID.Clear();
            tbCustomerName.Clear();
            tbPhoneNumber.Clear();
            tbEmail.Clear();
            dtpDate.Value = DateTime.Now;
            nupDuration.Value = 2;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                clearAllBox();
                clsDatabase.openConnection();

                SqlCommand com = new SqlCommand(
                    "SELECT max(reservation_id)+1 from table_reservation",
                    clsDatabase.con
                );

                tbReservationID.Text = com.ExecuteScalar().ToString();

                clsDatabase.closeConnection();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvReservationList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string strInsert = "insert into table_reservation(user_id, customer_name, phone, email, table_id, reservation_date, reservation_duration) " +
                                    "values (@user_id, @customer_name, @phone, @email, @table_id, @reservation_date, @reservation_duration)";
                clsDatabase.openConnection();
                SqlCommand con = new SqlCommand(strInsert, clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@user_id", SqlDbType.Int);
                p1.Value = Convert.ToInt32(userID);
                SqlParameter p2 = new SqlParameter("@customer_name", SqlDbType.NVarChar);
                p2.Value = tbCustomerName.Text;
                SqlParameter p3 = new SqlParameter("@phone", SqlDbType.NVarChar);
                p3.Value = tbPhoneNumber.Text;
                SqlParameter p4 = new SqlParameter("@email", SqlDbType.NVarChar);
                p4.Value = tbEmail.Text;
                SqlParameter p5 = new SqlParameter("@table_id", SqlDbType.Int);
                p5.Value = tableID;
                SqlParameter p6 = new SqlParameter("@reservation_date", SqlDbType.SmallDateTime);
                p6.Value = dtpDate.Value;
                SqlParameter p7 = new SqlParameter("@reservation_duration", SqlDbType.Int);
                p7.Value = nupDuration.Value;
                con.Parameters.Add(p1);
                con.Parameters.Add(p2);
                con.Parameters.Add(p3);
                con.Parameters.Add(p4);
                con.Parameters.Add(p5);
                con.Parameters.Add(p6);
                con.Parameters.Add(p7);
                con.ExecuteNonQuery();

                MessageBox.Show("Insert successfully!!!");
                clsDatabase.closeConnection();
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                initialize_reservation_list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
