﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Practice
{
    class DBConnection
    {
        //
        // Подключение и работа с базой
        //
        static string connectionString = @"Database = practice; Data source = localhost; UserID = root; Password = qwerty";
        static MySqlConnection msConnect;
        static MySqlCommand msCommand;
        static public MySqlDataAdapter msDataAdapter;
        //
        // Переменные
        //
        static public string User;
        static public string Role;
        static public string SotrudId;
        //
        //Базы данных
        //
        static public DataTable dtUsers = new DataTable();
        static public DataTable dtRole = new DataTable();
        static public DataTable dtStatus = new DataTable();
        static public DataTable dtDivision = new DataTable();
        static public DataTable dtCatergory = new DataTable();
        static public DataTable dtzip = new DataTable();
        static public DataTable dtEquip = new DataTable();
        static public DataTable dtSupplier = new DataTable();
        static public DataTable dtSotrud = new DataTable();
        static public DataTable dtUserCombo = new DataTable();
        static public DataTable dtAccounting = new DataTable();
        static public DataTable dtChangeLog = new DataTable();
        //
        // Подключение БД
        //
        static public bool Connect()
        {
            try
            {
                msConnect = new MySqlConnection(connectionString);
                msConnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = msConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Ошибка!");
                return false;
            }
        }
        //
        //Выход с базы данных
        //
        static public void Close()
        {
            msConnect.Close();
        }
        //
        //Авторизация
        //
        static public void Autorization(string login, string password)
        {
            try
            {
                string sql = "SELECT role.Role From role INNER JOIN user ON user.Role = role.ID Where  Login ='" + login + "' AND Password ='" + password + "';";
                msCommand.CommandText = sql;
                Object result = msCommand.ExecuteScalar();
                if (result != null)
                {
                    Role = result.ToString();
                    User = login;
                }
                else
                {
                    Role = null;
                }
            }
            catch (Exception ex)
            {
                Role = User = null;
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Get Sotrud ID
        //
        static public void GetSotrudID(string login)
        {
            try
            {

                msCommand.CommandText = "select sotrud.ID FROM sotrud inner join user on sotrud.User = user.ID Where user.login='" + login + "'";
                Object result = msCommand.ExecuteScalar();
                SotrudId = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Вывод списка пользователей
        //
        static public void GetUserList(string selectedRole = null)
        {
            try 
            {
                if (selectedRole == null)
                {
                    msCommand.CommandText = "select user.ID,user.Login,user.Password,role.Role from user, role where user.role = role.ID; ";
                }
                else
                {
                    msCommand.CommandText = "select user.Login,user.Password,role.Role from user, role where user.role = role.ID and user.role ='" + selectedRole + "'";
                }
                dtUsers.Clear();
                msDataAdapter.Fill(dtUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Вывод Ролей
        //
        static public void GetRoleList()
        {
            try
            {
                msCommand.CommandText = "select * from role";
                dtRole.Clear();
                msDataAdapter.Fill(dtRole);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }       
        //
        //Вывод Статусов
        //
        static public void GetStatusList()
        {
            try
            {
                msCommand.CommandText = "select * from Status";
                dtStatus.Clear();
                msDataAdapter.Fill(dtStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Вывод Подразделений
        //
        static public void GetDivisionList()
        {
            try
            {
                msCommand.CommandText = "select * from Division";
                dtDivision.Clear();
                msDataAdapter.Fill(dtDivision);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Вывод Категорий
        //
        static public void GetCategoryList()
        {
            try
            {
                msCommand.CommandText = "select * from category";
                dtCatergory.Clear();
                msDataAdapter.Fill(dtCatergory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Вывод Зипов
        //
        static public void GetZipList()
        {
            try
            {
                msCommand.CommandText = "select * from zip";
                dtzip.Clear();
                msDataAdapter.Fill(dtzip);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Вывод Оборудования
        //
        static public void GetEquipList()
        {
            try
            {
                msCommand.CommandText = "select * from Equipment";
                dtEquip.Clear();
                msDataAdapter.Fill(dtEquip);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Вывод списка поставщиков
        //
        static public void GetSupplierList(string Name = null, string INN = null)
        {
            try
            {
                if (Name == null && INN == null)
                {
                    msCommand.CommandText = "select * from Supplier";
                }
                else if (INN == null)
                {
                    msCommand.CommandText = "select * from Supplier where Name='"+Name+"'";
                }
                else
                {
                    msCommand.CommandText = "select * from Supplier where INN='" + INN + "'";
                }
                dtSupplier.Clear();
                msDataAdapter.Fill(dtSupplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Вывод списка юзеров
        //
        static public void GetUserComboList()
        {
            try
            {
                msCommand.CommandText = "select * from user where id not in (select sotrud.user from sotrud where sotrud.user = user.id);";
                dtUserCombo.Clear();
                msDataAdapter.Fill(dtUserCombo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Вывод списка cотрудников
        //
        static public void GetSotrudList(string phone = null)
        {
            try
            {
                if (phone == null)
                {
                    msCommand.CommandText = "select sotrud.id, sotrud.FIO, sotrud.Phone, user.Login from sotrud,user where sotrud.User = user.ID";
                }
                else
                {
                    msCommand.CommandText = "select sotrud.id, sotrud.FIO, sotrud.Phone, user.Login from sotrud,user where sotrud.User = user.ID and sotrud.phone ='"+ phone +"'";
                }
                dtSotrud.Clear();
                msDataAdapter.Fill(dtSotrud);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        //Вывод списка учёта
        //
        static public void GetAccountingList(string category =  null, string supplier = null,  string status = null)
        {
            try
            {
                if (category != null)
                msCommand.CommandText = " select accounting.ID, category.category, equipment.equipment, Zip.zip, accounting.PartNmodel, accounting.kolvo, accounting.InvNumber, supplier.Name,division.division,Status.Status, accounting.comment, accounting.DatePost, accounting.DateEdit, sotrud.FIO from accounting,category,equipment,zip,supplier,division,status,sotrud where accounting.Category = category.ID and accounting.Equipment = equipment.ID and accounting.zip = zip.id and accounting.supplier = supplier.ID and accounting.Division = division.ID and accounting.status = status.ID and accounting.sotrud = sotrud.ID;";
                dtAccounting.Clear();
                msDataAdapter.Fill(dtAccounting);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }

        //
        //Вывод Истории изменений
        //
        static public void GetChangeLogList()
        {
            try
            {
                msCommand.CommandText = " SELECT * FROM changelog; ";
                dtChangeLog.Clear();
                msDataAdapter.Fill(dtChangeLog);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }

        // проверка существования 
        //
        static public bool CheKingAll(string id,string Stolb,string tabl)
        {
            msCommand.CommandText = "select count("+ Stolb +") from "+ tabl +" where "+ Stolb +"='" + id + "'";
            int count = Convert.ToInt32(msCommand.ExecuteScalar());
            if (count > 0)
                return true;
            else
                return false;
        }

        //
        //Add
        //
        static public bool add(string table, string parametr)
        {
            msCommand.CommandText = "insert into " + table + " values(" + parametr + ")";
            if (msCommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        //  
        //Edit
        //
        static public void Edit(string table, string parametr)
        {
            msCommand.CommandText = "Update " + table + " Set " + parametr;
            msCommand.ExecuteNonQuery();
        }

        //
        //Delete
        //
        static public void Delete(string table, string parametr)
        {
            msCommand.CommandText = "Delete From " + table + " Where " + parametr + "";

            msCommand.ExecuteNonQuery();
        }
    }
}

