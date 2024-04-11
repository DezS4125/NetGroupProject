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
    public partial class User_Management : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP;Initial Catalog=NetGroup;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from  users";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataview.DataSource = table;
        }

        public User_Management()
        {
            InitializeComponent();
        }

        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataview.CurrentRow.Index;     
            user_id.Text = dataview.Rows[i].Cells[0].Value.ToString();
            name.Text = dataview.Rows[i].Cells[1].Value.ToString();
            address.Text = dataview.Rows[i].Cells[2].Value.ToString();
            phone.Text = dataview.Rows[i].Cells[3].Value.ToString();
            email.Text = dataview.Rows[i].Cells[4].Value.ToString();
            pass.Text = dataview.Rows[i].Cells[5].Value.ToString();
            salary.Text = dataview.Rows[i].Cells[6].Value.ToString();
            position.Text = dataview.Rows[i].Cells[7].Value.ToString();

        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into users values('" + name.Text + "', '" 
                                                               + address.Text + "', '" 
                                                               + phone.Text + "', '" 
                                                               + email.Text + "', '" 
                                                               + pass.Text + "', '"
                                                               + salary.Text + "', '"
                                                               + position.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update users set user_name = '" +name.Text+ 
                                                                "', user_address = '" + address.Text + 
                                                                "', phone_number = '" + phone.Text + 
                                                                "', email = '" + email.Text + 
                                                                "', password = '" + pass.Text + 
                                                                "', salary = " + salary.Text + 
                                                                ", position_id = '" + position.Text + 
                                                                "' where user_id = '" + user_id.Text + "'";


            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from users where user_id = '" + user_id.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            position.Text = "";
            user_id.Text = "";
            name.Text = "";
            address.Text = "";
            phone.Text = "";
            email.Text = "";
            pass.Text = "";
            salary.Text = "";
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
