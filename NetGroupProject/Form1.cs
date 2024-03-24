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
    public partial class Form1 : Form
    {
        string userID;
        string password;
        public Form1()
        {
            InitializeComponent();
            userID = txtUserID.Text; 
            password=txtPassword.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userID))
            {
                MessageBox.Show("UserID can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                clsDatabase.openConnection();
                SqlCommand com = new SqlCommand("SELECT dbo.validateLogin(@input_id , @input_password)", clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@input_id", SqlDbType.Int);
                p1.Value = Convert.ToInt32(userID);
                com.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@input_password", SqlDbType.NVarChar);
                p2.Value = password;
                com.Parameters.Add(p2);
                bool result = (bool)com.ExecuteScalar();
                clsDatabase.closeConnection();
                if (result)
                {
                    MessageBox.Show("Login successful!","Success!", MessageBoxButtons.OK);
                    //  this.Hide();
                    //  FormPersonalPage personalpage = new FormPersonalPage(staff_id);
                    //  personalpage.ShowDialog();
                    //  this.Close();
                }
                if (!result)
                {
                    MessageBox.Show("Either username or password is wrong", "Failure!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            userID=txtUserID.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password=txtPassword.Text;
        }
    }
}
