using System;
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
                    msCommand.CommandText = "select user.Login,user.Password,role.Role from user, role where user.role = role.ID user.role ='" + selectedRole + "'";
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
        //Вывод списка составщиков
        //
        static public void GetSupplierList()
        {
            try
            {
                msCommand.CommandText = "select * from Supplier";
                dtSupplier.Clear();
                msDataAdapter.Fill(dtSupplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //
        // проверка существования 
        //
        static public bool checkDel(string id,string Stolb,string tabl)
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

