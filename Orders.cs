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
    public partial class Orders : Form
    {

        void get_Info(ListView List)
        {
            string query = "select id_ord, name_item, orders.quantity, orders.price, employee, date from orders join items on id_item = id_tovar;"; // запрос значений из таблицы
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
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5) };
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
        public Orders()
        {
            InitializeComponent();
            get_Info(List);
            this.FormClosing += button1_Click;
        }
        // кнопка обновления данных
        private void Refresh_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            get_Info(List);
        }
        // кнопка выхода 
        private void button1_Click(object sender, EventArgs e)
        {
            items Win = new items();
            Win.Show();
            this.Hide();
        }
    }
}
