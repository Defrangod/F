using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class AccountingForm : Form
    {
        public AccountingForm()
        {
            InitializeComponent();
        }

        private void AccountingForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetAccountingList();
            AccountingDataGridView.DataSource = DBConnection.dtAccounting;
        }
    }
}
