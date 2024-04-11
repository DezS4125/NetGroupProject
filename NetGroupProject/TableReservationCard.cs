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
    public partial class TableReservationCard : UserControl
    {
        public int table_id;
        public TableReservationCard(int table_id)
        {
            InitializeComponent();
            this.table_id = table_id;
        }

        private void lblTableName_Click(object sender, EventArgs e)
        {

        }
    }
}
