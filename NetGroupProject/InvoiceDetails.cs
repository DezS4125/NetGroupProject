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
        int selectedRowIndex;
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

        private void dgvInvoiceDetailsList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dgvInvoiceDetailsList.Rows[selectedRowIndex];
            string food_id = selectedRow.Cells["food_id"].Value.ToString();
            string quantity = selectedRow.Cells["quantity"].Value.ToString();
            cbFood.SelectedValue = food_id;
            tbQuantity.Text = quantity;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)dgvInvoiceDetailsList.DataSource;
            DataRow newRow = data.NewRow();
            newRow["food_id"] = cbFood.SelectedValue;
            newRow["food_name"] = cbFood.Text;
            newRow["quantity"] = tbQuantity.Text;
            data.Rows.Add(newRow);
        }
    }
}
