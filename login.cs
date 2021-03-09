using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PR4
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();// закрытие формы
        }


        // авторизация пользователя
        private void loginBut_Click(object sender, EventArgs e)
        {
            int Count = 0;
            string query = "select count(*) from users where login = '" + logBox.Text + "'and password = '" + passBox.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                Count = Convert.ToInt32(cmDB.ExecuteScalar());
                conn.Close();
            }
            // если не найдено совпадений в таблице
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка авторизации. Попробуйте еще раз");
                MessageBox.Show(ex.Message);
            }

            // проверка совпадений значений в таблице пользователей
            if (Count>0)
            {
                items Win = new items();
                Win.Show();
                this.Hide();
            }
        }
    }
}
