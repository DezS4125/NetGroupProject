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
    public partial class Menu_management : Form
    {


        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP;Initial Catalog=NetGroup;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from  menus";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataview.DataSource = table;
        }


        public Menu_management()
        {
            InitializeComponent();
        }

        private void Menu_management_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataview.CurrentRow.Index;
            menu_id.Text = dataview.Rows[i].Cells[0].Value.ToString();
            menu_name.Text = dataview.Rows[i].Cells[1].Value.ToString();
            created_date.Text = dataview.Rows[i].Cells[2].Value.ToString();
            description.Text = dataview.Rows[i].Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into menus values('" + menu_name.Text + "', '"
                                                               + created_date.Text + "', '"
                                                               + description.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update menus set menu_name = '" + menu_name.Text +
                                                                "', created_date = '" + created_date.Text +
                                                                "', menu_description = '" + description.Text +
                                                                "' where menu_id = '" + menu_id.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from menus where menu_id = '" + menu_id.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            menu_id.Text = "";
            menu_name.Text = "";
            description.Text = "";
        }
    }
}
