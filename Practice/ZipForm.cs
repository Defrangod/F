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
    public partial class ZipForm : Form
    {
        public ZipForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(ZipBox.Text)))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (DBConnection.CheKingAll(ZipBox.Text, "Zip", "Zip") == true)
                {
                    MessageBox.Show("Такая запись уже есть в базе данных");
                }
                else
                {
                    string addstring = "null,'" + ZipBox.Text + "'";
                    DBConnection.add("zip", addstring);
                    MessageBox.Show("Запись добавлена");
                    DBConnection.GetZipList();
                    ZipDataGridView.DataSource = DBConnection.dtzip;
                    ZipBox.Text = "";
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что вы хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (DBConnection.CheKingAll(ZipDataGridView.CurrentRow.Cells[0].Value.ToString(), "Zip", "accounting") == true)
                {
                    MessageBox.Show("Этот ЗИП используется в учёте, удаление невозможно");
                }
                else
                {

                    DBConnection.Delete("Zip", "ID = '" + ZipDataGridView.CurrentRow.Cells[0].Value.ToString() + "'");
                    DBConnection.GetZipList();
                    ZipDataGridView.DataSource = DBConnection.dtzip;
                    MessageBox.Show("Запись удалена");
                }
            }
            else
            {
                MessageBox.Show("Отмена удаления");
            }
        }

        private void ZipForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetZipList();
            ZipDataGridView.DataSource = DBConnection.dtzip;
        }
    }
}
