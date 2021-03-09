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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        // добавление значений в таблицу product
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into items(name_item, quantity, price) values('" + nameBox.Text + "', '" + quantityBox.Text + "', '" + priceBox.Text + "');";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("Товар добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // возврат на форму items
        private void button2_Click(object sender, EventArgs e)
        {
            items Win = new items();
            Win.Show();
            this.Hide();
        }
    }
}
