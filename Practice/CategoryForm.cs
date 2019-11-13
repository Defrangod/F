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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetCategoryList();
            CategoryDataGridView.DataSource = DBConnection.dtCatergory;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(CategoryBox.Text)))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (DBConnection.CheKingAll(CategoryBox.Text, "Category", "Category") == true)
                {
                    MessageBox.Show("Такая запись уже есть в базе данных");
                }
                else
                {
                    string addstring = "null,'" + CategoryBox.Text + "'";
                    DBConnection.add("category", addstring);
                    MessageBox.Show("Запись добавлена");
                    DBConnection.GetCategoryList();
                    CategoryDataGridView.DataSource = DBConnection.dtCatergory;
                    CategoryBox.Text = "";
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что вы хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (DBConnection.CheKingAll(CategoryDataGridView.CurrentRow.Cells[0].Value.ToString(), "Category", "accounting") == true)
                {
                    MessageBox.Show("Эта категория используется в учёте, удаление невозможно");
                }
                else
                {

                    DBConnection.Delete("Category", "ID = '" + CategoryDataGridView.CurrentRow.Cells[0].Value.ToString() + "'");
                    DBConnection.GetCategoryList();
                    CategoryDataGridView.DataSource = DBConnection.dtCatergory;
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
