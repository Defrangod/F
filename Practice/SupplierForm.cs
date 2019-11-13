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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        string Ids;
        string OldName;
        string OldInn;
        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(NameBox.Text)) || (string.IsNullOrWhiteSpace(InnBox.Text)) || (string.IsNullOrWhiteSpace(AdressBox.Text)) || (string.IsNullOrWhiteSpace(PastNameBox.Text)) || (string.IsNullOrWhiteSpace(SiteBox.Text)) || (string.IsNullOrWhiteSpace(ContactBox.Text)) )
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (DBConnection.CheKingAll(InnBox.Text, "INN", "supplier") == true || DBConnection.CheKingAll(NameBox.Text, "Name", "supplier") )
                {
                    MessageBox.Show("Поставщик с таким названием организации / ИНН  уже есть в базе данных");
                }
                else
                {
                    //добавление записи
                    string addstring = "null,'" + NameBox.Text + "','" + InnBox.Text + "','" + AdressBox.Text + "','" + PastNameBox.Text + "','" + SiteBox.Text + "','" + ContactBox.Text + "'";
                    DBConnection.add("supplier", addstring);
                    MessageBox.Show("Запись добавлена");
                    //обновление таблицы
                    DBConnection.GetSupplierList();
                    SupplierDataGridView.DataSource = DBConnection.dtSupplier;
                    //опустошение боксов
                    NameBox.Text = "";
                    InnBox.Text = "";
                    AdressBox.Text = "";
                    PastNameBox.Text = "";
                    SiteBox.Text = "";
                    ContactBox.Text = "";


                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            //опустошение боксов
            NameBox.Text = "";
            InnBox.Text = "";
            AdressBox.Text = "";
            PastNameBox.Text = "";
            SiteBox.Text = "";
            ContactBox.Text = "";
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
            // перенос записи из таблицы
            Ids = SupplierDataGridView.CurrentRow.Cells[0].Value.ToString();
            NameBox.Text = SupplierDataGridView.CurrentRow.Cells[1].Value.ToString(); 
            OldName = SupplierDataGridView.CurrentRow.Cells[1].Value.ToString();
            InnBox.Text = SupplierDataGridView.CurrentRow.Cells[2].Value.ToString(); 
            OldInn = SupplierDataGridView.CurrentRow.Cells[2].Value.ToString();
            AdressBox.Text = SupplierDataGridView.CurrentRow.Cells[3].Value.ToString();
            PastNameBox.Text = SupplierDataGridView.CurrentRow.Cells[4].Value.ToString();
            SiteBox.Text = SupplierDataGridView.CurrentRow.Cells[5].Value.ToString();
            ContactBox.Text = SupplierDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что вы хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (DBConnection.CheKingAll(SupplierDataGridView.CurrentRow.Cells[0].Value.ToString(), "supplier", "accounting") == true)
                {
                    MessageBox.Show("Этот Поставщик используется в учёте, удаление невозможно");
                }
                else
                {

                    DBConnection.Delete("supplier", "ID = '" + SupplierDataGridView.CurrentRow.Cells[0].Value.ToString() + "'");
                    DBConnection.GetSupplierList();
                    SupplierDataGridView.DataSource = DBConnection.dtSupplier;
                    MessageBox.Show("Запись удалена");
                }
            }
            else
            {
                MessageBox.Show("Отмена удаления");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(NameBox.Text)) || (string.IsNullOrWhiteSpace(InnBox.Text)) || (string.IsNullOrWhiteSpace(AdressBox.Text)) || (string.IsNullOrWhiteSpace(PastNameBox.Text)) || (string.IsNullOrWhiteSpace(SiteBox.Text)) || (string.IsNullOrWhiteSpace(ContactBox.Text)))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                //Проверка логина на дублирование
                if (DBConnection.CheKingAll(InnBox.Text, "INN", "supplier") == true && InnBox.Text != OldInn || DBConnection.CheKingAll(NameBox.Text, "Name", "supplier") && OldName != NameBox.Text)
                {
                    MessageBox.Show("Поставщик с таким названием организации / ИНН  уже есть в базе данных");
                }
                else
                {
                    //Изменение записи
                    string EditString = "Name = '" + NameBox.Text + "', INN = '" + InnBox.Text  + "', Adress = '" + AdressBox.Text + "', PastName = '" + PastNameBox.Text + "', Site = '" + SiteBox.Text + "', ContractPerson = '" + ContactBox.Text + "' Where ID = '" + Ids + "'";
                    DBConnection.Edit("supplier", EditString);
                    MessageBox.Show("Запись изменена");
                    //обновление таблицы
                    DBConnection.GetSupplierList();
                    SupplierDataGridView.DataSource = DBConnection.dtSupplier;
                    //Опустошение боксов и переменных
                    NameBox.Text = "";
                    InnBox.Text = "";
                    AdressBox.Text = "";
                    PastNameBox.Text = "";
                    SiteBox.Text = "";
                    ContactBox.Text = "";
                    Ids = "";
                    OldInn = "";
                    OldName = "";
                    //Настройка кнопок
                    DeleteButton.Enabled = true;
                    SaveButton.Visible = false;
                    CancelButton.Visible = false;
                }
            }
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetSupplierList();
            SupplierDataGridView.DataSource = DBConnection.dtSupplier;
        }
    }
}
