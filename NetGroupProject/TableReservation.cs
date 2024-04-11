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
    public partial class TableReservation : Form
    {
        public TableReservation()
        {
            InitializeComponent();
            initialize_table_list();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void initialize_table_list()
        {
            try
            {
                clsDatabase.openConnection();

                SqlCommand com = new SqlCommand("select * from dining_tables", clsDatabase.con);
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Label label = new Label();
                    label.Text = reader["table_name"].ToString();
                    flpTableList.Controls.Add(label);
                }

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
