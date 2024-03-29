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
                SqlCommand com = new SqlCommand("SELECT * from invoices", clsDatabase.con);
                SqlDataReader reader = com.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvInvoiceList.DataSource = dataTable;
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
