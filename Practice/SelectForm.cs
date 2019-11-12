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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            UsersForm UserFrm = new UsersForm();
            UserFrm.Show();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            if (DBConnection.Role == "Администратор")
            {
                label1.Text = "Вы авторизованы как - Администратор";
            }
            else
            {
                label1.Text = "Вы авторизованы как - Менеджер";
            }
        }

        private void RoleButton_Click(object sender, EventArgs e)
        {
            RoleForm RoleFrm = new RoleForm();
            RoleFrm.Show();
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            StatusForm StatusFrm = new StatusForm();
            StatusFrm.Show();
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            DivisionForm DivisionFrm = new DivisionForm();
            DivisionFrm.Show();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm CategoryFrm = new CategoryForm();
            CategoryFrm.Show();
        }

        private void ZIPbutton_Click(object sender, EventArgs e)
        {
            ZipForm ZipFrm = new ZipForm();
            ZipFrm.Show();
        }

        private void EquipmentButton_Click(object sender, EventArgs e)
        {
            EquipmentForm EquipFrm = new EquipmentForm();
            EquipFrm.Show();
        }

        private void SotrudButton_Click(object sender, EventArgs e)
        {

        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            SupplierForm SupplierFrm = new SupplierForm();
            SupplierFrm.Show();
        }
    }
}
