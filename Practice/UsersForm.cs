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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        string IDs;
        string LoginB;
        private void Users_Load(object sender, EventArgs e)
        {
            //загрузка таблиц
            DBConnection.GetUserList();
            DBConnection.GetRoleList();
            //заполнение таблицы пользователей
            UsersDataGridView.DataSource = DBConnection.dtUsers;
            //Заполнение списка ролей в Combobox
            RoleComboBox.DataSource = DBConnection.dtRole;
            RoleComboBox.DisplayMember = "Role";
            RoleComboBox.ValueMember = "ID";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(LoginBox.Text)) || (string.IsNullOrWhiteSpace(PassBox.Text)) || (string.IsNullOrWhiteSpace(RoleComboBox.SelectedValue.ToString())))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (DBConnection.CheKingAll(LoginBox.Text,"login","user") == true)
                {
                    MessageBox.Show("дублируется логин");
                }
                else
                {
                    //добавление записи
                    string addstring = "null," + LoginBox.Text + "," + PassBox.Text + ",'" +RoleComboBox.SelectedValue.ToString() + "'";
                    DBConnection.add("user",addstring);
                    MessageBox.Show("Запись добавлена");
                    //обновление таблицы
                    DBConnection.GetUserList();
                    UsersDataGridView.DataSource = DBConnection.dtUsers;
                    //опустошение боксов
                    LoginBox.Text = "";
                    PassBox.Text = "";


                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //Настройка кнопок
            DeleteButton.Enabled = false;
            SaveButton.Visible = true;
            CancelButton.Visible = true;
            //Перенос записи из таблицы
            IDs = UsersDataGridView.CurrentRow.Cells[0].Value.ToString();
            LoginBox.Text = UsersDataGridView.CurrentRow.Cells[1].Value.ToString();
            LoginB = UsersDataGridView.CurrentRow.Cells[1].Value.ToString();
            PassBox.Text = UsersDataGridView.CurrentRow.Cells[2].Value.ToString();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что вы хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (DBConnection.CheKingAll(UsersDataGridView.CurrentRow.Cells[0].Value.ToString(), "User", "sotrud") == true)
                {
                    MessageBox.Show("Пользователь привязан к сотруднику, удаление невозможно");
                }
                else
                {
                    string table = "user";
                    string deletestring = "ID='" + UsersDataGridView.CurrentRow.Cells[0].Value.ToString() + "'";
                    DBConnection.Delete(table, deletestring);
                    MessageBox.Show("Запись удалена");

                    DBConnection.GetUserList();
                    UsersDataGridView.DataSource = DBConnection.dtUsers;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Опустошение боксов и переменных
            LoginBox.Text = "";
            PassBox.Text = "";
            IDs = "";
            LoginB = "";
            //Настройка кнопок
            DeleteButton.Enabled = true;
            SaveButton.Visible = false;
            CancelButton.Visible = false;
            MessageBox.Show("Изменения отменены");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(LoginBox.Text)) || (string.IsNullOrWhiteSpace(PassBox.Text)) || (string.IsNullOrWhiteSpace(RoleComboBox.SelectedValue.ToString())))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                //Проверка логина на дублирование
                if (DBConnection.CheKingAll(LoginBox.Text, "login", "user") == true && LoginBox.Text != LoginB)
                {
                    MessageBox.Show("дублируется логин");
                }
                else
                {
                    //Изменение записи
                    string EditString = "Login = '" + LoginBox.Text + "', Password = '" + PassBox.Text + "', Role = '" + RoleComboBox.SelectedValue.ToString() + "' Where ID = '" + IDs + "'";
                    DBConnection.Edit("user",EditString);
                    MessageBox.Show("Запись изменена");
                    //обновление таблицы
                    DBConnection.GetUserList();
                    UsersDataGridView.DataSource = DBConnection.dtUsers;
                    //Опустошение боксов и переменных
                    LoginBox.Text = "";
                    PassBox.Text = "";
                    IDs = "";
                    LoginB = "";
                    //Настройка кнопок
                    DeleteButton.Enabled = true;
                    SaveButton.Visible = false;
                    CancelButton.Visible = false;
                }
            }
        }
    }
}
