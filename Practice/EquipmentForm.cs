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
    public partial class EquipmentForm : Form
    {
        public EquipmentForm()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что вы хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (DBConnection.checkDel(EquipmentDataGridView.CurrentRow.Cells[0].Value.ToString(), "Equipment", "accounting") == true)
                {
                    MessageBox.Show("Это оборудование используется в учёте, удаление невозможно");
                }
                else
                {

                    DBConnection.Delete("Equipment", "ID = '" + EquipmentDataGridView.CurrentRow.Cells[0].Value.ToString() + "'");
                    DBConnection.GetEquipList();
                    EquipmentDataGridView.DataSource = DBConnection.dtEquip;
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
            if ((string.IsNullOrWhiteSpace(EquipmentBox.Text)))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (DBConnection.checkDel(EquipmentBox.Text, "Equipment", "Equipment") == true)
                {
                    MessageBox.Show("Такая запись уже есть в базе данных");
                }
                else
                {
                    string addstring = "null,'" + EquipmentBox.Text + "'";
                    DBConnection.add("Equipment", addstring);
                    MessageBox.Show("Запись добавлена");
                    DBConnection.GetEquipList();
                    EquipmentDataGridView.DataSource = DBConnection.dtEquip;
                    EquipmentBox.Text = "";
                }
            }
        }
    }
}
