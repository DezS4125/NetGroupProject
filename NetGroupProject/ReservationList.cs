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
                    "select reservation_id, user_name, customer_name, phone, c.email, reservation_date, reservation_duration " +
                    "from table_reservation as t " +
                    "join users as u on t.user_id = u.user_id " +
                    "join customer as c on t.customer_id = c.customer_id "+
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
    }
}
