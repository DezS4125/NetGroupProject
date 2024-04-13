using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NetGroupProject
{
    public partial class InvoiceManagement : Form
    {
        DataTable dataTableInvoiceDetails;
        public InvoiceManagement()
        {
            InitializeComponent();
            initialize_invoice_list();
        }


        private void btnNewInvoiceClick(object sender, EventArgs e)
        {
            try
            {
                clearAllBox();
                clsDatabase.openConnection();

                SqlCommand com = new SqlCommand(
                    "SELECT max(invoice_id)+1 from invoices",
                    clsDatabase.con
                );

                tbInvoiceID.Text = com.ExecuteScalar().ToString();

                clsDatabase.closeConnection();
                btnAddInvoice.Enabled = true;
                btnUpdateInvoice.Enabled = false;
                btnNewInvoice.Enabled = false;
                btnDelete.Enabled = false;
                collectInvoiceDetailsByIds(Convert.ToInt32(tbInvoiceID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void clearAllBox()
        {
            tbInvoiceID.Clear();
            tbTotalMoney.Clear();
            dtpInvoiceDate.Value = DateTime.Now;
            cbUser.SelectedIndex = -1;
            cbTable.SelectedIndex = -1;
        }
        private void initialize_invoice_list()
        {
            try
            {
                clsDatabase.openConnection();

                SqlCommand com = new SqlCommand(
                    "SELECT invoice_id, u.user_id, u.user_name, invoice_date, d.table_id, d.table_name, total_money " +
                    "FROM invoices AS i " +
                    "JOIN users AS u ON i.user_id = u.user_id " +
                    "JOIN dining_tables AS d ON i.table_id = d.table_id",
                    clsDatabase.con
                );

                SqlDataReader reader = com.ExecuteReader();
                DataTable datatable = new DataTable();
                datatable.Load(reader);

                dgvInvoiceList.DataSource = datatable;
                dgvInvoiceList.Columns["user_id"].Visible = false;
                dgvInvoiceList.Columns["table_id"].Visible = false;

                dgvInvoiceList.Columns["invoice_id"].HeaderText = "Invoice ID";
                dgvInvoiceList.Columns["user_name"].HeaderText = "Employee name";
                dgvInvoiceList.Columns["invoice_date"].HeaderText = "Date";
                dgvInvoiceList.Columns["table_name"].HeaderText = "Table Name";
                dgvInvoiceList.Columns["total_money"].HeaderText = "Total Money";

                clsDatabase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvInvoiceList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvInvoiceList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdate_click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "UPDATE invoices SET user_id = @user_id," +
                                "invoice_date=@invoice_date," +
                                "table_id=@table_id," +
                                "total_money=@total_money " +
                                "WHERE invoice_id = @invoice_id";
                clsDatabase.openConnection();
                SqlCommand con = new SqlCommand(strInsert, clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@invoice_date", SqlDbType.SmallDateTime);
                p1.Value = dtpInvoiceDate.Value;
                SqlParameter p2 = new SqlParameter("@user_id", SqlDbType.Int);
                p2.Value = cbUser.SelectedValue;
                SqlParameter p3 = new SqlParameter("@table_id", SqlDbType.Int);
                p3.Value = cbTable.SelectedValue;
                SqlParameter p4 = new SqlParameter("@total_money", SqlDbType.Money);
                p4.Value = tbTotalMoney.Text;
                SqlParameter p5 = new SqlParameter("@invoice_id", SqlDbType.Int);
                p5.Value = tbInvoiceID.Text;

                con.Parameters.Add(p1);
                con.Parameters.Add(p2);
                con.Parameters.Add(p3);
                con.Parameters.Add(p4);
                con.Parameters.Add(p5);
                con.ExecuteNonQuery();
                MessageBox.Show("Edited successfully!!!");
                clsDatabase.closeConnection();
                btnUpdateInvoice.Enabled = false;
                initialize_invoice_list();
                addOrUpdateInvoiceDetail();
                clearAllBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void InvoiceManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablesTable.dining_tables' table. You can move, or remove it, as needed.
            this.dining_tablesTableAdapter.Fill(this.tablesTable.dining_tables);
            // TODO: This line of code loads data into the 'usersTable.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersTable.users);
            // TODO: This line of code loads data into the 'groupProjectDataSet.invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.groupProjectDataSet.invoices);

        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "insert into invoices(invoice_date, user_id, table_id, total_money) values (@invoice_date, @user_id, @table_id, @total_money)";
                clsDatabase.openConnection();
                SqlCommand con = new SqlCommand(strInsert, clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@invoice_date", SqlDbType.SmallDateTime);
                p1.Value = dtpInvoiceDate.Value;
                SqlParameter p2 = new SqlParameter("@user_id", SqlDbType.Int);
                p2.Value = cbUser.SelectedValue;
                SqlParameter p3 = new SqlParameter("@table_id", SqlDbType.Int);
                p3.Value = cbTable.SelectedValue;
                SqlParameter p4 = new SqlParameter("@total_money", SqlDbType.Money);
                p4.Value = tbTotalMoney.Text;

                con.Parameters.Add(p1);
                con.Parameters.Add(p2);
                con.Parameters.Add(p3);
                con.Parameters.Add(p4);
                con.ExecuteNonQuery();
                MessageBox.Show("Insert successfully!!!");
                clsDatabase.closeConnection();
                btnAddInvoice.Enabled = false;
                btnNewInvoice.Enabled = true;
                initialize_invoice_list();
                addOrUpdateInvoiceDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInvoiceList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dgvInvoiceList.Rows[selectedRowIndex];
            string invoiceID = selectedRow.Cells["invoice_id"].Value.ToString();
            string userID = selectedRow.Cells["user_id"].Value.ToString();
            DateTime invoiceDate = Convert.ToDateTime(selectedRow.Cells["invoice_date"].Value);
            string tableID = selectedRow.Cells["table_id"].Value.ToString();
            string totalMoney = selectedRow.Cells["total_money"].Value.ToString();
            tbInvoiceID.Text = invoiceID;
            dtpInvoiceDate.Value= invoiceDate;
            cbUser.SelectedValue= userID;
            cbTable.SelectedValue= tableID;
            tbTotalMoney.Text = totalMoney;
            btnUpdateInvoice.Enabled = true;
            btnAddInvoice.Enabled = false;
            btnDelete.Enabled = true;
            btnNewInvoice.Enabled = true;
            collectInvoiceDetailsByIds(Convert.ToInt32(invoiceID));
            //MessageBox.Show(dataTableInvoiceDetails.Rows.Count + " rows found in the DataTable.");

        }
        private void collectInvoiceDetailsByIds(int invoiceID)
        {
            try
            {
                clsDatabase.openConnection();

                SqlCommand com = new SqlCommand(
                    "SELECT i.food_id, food_name, quantity " +
                    "FROM invoice_details AS i " +
                    "JOIN foods AS f on  i.food_id = f.food_id " +
                    "where invoice_id=@invoice_id",
                    clsDatabase.con
                );
                SqlParameter p1 = new SqlParameter("@invoice_id", SqlDbType.Int);
                p1.Value = invoiceID;

                com.Parameters.Add(p1);

                SqlDataReader reader = com.ExecuteReader();
                this.dataTableInvoiceDetails = new DataTable();
                this.dataTableInvoiceDetails.Load(reader);
                clsDatabase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "DELETE FROM invoices WHERE invoice_id = @invoice_id";
                clsDatabase.openConnection();
                SqlCommand con = new SqlCommand(strInsert, clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@invoice_id", SqlDbType.Int);
                p1.Value = tbInvoiceID.Text;
                con.Parameters.Add(p1);
                con.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!!!");
                clsDatabase.closeConnection();
                btnUpdateInvoice.Enabled = false;
                btnDelete.Enabled = false;
                initialize_invoice_list();
                clearAllBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditInvoiceDetails_Click(object sender, EventArgs e)
        {
            InvoiceDetails invoiceDetailsForm = new InvoiceDetails(dataTableInvoiceDetails);
            invoiceDetailsForm.ShowDialog();
        }
        private void addOrUpdateInvoiceDetail()
        {
            try
            {
                int invoiceId = Convert.ToInt32(tbInvoiceID.Text);
                foreach (DataRow row in dataTableInvoiceDetails.Rows)
                {
                    int foodId = Convert.ToInt32(row["food_id"]);
                    int quantity = Convert.ToInt32(row["quantity"]);
                    string strInsert = "updateOrInsertInvoiceDetails";
                    clsDatabase.openConnection();
                    SqlCommand com = new SqlCommand(strInsert, clsDatabase.con);
                    com.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@invoiceId", SqlDbType.Int);
                    p1.Value = invoiceId;
                    com.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@foodId", SqlDbType.Int);
                    p2.Value = foodId;
                    com.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@quantity", SqlDbType.Int);
                    p3.Value = quantity;
                    com.Parameters.Add(p3);
                    com.ExecuteNonQuery();
                    //MessageBox.Show("Add or update successfully!!!");
                    clsDatabase.closeConnection();

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
