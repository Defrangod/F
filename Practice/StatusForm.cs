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
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetStatusList();
            StatusDataGridView.DataSource = DBConnection.dtStatus;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что вы хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (DBConnection.CheKingAll(StatusDataGridView.CurrentRow.Cells[0].Value.ToString(), "Status", "accounting") == true)
                {
                    MessageBox.Show("Этот статус используется в учёте, удаление невозможно");
                }
                else
                {

                    DBConnection.Delete("Status", "ID = '" + StatusDataGridView.CurrentRow.Cells[0].Value.ToString() + "'");
                    DBConnection.GetStatusList();
                    StatusDataGridView.DataSource = DBConnection.dtStatus;
                    MessageBox.Show("Запись удалена");
                }
            }
            else
            {
                MessageBox.Show("Отмена удаления");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(StatusBox.Text)))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (DBConnection.CheKingAll(StatusBox.Text, "Status", "Status") == true)
                {
                    MessageBox.Show("Такая запись уже есть в базе данных");
                }
                else
                {
                    string addstring = "null,'" + StatusBox.Text + "'";
                    DBConnection.add("Status", addstring);
                    DBConnection.GetStatusList();
                    StatusDataGridView.DataSource = DBConnection.dtStatus;
                    MessageBox.Show("Запись добавлена");
                    StatusBox.Text = "";
                }
            }
        }

        private void StatusBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar < 'а' || e.KeyChar > 'я') && (e.KeyChar < 'А' || e.KeyChar > 'Я') && (e.KeyChar != ' ') || StatusBox.TextLength > 39) e.Handled = true;
        }
    }
}
