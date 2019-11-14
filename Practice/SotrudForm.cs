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
    public partial class SotrudForm : Form
    {
        public SotrudForm()
        {
            InitializeComponent();
        }
        string IDs;
        string FIOb;
        private void SotrudForm_Load(object sender, EventArgs e)
        {
            //Заполнение таблицы
            DBConnection.GetSotrudList();
            SotruDataGridView.DataSource = DBConnection.dtSotrud;
            //заполнение бокса
            DBConnection.GetUserComboList();
            UserComboBox.DataSource = DBConnection.dtUserCombo;
            UserComboBox.DisplayMember = "Login";
            UserComboBox.ValueMember = "ID";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(FIOBox.Text)) || (string.IsNullOrWhiteSpace(PhoneBox.Text)) || (string.IsNullOrWhiteSpace(UserComboBox.SelectedValue.ToString())))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (DBConnection.CheKingAll(FIOBox.Text, "FIO", "sotrud") == true)
                {
                    MessageBox.Show("дублируется ФИО");
                }
                else
                {
                    //добавление записи
                    string addstring = "null,'" + FIOBox.Text + "','" + PhoneBox.Text + "','" + UserComboBox.SelectedValue.ToString() + "'";
                    DBConnection.add("sotrud", addstring);
                    MessageBox.Show("Запись добавлена");
                    //обновление таблицы
                    DBConnection.GetSotrudList();
                    SotruDataGridView.DataSource = DBConnection.dtSotrud;
                    //опустошение боксов
                    FIOBox.Text = "";
                    PhoneBox.Text = "";


                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(FIOBox.Text)) || (string.IsNullOrWhiteSpace(PhoneBox.Text)) || (string.IsNullOrWhiteSpace(UserComboBox.SelectedValue.ToString())))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                //Проверка логина на дублирование
                if (DBConnection.CheKingAll(FIOBox.Text, "FIO", "sotrud") == true && FIOBox.Text != FIOb)
                {
                    MessageBox.Show("дублируется ФИО");
                }
                else
                {
                    //Изменение записи
                    string EditString = "FIO = '" + FIOBox.Text + "', Phone = '" + PhoneBox.Text + "', User = '" + UserComboBox.SelectedValue.ToString() + "' Where ID = '" + IDs + "'";
                    DBConnection.Edit("sotrud", EditString);
                    MessageBox.Show("Запись изменена");
                    //обновление таблицы
                    DBConnection.GetSotrudList();
                    SotruDataGridView.DataSource = DBConnection.dtSotrud;
                    //обновление бокса
                    DBConnection.GetUserComboList();
                    UserComboBox.DataSource = DBConnection.dtUserCombo;
                    UserComboBox.DisplayMember = "Login";
                    UserComboBox.ValueMember = "ID";
                    //Опустошение боксов и переменных
                    FIOBox.Text = "";
                    PhoneBox.Text = "";
                    IDs = "";
                    FIOb = "";
                    //Настройка кнопок
                    DeleteButton.Enabled = true;
                    SaveButton.Visible = false;
                    CancelButton.Visible = false;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Опустошение боксов и переменных
            FIOBox.Text = "";
            PhoneBox.Text = "";
            IDs = "";
            FIOb = "";
            //Настройка кнопок
            DeleteButton.Enabled = true;
            SaveButton.Visible = false;
            CancelButton.Visible = false;
            MessageBox.Show("Изменения отменены");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //Настройка кнопок
            DeleteButton.Enabled = false;
            SaveButton.Visible = true;
            CancelButton.Visible = true;
            //Перенос записи из таблицы
            IDs = SotruDataGridView.CurrentRow.Cells[0].Value.ToString();
            FIOBox.Text = SotruDataGridView.CurrentRow.Cells[1].Value.ToString();
            FIOb = SotruDataGridView.CurrentRow.Cells[1].Value.ToString();
             PhoneBox.Text = SotruDataGridView.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что вы хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                IDs = SotruDataGridView.CurrentRow.Cells[0].Value.ToString();
                if (DBConnection.CheKingAll(SotruDataGridView.CurrentRow.Cells[0].Value.ToString(), "Sotrud", "accounting") == true)
                {
                    MessageBox.Show("Сотрудник используется в учёте, удаление невозможно");
                }
                else
                {
                    string table = "sotrud";
                    string deletestring = "ID='" + SotruDataGridView.CurrentRow.Cells[0].Value.ToString() + "'";
                    DBConnection.Delete(table, deletestring);
                    MessageBox.Show("Запись удалена");
                    //заполнение таблицы
                    DBConnection.GetSotrudList();
                    SotruDataGridView.DataSource = DBConnection.dtSotrud;
                    //обновление бокса 
                    DBConnection.GetUserComboList();
                    UserComboBox.DataSource = DBConnection.dtUserCombo;
                    UserComboBox.DisplayMember = "Login";
                    UserComboBox.ValueMember = "ID";
                }
            }
        }

        private void FIOBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar < 'а' || e.KeyChar > 'я') && (e.KeyChar < 'А' || e.KeyChar > 'Я') && (e.KeyChar != ' ')) e.Handled = true;
        }

        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9')) e.Handled = true;
        }
    }
}
