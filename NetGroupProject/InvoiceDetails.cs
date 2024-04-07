using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetGroupProject
{
    public partial class InvoiceDetails : Form
    {
        public InvoiceDetails()
        {
            InitializeComponent();
        }
        public InvoiceDetails(DataTable data)
        {
            InitializeComponent();
            dgvInvoiceDetailsList.DataSource = data;
            dgvInvoiceDetailsList.Columns["food_id"].Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupProjectDataSet1.foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter.Fill(this.groupProjectDataSet1.foods);

        }
    }
}
