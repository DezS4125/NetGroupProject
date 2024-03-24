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
        public navigationPage(string userID)
        {
            InitializeComponent();
            Log log = new Log(txtLog);
            log.writeLogFile("User ID-"+userID+" logged into the system");
            log.readLogFile();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginPage = new Form1();
            loginPage.ShowDialog();
            this.Close();
        }
    }
}
