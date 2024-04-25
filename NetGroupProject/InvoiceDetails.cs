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
            tbPrice.Text = findPriceFromFoodID("1").ToString();
            dgvInvoiceDetailsList.Columns["food_name"].HeaderText = "Food Name";
            dgvInvoiceDetailsList.Columns["quantity"].HeaderText = "Quantity";
            dgvInvoiceDetailsList.Columns["food_price"].HeaderText = "Price Per Item";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceDetails_Load(object sender, EventArgs e)
        {
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
            newRow["food_price"] = findPriceFromFoodID(cbFood.SelectedValue.ToString()).ToString();
            data.Rows.Add(newRow);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)dgvInvoiceDetailsList.DataSource;
            DataRow newRow = data.Rows[selectedRowIndex];
            newRow["food_id"] = cbFood.SelectedValue;
            newRow["food_name"] = cbFood.Text;
            newRow["quantity"] = tbQuantity.Text;
            newRow["food_price"] = findPriceFromFoodID(cbFood.SelectedValue.ToString()).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)dgvInvoiceDetailsList.DataSource;
            data.Rows.RemoveAt(selectedRowIndex);
        }
        private decimal findPriceFromFoodID(string foodID)
        {
            try
            {
                clsDatabase.openConnection();
                SqlCommand com = new SqlCommand("SELECT food_price " +
                                            "FROM foods " +
                                            "WHERE food_id = @food_id", clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@food_id", SqlDbType.Int);
                p1.Value = Convert.ToInt32(foodID);
                com.Parameters.Add(p1);
                decimal price = Convert.ToDecimal(com.ExecuteScalar());
                clsDatabase.closeConnection();
                return price;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            return -1;
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            string foodID = cbFood.SelectedValue.ToString();
            tbPrice.Text = findPriceFromFoodID(foodID).ToString();

        }
    }
}
