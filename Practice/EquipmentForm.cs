﻿using System;
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
                if (DBConnection.CheKingAll(EquipmentDataGridView.CurrentRow.Cells[0].Value.ToString(), "Equipment", "accounting") == true)
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
                if (DBConnection.CheKingAll(EquipmentBox.Text, "Equipment", "Equipment") == true)
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

        private void EquipmentBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar < 'а' || e.KeyChar > 'я') && (e.KeyChar < 'А' || e.KeyChar > 'Я') && (e.KeyChar != ' ')) e.Handled = true;
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetEquipList();
            EquipmentDataGridView.DataSource = DBConnection.dtEquip;
        }
    }
}
