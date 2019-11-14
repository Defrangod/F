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
    public partial class AccountingForm : Form
    {
        public AccountingForm()
        {
            InitializeComponent();
        }
        string IDs;
        private void AccountingForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetAccountingList();
            AccountingDataGridView.DataSource = DBConnection.dtAccounting;
            //Категории
            DBConnection.GetCategoryList();
            CategoryComboBox.DataSource = DBConnection.dtCatergory;
            CategoryComboBox.DisplayMember = "Category";
            CategoryComboBox.ValueMember = "ID";
            //Оборудование
            DBConnection.GetEquipList();
            EzComboBox.DataSource = DBConnection.dtEquip;
            EzComboBox.DisplayMember = "Equipment";
            EzComboBox.ValueMember = "ID";            
            //Поставщик
            DBConnection.GetSupplierList();
            SupplierComboBox.DataSource = DBConnection.dtSupplier;
            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "ID";
            //Подразделения
            DBConnection.GetDivisionList();
            DivisionComboBox.DataSource = DBConnection.dtDivision;
            DivisionComboBox.DisplayMember = "Division";
            DivisionComboBox.ValueMember = "ID";
            //Подразделения
            DBConnection.GetStatusList();
            StatusComboBox.DataSource = DBConnection.dtStatus;
            StatusComboBox.DisplayMember = "Status";
            StatusComboBox.ValueMember = "ID";

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(PartModelBox.Text)) || (string.IsNullOrWhiteSpace(KolvoBox.Text)) || (string.IsNullOrWhiteSpace(KolvoBox.Text)))
            {
                MessageBox.Show("Заполните обязательные поля (комментарий не обязателен");
            }
            else
            {
                DateTime DateS = DateTime.Now.Date;
                //добавление записи
                string addstring;
                if (CategoryComboBox.SelectedValue.ToString() == "1")
                {
                     addstring = "null,'" + CategoryComboBox.SelectedValue.ToString() + "','" + EzComboBox.SelectedValue.ToString() + "',' 1 ','" + PartModelBox.Text + "','" + KolvoBox.Text + "','" + InvBox.Text + "','" + SupplierComboBox.SelectedValue.ToString() + "','" + DivisionComboBox.SelectedValue.ToString() + "','" + StatusComboBox.SelectedValue.ToString() + "','" + CommentBox.Text + "','" + DateS.ToString("yyyy-MM-dd") + "','" + DateS.ToString("yyyy-MM-dd") + "','" + DBConnection.SotrudId + "'";
                }
                else
                {
                     addstring = "null,'" + CategoryComboBox.SelectedValue.ToString() + "',' 1 ','" + EzComboBox.SelectedValue.ToString() + "','" + PartModelBox.Text + "','" + KolvoBox.Text + "','" + InvBox.Text + "','" + SupplierComboBox.SelectedValue.ToString() + "','" + DivisionComboBox.SelectedValue.ToString() + "','" + StatusComboBox.SelectedValue.ToString() + "','" + CommentBox.Text + "','" + DateS.ToString("yyyy-MM-dd") + "','" + DateS.ToString("yyyy-MM-dd") + "','" + DBConnection.SotrudId + "'";
                }
                DBConnection.add("accounting", addstring);
                MessageBox.Show("Запись добавлена");
                //обновление таблицы
                DBConnection.GetAccountingList();
                AccountingDataGridView.DataSource = DBConnection.dtAccounting;
                //опустошение боксов
                PartModelBox.Text = "";
                KolvoBox.Text = "";
                InvBox.Text = "";
                CommentBox.Text = "";               
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedValue.ToString() == "2")
            {
                //ЗИП
                DBConnection.GetZipList();
                EzComboBox.DataSource = DBConnection.dtzip;
                EzComboBox.DisplayMember = "Zip";
                EzComboBox.ValueMember = "ID";
                label2.Text = "ЗИП";
            }
            else
            {
                //Оборудование
                DBConnection.GetEquipList();
                EzComboBox.DataSource = DBConnection.dtEquip;
                EzComboBox.DisplayMember = "Equipment";
                EzComboBox.ValueMember = "ID";
                label2.Text = "Оборудование";
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //Настройка кнопок
            DeleteButton.Enabled = false;
            SaveButton.Visible = true;
            CancelButton.Visible = true;
            //Перенос записи из таблицы
            IDs = AccountingDataGridView.CurrentRow.Cells[0].Value.ToString();
            PartModelBox.Text = AccountingDataGridView.CurrentRow.Cells[4].Value.ToString();
            KolvoBox.Text = AccountingDataGridView.CurrentRow.Cells[5].Value.ToString();
            InvBox.Text = AccountingDataGridView.CurrentRow.Cells[6].Value.ToString();
            CommentBox.Text = AccountingDataGridView.CurrentRow.Cells[10].Value.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(PartModelBox.Text)) || (string.IsNullOrWhiteSpace(KolvoBox.Text)) || (string.IsNullOrWhiteSpace(KolvoBox.Text)))
            {
                MessageBox.Show("Заполните обязательные поля (комментарий не обязателен");
            }
            else
            {
                string EditString;
                if (CategoryComboBox.SelectedValue.ToString() == "1")
                {
                    //Изменение записи
                     EditString = "Category = '" + CategoryComboBox.SelectedValue.ToString() + "', Equipment = '" + EzComboBox.SelectedValue.ToString() + "', Zip = '1', PartNmodel = '" + PartModelBox.Text + "', kolvo = '" + KolvoBox.Text + "', InvNumber = '" + InvBox.Text + "', supplier = '" + SupplierComboBox.SelectedValue.ToString() + "', Division = '" + DivisionComboBox.SelectedValue.ToString() + "', Status = '" + StatusComboBox.SelectedValue.ToString() + "', Comment = '" + CommentBox.Text + "', DateEdit = '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "', Equipment = '" + DBConnection.SotrudId + "' Where ID = '" + IDs + "'";
                }
                else
                {
                    EditString = "Category = '" + CategoryComboBox.SelectedValue.ToString() + "', Equipment = '1', Zip = '"+ EzComboBox.SelectedValue.ToString() + "', PartNmodel = '" + PartModelBox.Text + "', kolvo = '" + KolvoBox.Text + "', InvNumber = '" + InvBox.Text + "', supplier = '" + SupplierComboBox.SelectedValue.ToString() + "', Division = '" + DivisionComboBox.SelectedValue.ToString() + "', Status = '" + StatusComboBox.SelectedValue.ToString() + "', Comment = '" + CommentBox.Text + "', DateEdit = '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "', Equipment = '" + DBConnection.SotrudId + "' Where ID = '" + IDs + "'";
                }
                DBConnection.Edit("accounting", EditString);
                MessageBox.Show("Запись изменена");
                //обновление таблицы
                DBConnection.GetAccountingList();
                AccountingDataGridView.DataSource = DBConnection.dtAccounting;
                //Опустошение боксов и переменных
                PartModelBox.Text = ""; 
                KolvoBox.Text = "";
                InvBox.Text = "";
                CommentBox.Text ="";
                //Настройка кнопок
                DeleteButton.Enabled = true;
                SaveButton.Visible = false;
                CancelButton.Visible = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Опустошение боксов и переменных
            PartModelBox.Text = "";
            KolvoBox.Text = "";
            InvBox.Text = "";
            CommentBox.Text = "";
            //Настройка кнопок
            DeleteButton.Enabled = true;
            SaveButton.Visible = false;
            CancelButton.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что вы хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                    string table = "accounting";
                    string deletestring = "ID='" + AccountingDataGridView.CurrentRow.Cells[0].Value.ToString() + "'";
                    DBConnection.Delete(table, deletestring);
                    MessageBox.Show("Запись удалена");

                    DBConnection.GetAccountingList();
                    AccountingDataGridView.DataSource = DBConnection.dtAccounting;                
            }
        }

        private void KolvoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8)) e.Handled = true;
        }

        private void PartModelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar < 'а' || e.KeyChar > 'я') && (e.KeyChar < 'А' || e.KeyChar > 'Я') && (e.KeyChar != ' ')) e.Handled = true;
        }
    }
}
