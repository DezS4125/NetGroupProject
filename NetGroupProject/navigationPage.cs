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
    public partial class navigationPage : Form
    {
        Log log;
        string userID;
        public navigationPage(string userID)
        {
            InitializeComponent();
            log = new Log(txtLog);
            this.userID = userID;
            log.writeAndUpdate("User ID-"+userID+" logged into the system");
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            log.writeLogFile("User ID-" + userID + " logged into the system");
            this.Hide();
            Form1 loginPage = new Form1();
            loginPage.ShowDialog();
            this.Close();
        }
    }
}
