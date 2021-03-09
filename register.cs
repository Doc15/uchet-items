using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PR4
{

    public partial class register : Form
    {
        // генерация данных пользователя
        static string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        static Random r = new Random();
        static string GetRandom(string type)
        {
            string Result = "";
            if (type == "login")
            {
                for (int i = 0; i < 4; i++)
                {
                    var index = r.Next(symbols.Length);
                    Result += symbols[index];
                }
            }
            else if (type == "password")
            {
                for (int i = 0; i < 6; i++)
                {
                    var index = r.Next(symbols.Length);
                    Result += symbols[index];
                }
            }
            return Result;
        }

        public register()
        {
            InitializeComponent();
            login.Text = GetRandom(login.Name.ToString());
            password.Text = GetRandom(password.Name.ToString());
        }

        // запуск генерации данных пользователя
        private void getNew_Click(object sender, EventArgs e)
        {
            login.Text = "";
            password.Text = "";
            login.Text = GetRandom(login.Name.ToString());
            password.Text = GetRandom(password.Name.ToString());
        }

        // добавление данных в таблицу users
        private void add_Click(object sender, EventArgs e)
        {
            string query = "insert into users(login, pass) values('" + login.Text + "', '" + password.Text + "');";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("Пользователь добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
