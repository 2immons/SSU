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
    enum RowState
    {
        Existed,
        New,
        Modifed,
        ModifedNew,
        Deleted
    }

    public partial class TableListAdmin : Form
    {
        DataBase dataBase = new DataBase();

        public TableListAdmin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dataGridView2.Columns.Add("id", "ID");
                dataGridView2.Columns.Add("title", "Название");
                dataGridView2.Columns.Add("category_id", "ID категории");
                dataGridView2.Columns.Add("storage_method_id", "ID метода хранения");
                dataGridView2.Columns.Add("manufacturer_id", "ID производителя");
                dataGridView2.Columns.Add("supplier_id", "ID поставщика");
                dataGridView2.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(dataGridView2);
            }
            else if (radioButton2.Checked)
            {
                dataGridView2.Columns.Add("id", "ID");
                dataGridView2.Columns.Add("product_id", "Название");
                dataGridView2.Columns.Add("supply_date", "Дата поставки");
                dataGridView2.Columns.Add("price", "Цена поставки");
                dataGridView2.Columns.Add("quantity", "Объем поставки");
                dataGridView2.Columns.Add("supplier_id", "ID поставщика");
                dataGridView2.Columns.Add("warehouse_to_id", "ID склада");
                dataGridView2.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(dataGridView2);
            }
        }

        private void TableListAdmin_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("id", "ID");
            dataGridView2.Columns.Add("title", "Название");
            dataGridView2.Columns.Add("category_id", "ID категории");
            dataGridView2.Columns.Add("storage_method_id", "ID метода хранения");
            dataGridView2.Columns.Add("manufacturer_id", "ID производителя");
            dataGridView2.Columns.Add("supplier_id", "ID поставщика");
            dataGridView2.Columns.Add("IsNew", String.Empty);
            RefreshDataGrid(dataGridView2);
        }

        

        private void ClearFields()
        {
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), RowState.ModifedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = "";

            if (radioButton1.Checked)
            {
                queryString = $"SELECT * FROM Products";
            }
            if (radioButton2.Checked)
            {
                queryString = $"SELECT * FROM SupplyLog";
            }

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView2);
            ClearFields();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Products where concat (id, title, category_id, storage_method_id, manufacturer_id,supplier_id) like '%" + textBox14.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
        }

        private void DeleteRow()
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows[index].Visible = false;

            dataGridView2.Rows[index].Cells[6].Value = RowState.Deleted;

        }

        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM Products WHERE id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());

                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modifed)
                {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var title = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var category_id = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var storage_method_id = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    var manufacturer_id = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    var supplier_id = dataGridView2.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"UPDATE Products SET title = '{title}', category_id = {category_id}, storage_method_id = {storage_method_id}, manufacturer_id = {manufacturer_id}, supplier_id = {supplier_id} WHERE id={id}";


                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();

                }
            }

            dataBase.closeConnection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update();
        }

        //private void Change()
        //{
        //    var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

        //    var id = textBox13.Text;
        //    var title = textBox12.Text;
        //    var category_id = textBox11.Text;
        //    var storage_method_id = textBox10.Text;
        //    var manufacturer_id = textBox9.Text;
        //    var supplier_id = textBox8.Text;

        //    if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
        //    {
        //        dataGridView2.Rows[selectedRowIndex].SetValues(id, title, category_id, storage_method_id, manufacturer_id, supplier_id);
        //        dataGridView2.Rows[selectedRowIndex].Cells[6].Value = RowState.Modifed;
        //    }
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                textBox13.Text = row.Cells[0].Value.ToString();
                textBox12.Text = row.Cells[1].Value.ToString();
                textBox11.Text = row.Cells[2].Value.ToString();
                textBox10.Text = row.Cells[3].Value.ToString();
                textBox9.Text = row.Cells[4].Value.ToString();
                textBox8.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
