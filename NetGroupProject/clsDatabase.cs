using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetGroupProject
{

    class clsDatabase
    {
        public static SqlConnection con;
        public static bool openConnection()
        {
            try
            {
                con = new SqlConnection("Server=P206M10\\SQLEXPRESS; Database=groupProject;User Id=mylogin;password=mylogin");
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
        public static bool closeConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
