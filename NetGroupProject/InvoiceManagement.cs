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
    public partial class InvoiceManagement : Form
    {
        string invoice_id;
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
                    "SELECT invoice_id, u.user_name, invoice_date, d.table_name, total_money " +
                    "FROM invoices AS i " +
                    "JOIN users AS u ON i.user_id = u.user_id " +
                    "JOIN dining_tables AS d ON i.table_id = d.table_id",
                    clsDatabase.con
                );

                SqlDataReader reader = com.ExecuteReader();
                DataTable datatable = new DataTable();
                datatable.Load(reader);

                dgvInvoiceList.DataSource = datatable;

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

        }
    }
}
