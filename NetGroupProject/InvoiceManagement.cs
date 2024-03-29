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
        public InvoiceManagement()
        {
            InitializeComponent();
            initialize_invoice_list();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void initialize_invoice_list()
        {
            try
            {
                clsDatabase.openConnection();
                SqlCommand com = new SqlCommand("\r\nselect invoice_id,user_name, invoice_date,table_name,total_money from invoices as i\r\n\tjoin users as u on i.user_id = u.user_id\r\n\tjoin dining_tables as d on i.table_id = d.table_id", clsDatabase.con);
                SqlDataReader reader = com.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvInvoiceList.DataSource = dataTable;
                dgvInvoiceList.Columns["invoice_id"].HeaderText = "Invoice ID";
                dgvInvoiceList.Columns["invoice_id"].Width = 80;
                dgvInvoiceList.Columns["user_name"].HeaderText = "Employee Name";
                dgvInvoiceList.Columns["user_name"].Width = 120;
                dgvInvoiceList.Columns["invoice_date"].HeaderText = "Date";
                dgvInvoiceList.Columns["invoice_date"].Width = 120;
                dgvInvoiceList.Columns["table_name"].HeaderText = "Table Name";
                dgvInvoiceList.Columns["table_name"].Width = 90;
                dgvInvoiceList.Columns["total_money"].HeaderText = "Total Money";
                reader.Close();
                clsDatabase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
