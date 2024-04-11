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
                string strInsert = "insert into customer(customer_name, phone, email) values (@customer_name, @user_id, @table_id)";
                clsDatabase.openConnection();
                SqlCommand con = new SqlCommand(strInsert, clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@customer_name", SqlDbType.NVarChar);
                p1.Value = tbCustomerName.Text;
                SqlParameter p2 = new SqlParameter("@phone", SqlDbType.NVarChar);
                p2.Value = tbPhoneNumber.Text;
                SqlParameter p3 = new SqlParameter("@email", SqlDbType.NVarChar);
                p3.Value = tbEmail.Text;
                con.Parameters.Add(p1);
                con.Parameters.Add(p2);
                con.Parameters.Add(p3);
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
