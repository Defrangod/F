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
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetRoleList();
            RoleDataGridView.DataSource = DBConnection.dtRole;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(RoleBox.Text)))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (DBConnection.CheKingAll(RoleBox.Text, "Role", "Role") == true)
                {
                    MessageBox.Show("Такая запись уже есть в базе данных");
                }
                else
                {
                    string addstring = "null,'" + RoleBox.Text + "'";
                    DBConnection.add("role", addstring);
                    DBConnection.GetRoleList();
                    RoleDataGridView.DataSource = DBConnection.dtRole;
                    MessageBox.Show("Запись добавлена");
                    RoleBox.Text = "";
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что вы хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (DBConnection.CheKingAll(RoleDataGridView.CurrentRow.Cells[0].Value.ToString(),"Role","user") == true)
                {
                    MessageBox.Show("Какой то пользователь имеет эту роль, удаление невозможно");
                }
                else
                {

                    DBConnection.Delete("role","ID = '"+ RoleDataGridView.CurrentRow.Cells[0].Value.ToString() +"'");
                    DBConnection.GetRoleList();
                    RoleDataGridView.DataSource = DBConnection.dtRole;
                    MessageBox.Show("Запись удалена");
                }
            }
            else
            {
                MessageBox.Show("Отмена удаления");
            }
        }
    }
}
