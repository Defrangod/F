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
    public partial class DivisionForm : Form
    {
        public DivisionForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(DevisionBox.Text)))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (DBConnection.CheKingAll(DevisionBox.Text, "Division", "Division") == true)
                {
                    MessageBox.Show("Такая запись уже есть в базе данных");
                }
                else
                {
                    string addstring = "null,'" + DevisionBox.Text + "'";
                    DBConnection.add("Division", addstring);
                    DBConnection.GetDivisionList();
                    DivisionDataGridView.DataSource = DBConnection.dtDivision;
                    MessageBox.Show("Запись добавлена");
                    DevisionBox.Text = "";
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что вы хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (DBConnection.CheKingAll(DivisionDataGridView.CurrentRow.Cells[0].Value.ToString(), "Division", "accounting") == true)
                {
                    MessageBox.Show("Это подразделение используется в учёте, удаление невозможно");
                }
                else
                {

                    DBConnection.Delete("Division", "ID = '" + DivisionDataGridView.CurrentRow.Cells[0].Value.ToString() + "'");
                    DBConnection.GetDivisionList();
                    DivisionDataGridView.DataSource = DBConnection.dtDivision;
                    MessageBox.Show("Запись удалена");
                }
            }
            else
            {
                MessageBox.Show("Отмена удаления");
            }
        }

        private void DivisionForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetDivisionList();
            DivisionDataGridView.DataSource = DBConnection.dtDivision;
        }
    }
}
