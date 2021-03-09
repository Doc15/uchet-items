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
    public partial class Rashod : Form
    {
        // вывод значений из таблиц товары и расход
        void getInfo(ListView List)
        {
            string query = "select items.name_item, rashod.quantity, rashod.price, rashod.outcome, date from items join rashod on rashod.id_tovar = items.id_item order by outcome;";
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
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4) };
                        var listItem = new ListViewItem(row);
                        List.Items.Add(listItem);
                    }
                }
                conn.Close();
                List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // поле выбора товара 
        void getItems(ComboBox Box)
        {
            string query = "select name_item from items;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string row = rd.GetString(0);
                        Box.Items.Add(row);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Rashod()
        {
            InitializeComponent();
            getInfo(listView1);
            getItems(comboBox1);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }


        // кнопка добавления записи в таблицу расход
        private void Add_Click(object sender, EventArgs e)
        {
            string query = "insert into rashod(id_tovar, quantity, price, outcome, date) values('" + Convert.ToString(comboBox1.SelectedIndex + 1) + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + dateTimePicker1.Text + "');";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                string queryChange = "update items set quantity = quantity - " + textBox1.Text + " where id_item = " + Convert.ToString(comboBox1.SelectedIndex + 1) + ";";
                MySqlCommand cmDBC = new MySqlCommand(queryChange, conn);
                cmDBC.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rdc = cmDBC.ExecuteReader();
                    MessageBox.Show("Расход добавлен");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        // кнопка обновления данных
        private void Refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            getInfo(listView1);
        }
    }
}
