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
    public partial class items : Form
    {
        // Вывод значений из таблицы product в listview
        void get_Info(ListView List)
        {
            string query = "select id_item, name_item, quantity, price from items;"; // запрос значений из таблицы
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3) };
                        var listItem = new ListViewItem(row);
                        List.Items.Add(listItem);
                    }
                }
                List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public items()
        {
            InitializeComponent();
            get_Info(list);
            this.FormClosing += button8_Click; 
        }
        
        // обновление значений
        private void Refresh_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            get_Info(list);
        }

        // закрытие формы
        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // переход на форму регистрации 
        private void addUser_Click(object sender, EventArgs e)
        {
            register Win = new register();
            Win.Show();
        }

        // перехд на форму добавления товара
        private void Add_item_Click(object sender, EventArgs e)
        {
            AddItem Win = new AddItem();
            Win.Show();
            this.Hide();
        }
      
        // перехд на форму заказов
        private void Order_Click(object sender, EventArgs e)
        {
            Orders Win = new Orders();
            Win.Show();
        }
        
        
        // перехд на форму приход
        private void Prihod_Click_1(object sender, EventArgs e)
        {
            Prihod Win = new Prihod();
            Win.Show();
        }
        
        // перехд на форму расход
        private void Rashod_Click_1(object sender, EventArgs e)
        {
            Rashod Win = new Rashod();
            Win.Show();
        }
    }
}
