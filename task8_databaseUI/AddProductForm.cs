using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace task8_databaseUI
{
    public partial class AddProductForm : Form
    {
        DataBase dataBase = new DataBase();

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var title = textBox1.Text;
            var category_id = textBox2.Text;
            var storage_method_id = textBox3.Text;
            var manufacturer_id = textBox4.Text;
            var supplier_id = textBox5.Text;

            var addQuery = $"INSERT INTO Products(title,category_id, storage_method_id, manufacturer_id,supplier_id) VALUES ('{title}','{category_id}',{storage_method_id},{manufacturer_id},{supplier_id})";

            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана!");

            dataBase.closeConnection();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
