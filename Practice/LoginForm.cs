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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!DBConnection.Connect())
            {
                this.Close();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.Close();
        }

        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            DBConnection.Autorization(LoginBox.Text, PassBox.Text);
            if (DBConnection.Role == null)
            {
                MessageBox.Show("Неверные данные !");
            }
            else
            {
                DBConnection.GetSotrudID(LoginBox.Text);
                this.Hide();
                SelectForm Selfrm = new SelectForm();
                Selfrm.Show();
            }
        }

        private void Login_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z')) e.Handled = true;
        }
    }
}
