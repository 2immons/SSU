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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehousesUI_task8
{
    
    enum RowState
    {
        Existed,
        New,
        Modifed,
        ModifedNew,
        Deleted
    }

    public partial class TablesListForm : Form
    {
        DataBase dataBase = new DataBase();
        bool isUser = Program.globals.IsUser;
        bool isAdmin = Program.globals.IsAdmin;

        public TablesListForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(237, 233, 223);
        }

        private void TablesListAdmin_Load(object sender, EventArgs e)
        {
            myDataGridView.Refresh();
            if (isUser)
            {
                labelRole.Text = "ПОЛЬЗОВАТЕЛЬ";
            }
            else if (isAdmin)
                labelRole.Text = "АДМИНИСТРАТОР";
            buttonRefresh.Visible = false;

            textBox1.Visible = false; label1.Visible = false;
            textBox2.Visible = false; label2.Visible = false;
            textBox3.Visible = false; label3.Visible = false;
            textBox4.Visible = false; label4.Visible = false;
            textBox5.Visible = false; label5.Visible = false;
            textBox6.Visible = false; label6.Visible = false;
            textBox7.Visible = false; label7.Visible = false;
            buttonDelete.Visible = false;
            buttonUpdate.Visible = false;
            buttonCreate.Visible = false;
            buttonClearFields.Visible = false;
            panel1.Visible = false;
        }

        private void buttonChangeTable_Click(object sender, EventArgs e)
        {
            ClearFields();
            if (radioProducts.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("id", "ID");
                myDataGridView.Columns.Add("title", "Название");
                myDataGridView.Columns.Add("category_id", "ID категории");
                myDataGridView.Columns.Add("storage_method_id", "ID метода хранения");
                myDataGridView.Columns.Add("manufacturer_id", "ID производителя");
                myDataGridView.Columns.Add("supplier_id", "ID поставщика");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);

                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "Название";
                textBox3.Visible = true; label3.Visible = true; label3.Text = "ID категории";
                textBox4.Visible = true; label4.Visible = true; label4.Text = "ID метода хранения";
                textBox5.Visible = true; label5.Visible = true; label5.Text = "ID производителя";
                textBox6.Visible = true; label6.Visible = true; label6.Text = "ID поставщика";
                textBox7.Visible = false; label7.Visible = false;
                buttonCreate.Visible = true;
                buttonDelete.Visible = true;
                buttonUpdate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else if (radioSupplyLog.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("id", "ID");
                myDataGridView.Columns.Add("product_id", "ID продукта");
                myDataGridView.Columns.Add("supply_date", "Дата поставки");
                myDataGridView.Columns.Add("price", "Цена поставки");
                myDataGridView.Columns.Add("quantity", "Объем поставки");
                myDataGridView.Columns.Add("supplier_id", "ID поставщика");
                myDataGridView.Columns.Add("warehouse_to_id", "ID склада");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);
                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "Название продукта";
                textBox3.Visible = true; label3.Visible = true; label3.Text = "Дата поставки";
                textBox4.Visible = true; label4.Visible = true; label4.Text = "Цена поставки";
                textBox5.Visible = true; label5.Visible = true; label5.Text = "Объем поставки";
                textBox6.Visible = true; label6.Visible = true; label6.Text = "ID поставщика";
                textBox7.Visible = true; label7.Visible = true; label7.Text = "ID склада";
                if (isUser)
                {
                    buttonDelete.Visible = false;
                    buttonUpdate.Visible = false;
                }
                else if (isAdmin)
                {
                    buttonDelete.Visible = true;
                    buttonUpdate.Visible = true;
                }
                buttonCreate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else if (radioShippingLog.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("id", "ID");
                myDataGridView.Columns.Add("product_id", "ID продукта");
                myDataGridView.Columns.Add("shipping_date", "Дата отгрузки");
                myDataGridView.Columns.Add("price", "Цена отгрузки");
                myDataGridView.Columns.Add("quantity", "Объем отгрузки");
                myDataGridView.Columns.Add("buyer_id", "ID покупателя");
                myDataGridView.Columns.Add("warehouse_to_id", "ID склада");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);
                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "ID продукта";
                textBox3.Visible = true; label3.Visible = true; label3.Text = "Дата отгрузки";
                textBox4.Visible = true; label4.Visible = true; label4.Text = "Цена отгрузки";
                textBox5.Visible = true; label5.Visible = true; label5.Text = "Объем отгрузки";
                textBox6.Visible = true; label6.Visible = true; label6.Text = "ID покупателя";
                textBox7.Visible = true; label7.Visible = true; label7.Text = "ID склада";
                if (isUser)
                {
                    buttonDelete.Visible = false;
                    buttonUpdate.Visible = false;
                }
                else if (isAdmin)
                {
                    buttonDelete.Visible = true;
                    buttonUpdate.Visible = true;
                }
                buttonCreate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else if (radioTransfers.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("product_id", "ID продукта");
                myDataGridView.Columns.Add("warehouse_from_id", "ID склада отправки");
                myDataGridView.Columns.Add("warehouse_to_id", "ID склада назначения");
                myDataGridView.Columns.Add("transfer_date", "Дата перевозки");
                myDataGridView.Columns.Add("quantity", "Объем трансфера");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);
                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID продукта";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "ID склада отправки";
                textBox3.Visible = true; label3.Visible = true; label3.Text = "ID склада назначения";
                textBox4.Visible = true; label4.Visible = true; label4.Text = "Дата перевозки";
                textBox5.Visible = true; label5.Visible = true; label5.Text = "Объем трансфера";
                textBox6.Visible = false; label6.Visible = false;
                textBox7.Visible = false; label7.Visible = false;
                if (isUser)
                {
                    buttonDelete.Visible = false;
                    buttonUpdate.Visible = false;
                }
                else if (isAdmin)
                {
                    buttonDelete.Visible = true;
                    buttonUpdate.Visible = true;
                }
                buttonCreate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else if (radioStorage.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("product_id", "ID");
                myDataGridView.Columns.Add("warehouse_id", "ID склада");
                myDataGridView.Columns.Add("storage_method_id", "ID метода хранения");
                myDataGridView.Columns.Add("quantity", "Количество");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);
                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "ID склада";
                textBox3.Visible = true; label3.Visible = true; label3.Text = "ID метода хранения";
                textBox4.Visible = true; label4.Visible = true; label4.Text = "Количество";
                textBox5.Visible = false; label5.Visible = false;
                textBox6.Visible = false; label6.Visible = false;
                textBox7.Visible = false; label7.Visible = false;

                buttonDelete.Visible = true;
                buttonUpdate.Visible = true;
                buttonCreate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else if (radioWarehouses.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("id", "ID");
                myDataGridView.Columns.Add("storage_method_id", "ID метода хранения");
                myDataGridView.Columns.Add("adress", "Адрес");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);
                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "ID метода хранения";
                textBox3.Visible = true; label3.Visible = true; label3.Text = "Адрес";
                textBox4.Visible = false; label4.Visible = false;
                textBox5.Visible = false; label5.Visible = false;
                textBox6.Visible = false; label6.Visible = false;
                textBox7.Visible = false; label7.Visible = false;

                buttonDelete.Visible = true;
                buttonUpdate.Visible = true;
                buttonCreate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else if (radioSuppliers.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("id", "ID");
                myDataGridView.Columns.Add("name", "Наименование поставщика");
                myDataGridView.Columns.Add("INN", "ИНН");
                myDataGridView.Columns.Add("OGRN", "ОГРН");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);
                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "Наименование поставщика";
                textBox3.Visible = true; label3.Visible = true; label3.Text = "ИНН";
                textBox4.Visible = true; label4.Visible = true; label4.Text = "ОГРН";
                textBox5.Visible = false; label5.Visible = false;
                textBox6.Visible = false; label6.Visible = false;
                textBox7.Visible = false; label7.Visible = false;

                buttonDelete.Visible = true;
                buttonUpdate.Visible = true;
                buttonCreate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else if (radioBuyers.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("id", "ID");
                myDataGridView.Columns.Add("name", "Наименование покупателя");
                myDataGridView.Columns.Add("INN", "ИНН");
                myDataGridView.Columns.Add("OGRN", "ОГРН");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);
                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "Наименование покупателя";
                textBox3.Visible = true; label3.Visible = true; label3.Text = "ИНН";
                textBox4.Visible = true; label4.Visible = true; label4.Text = "ОГРН";
                textBox5.Visible = false; label5.Visible = false;
                textBox6.Visible = false; label6.Visible = false;
                textBox7.Visible = false; label7.Visible = false;

                buttonDelete.Visible = true;
                buttonUpdate.Visible = true;
                buttonCreate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else if (radioManufacturers.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("id", "ID");
                myDataGridView.Columns.Add("name", "Наименование производителя");
                myDataGridView.Columns.Add("INN", "ИНН");
                myDataGridView.Columns.Add("OGRN", "ОГРН");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);
                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "Наименование производителя";
                textBox3.Visible = true; label3.Visible = true; label3.Text = "ИНН";
                textBox4.Visible = true; label4.Visible = true; label4.Text = "ОГРН";
                textBox5.Visible = false; label5.Visible = false;
                textBox6.Visible = false; label6.Visible = false;
                textBox7.Visible = false; label7.Visible = false;

                buttonDelete.Visible = true;
                buttonUpdate.Visible = true;
                buttonCreate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else if (radioStorageMethods.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("id", "ID");
                myDataGridView.Columns.Add("title", "Наименование метода");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);
                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "Наименование метода";
                textBox3.Visible = false; label3.Visible = false;
                textBox4.Visible = false; label4.Visible = false;
                textBox5.Visible = false; label5.Visible = false;
                textBox6.Visible = false; label6.Visible = false;
                textBox7.Visible = false; label7.Visible = false;

                buttonDelete.Visible = true;
                buttonUpdate.Visible = true;
                buttonCreate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else if (radioCategories.Checked)
            {
                myDataGridView.Rows.Clear();
                myDataGridView.Columns.Clear();
                myDataGridView.Columns.Add("id", "ID");
                myDataGridView.Columns.Add("title", "Наименование категории");
                myDataGridView.Columns.Add("IsNew", String.Empty);
                RefreshDataGrid(myDataGridView);
                textBox1.Visible = true; label1.Visible = true; label1.Text = "ID";
                textBox2.Visible = true; label2.Visible = true; label2.Text = "Наименование категории";
                textBox3.Visible = false; label3.Visible = false;
                textBox4.Visible = false; label4.Visible = false;
                textBox5.Visible = false; label5.Visible = false;
                textBox6.Visible = false; label6.Visible = false;
                textBox7.Visible = false; label7.Visible = false;

                buttonDelete.Visible = true;
                buttonUpdate.Visible = true;
                buttonCreate.Visible = true;
                buttonClearFields.Visible = true;
                buttonRefresh.Visible = true;
                panel1.Visible = true;
            }
            else MessageBox.Show("Выберите таблицу!");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            if (radioProducts.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), RowState.ModifedNew);
            
            else if (radioSupplyLog.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetDateTime(2).ToString("yyyy-MM-dd"), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetInt32(6), RowState.ModifedNew);
            
            else if (radioShippingLog.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetDateTime(2).ToString("yyyy-MM-dd"), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetInt32(6), RowState.ModifedNew);
            
            else if (radioStorage.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), RowState.ModifedNew);
           
            else if (radioTransfers.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetDateTime(3).ToString("yyyy-MM-dd"), record.GetInt32(4), RowState.ModifedNew);
            
            else if (radioWarehouses.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), RowState.ModifedNew);
            
            else if (radioSuppliers.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifedNew);
            
            else if (radioBuyers.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifedNew);
            
            else if (radioManufacturers.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifedNew);
           
            else if (radioStorageMethods.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifedNew);
            
            else if (radioCategories.Checked)
                dgv.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifedNew);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = "";

            if (radioProducts.Checked) queryString = $"SELECT * FROM Products";

            else if (radioSupplyLog.Checked) queryString = $"SELECT * FROM SupplyLog";

            else if (radioShippingLog.Checked) queryString = $"SELECT * FROM ShippingLog";
            
            else if (radioStorage.Checked) queryString = $"SELECT * FROM ProductsStorage";
           
            else if (radioTransfers.Checked) queryString = $"SELECT * FROM ProductsTransfer";
       
            else if (radioWarehouses.Checked) queryString = $"SELECT * FROM Warehouses";
       
            else if (radioSuppliers.Checked) queryString = $"SELECT * FROM Suppliers";
       
            else if (radioBuyers.Checked) queryString = $"SELECT * FROM Buyers";
        
            else if (radioManufacturers.Checked) queryString = $"SELECT * FROM Manufacturers";
       
            else if (radioStorageMethods.Checked) queryString = $"SELECT * FROM StorageMethods";
        
            else if (radioCategories.Checked) queryString = $"SELECT * FROM ProductCategories";
          

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                ReadSingleRow(dgv, reader);

            reader.Close();
        }

        private void ClearFields()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }

        private void buttonClearFields_Click(object sender, EventArgs e) => ClearFields();

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            myDataGridView.Rows.Clear();

            string searchString = string.Empty;

            if (radioProducts.Checked)
                searchString = $"select * from Products where concat (id, title, category_id, storage_method_id, manufacturer_id,supplier_id) like '%" + textBox_search.Text + "%'";

            else if (radioSupplyLog.Checked)
                searchString = $"select * from SupplyLog where concat (id, product_id, supply_date, price, quantity, supplier_id, warehouse_to_id) like '%" + textBox_search.Text + "%'";

            else if (radioShippingLog.Checked)
                searchString = $"select * from ShippingLog where concat (id, product_id, shipping_date, price, quantity, buyer_id, warehouse_from_id) like '%" + textBox_search.Text + "%'";

            else if (radioStorage.Checked)
                searchString = $"select * from ProductsStorage where concat (product_id, warehouse_id, storage_method_id, quantity) like '%" + textBox_search.Text + "%'";

            else if (radioTransfers.Checked)
                searchString = $"select * from ProductsTransfer where concat (product_id, warehouse_from_id, warehouse_to_id, transfer_date, quantity) like '%" + textBox_search.Text+ "%'";

            else if (radioWarehouses.Checked)
                searchString = $"select * from Warehouses where concat (id, storage_method_id, adress) like '%" + textBox_search.Text + "%'";

            else if (radioSuppliers.Checked)
                searchString = $"select * from Suppliers where concat (id, name, INN, OGRN) like '%" + textBox_search.Text + "%'";

            else if (radioBuyers.Checked)
                searchString = $"select * from Buyers where concat (id, name, INN, OGRN) like '%" + textBox_search.Text + "%'";

            else if (radioManufacturers.Checked)
                searchString = $"select * from Manufacturers where concat (id, name, INN, OGRN) like '%" + textBox_search.Text + "%'";

            else if (radioStorageMethods.Checked)
                searchString = $"select * from StorageMethods where concat (id, title) like '%" + textBox_search.Text + "%'";

            else if (radioCategories.Checked)
                searchString = $"select * from ProductCategories where concat (id, title) like '%" + textBox_search.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                ReadSingleRow(myDataGridView, reader);

            reader.Close();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = myDataGridView.CurrentCell.RowIndex;

            myDataGridView.Rows[index].Visible = true;

            if (radioProducts.Checked) myDataGridView.Rows[index].Cells[6].Value = RowState.Deleted;

            else if (radioSupplyLog.Checked) myDataGridView.Rows[index].Cells[7].Value = RowState.Deleted;

            else if (radioShippingLog.Checked) myDataGridView.Rows[index].Cells[7].Value = RowState.Deleted;

            else if (radioStorage.Checked) myDataGridView.Rows[index].Cells[4].Value = RowState.Deleted;

            else if (radioTransfers.Checked) myDataGridView.Rows[index].Cells[5].Value = RowState.Deleted;

            else if (radioWarehouses.Checked) myDataGridView.Rows[index].Cells[3].Value = RowState.Deleted;

            else if (radioSuppliers.Checked) myDataGridView.Rows[index].Cells[4].Value = RowState.Deleted;

            else if (radioBuyers.Checked) myDataGridView.Rows[index].Cells[4].Value = RowState.Deleted;

            else if (radioManufacturers.Checked) myDataGridView.Rows[index].Cells[4].Value = RowState.Deleted;

            else if (radioStorageMethods.Checked) myDataGridView.Rows[index].Cells[2].Value = RowState.Deleted;

            else if (radioCategories.Checked) myDataGridView.Rows[index].Cells[2].Value = RowState.Deleted;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            for (int index = 0; index < myDataGridView.Rows.Count; index++)
            {
                var rowState = new RowState();

                if (radioProducts.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[6].Value;

                else if (radioSupplyLog.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[7].Value;

                else if (radioShippingLog.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[7].Value;

                else if (radioStorage.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[4].Value;
                    
                else if (radioTransfers.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[5].Value;

                else if (radioWarehouses.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[3].Value;
                    
                else if (radioSuppliers.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[4].Value;
                    
                else if (radioBuyers.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[4].Value;
                    
                else if (radioManufacturers.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[4].Value;
                    
                else if (radioStorageMethods.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[2].Value;
                    
                else if (radioCategories.Checked) rowState = (RowState)myDataGridView.Rows[index].Cells[2].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(myDataGridView.Rows[index].Cells[0].Value);
                    var deleteQuery = string.Empty;

                    if (radioProducts.Checked) deleteQuery = $"DELETE FROM Products WHERE id = {id}";

                    else if (radioSupplyLog.Checked) deleteQuery = $"DELETE FROM SupplyLog WHERE id = {id}";

                    else if (radioShippingLog.Checked) deleteQuery = $"DELETE FROM ShippingLog WHERE id = {id}";

                    else if (radioStorage.Checked) deleteQuery = $"DELETE FROM ProductsStorage WHERE product_id = {id}";

                    else if (radioTransfers.Checked) deleteQuery = $"DELETE FROM ProductsTransfer WHERE product_id = {id}";

                    else if (radioWarehouses.Checked) deleteQuery = $"DELETE FROM Warehouses WHERE id = {id}";

                    else if (radioSuppliers.Checked) deleteQuery = $"DELETE FROM Suppliers WHERE id = {id}";

                    else if (radioBuyers.Checked) deleteQuery = $"DELETE FROM Buyers WHERE id = {id}";

                    else if (radioManufacturers.Checked) deleteQuery = $"DELETE FROM Manufacturers WHERE id = {id}";

                    else if (radioStorageMethods.Checked) deleteQuery = $"DELETE FROM StorageMethods WHERE id = {id}";

                    else if (radioCategories.Checked) deleteQuery = $"DELETE FROM ProductCategories WHERE id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modifed)
                {
                    var updateQuery = string.Empty;
                    if (radioProducts.Checked)
                    {
                        var id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var title = myDataGridView.Rows[index].Cells[1].Value.ToString();
                        var category_id = myDataGridView.Rows[index].Cells[2].Value.ToString();
                        var storage_method_id = myDataGridView.Rows[index].Cells[3].Value.ToString();
                        var manufacturer_id = myDataGridView.Rows[index].Cells[4].Value.ToString();
                        var supplier_id = myDataGridView.Rows[index].Cells[5].Value.ToString();

                        updateQuery = $"UPDATE Products SET title = '{title}', category_id = {category_id}, storage_method_id = {storage_method_id}, manufacturer_id = {manufacturer_id}, supplier_id = {supplier_id} WHERE id={id}";
                    }
                    else if (radioSupplyLog.Checked)
                    {
                        var id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var product_id = myDataGridView.Rows[index].Cells[1].Value.ToString();
                        var supply_date = myDataGridView.Rows[index].Cells[2].Value.ToString();
                        var price = myDataGridView.Rows[index].Cells[3].Value.ToString();
                        var quantity = myDataGridView.Rows[index].Cells[4].Value.ToString();
                        var supplier_id = myDataGridView.Rows[index].Cells[5].Value.ToString();
                        var warehouse_to_id = myDataGridView.Rows[index].Cells[5].Value.ToString();

                        updateQuery = $"UPDATE SupplyLog SET product_id = {product_id}, supply_date = '{supply_date}', price = {price}, quantity = {quantity}, supplier_id = {supplier_id}, warehouse_to_id = {warehouse_to_id}  WHERE id={id}";
                    }
                    else if (radioShippingLog.Checked)
                    {
                        var id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var product_id = myDataGridView.Rows[index].Cells[1].Value.ToString();
                        var shipping_date = myDataGridView.Rows[index].Cells[2].Value.ToString();
                        var price = myDataGridView.Rows[index].Cells[3].Value.ToString();
                        var quantity = myDataGridView.Rows[index].Cells[4].Value.ToString();
                        var buyer_id = myDataGridView.Rows[index].Cells[5].Value.ToString();
                        var warehouse_from_id = myDataGridView.Rows[index].Cells[5].Value.ToString();

                        updateQuery = $"UPDATE ShippingLog SET product_id = {product_id}, shipping_date = '{shipping_date}', price = {price}, quantity = {quantity}, buyer_id = {buyer_id}, warehouse_from_id = {warehouse_from_id} WHERE id={id}";
                    }
                    else if (radioTransfers.Checked)
                    {
                        var product_id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var warehouse_from_id = myDataGridView.Rows[index].Cells[1].Value.ToString();
                        var warehouse_to_id = myDataGridView.Rows[index].Cells[2].Value.ToString();
                        var transfer_date = myDataGridView.Rows[index].Cells[3].Value.ToString();
                        var quantity = myDataGridView.Rows[index].Cells[4].Value.ToString();

                        updateQuery = $"UPDATE ProductsTransfer SET warehouse_from_id = '{warehouse_from_id}', warehouse_to_id = {warehouse_to_id}, transfer_date = {transfer_date}, manufquantityacturer_id = {quantity} WHERE product_id={product_id}";
                    }
                    else if (radioStorage.Checked)
                    {
                        var product_id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var warehouse_id = myDataGridView.Rows[index].Cells[1].Value.ToString();
                        var storage_method_id = myDataGridView.Rows[index].Cells[2].Value.ToString();
                        var quantity = myDataGridView.Rows[index].Cells[3].Value.ToString();

                        updateQuery = $"UPDATE ProductsStorage SET warehouse_id = {warehouse_id}, storage_method_id = {storage_method_id}, quantity = {quantity} WHERE product_id={product_id}";
                    }
                    else if (radioWarehouses.Checked)
                    {
                        var id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var storage_method_id = myDataGridView.Rows[index].Cells[1].Value.ToString();
                        var adress = myDataGridView.Rows[index].Cells[2].Value.ToString();

                        updateQuery = $"UPDATE Warehouses SET storage_method_id = '{storage_method_id}', adress = '{adress}' WHERE id={id}";
                    }
                    else if (radioSuppliers.Checked)
                    {
                        var id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var name = myDataGridView.Rows[index].Cells[1].Value.ToString();
                        var INN = myDataGridView.Rows[index].Cells[2].Value.ToString();
                        var OGRN = myDataGridView.Rows[index].Cells[3].Value.ToString();

                        updateQuery = $"UPDATE Suppliers SET name = '{name}', INN = '{INN}', OGRN = '{OGRN}' WHERE id={id}";
                    }
                    else if (radioBuyers.Checked)
                    {
                        var id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var name = myDataGridView.Rows[index].Cells[1].Value.ToString();
                        var INN = myDataGridView.Rows[index].Cells[2].Value.ToString();
                        var OGRN = myDataGridView.Rows[index].Cells[3].Value.ToString();

                        updateQuery = $"UPDATE Buyers SET name = '{name}', INN = '{INN}', OGRN = '{OGRN}' WHERE id={id}";
                    }
                    else if (radioManufacturers.Checked)
                    {
                        var id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var name = myDataGridView.Rows[index].Cells[1].Value.ToString();
                        var INN = myDataGridView.Rows[index].Cells[2].Value.ToString();
                        var OGRN = myDataGridView.Rows[index].Cells[3].Value.ToString();

                        updateQuery = $"UPDATE Manufacturers SET name = '{name}', INN = '{INN}', OGRN = '{OGRN}' WHERE id={id}";
                    }
                    else if (radioStorageMethods.Checked)
                    {
                        var id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var title = myDataGridView.Rows[index].Cells[1].Value.ToString();

                        updateQuery = $"UPDATE StorageMethods SET title = '{title}' WHERE id={id}";
                    }
                    else if (radioCategories.Checked)
                    {
                        var id = myDataGridView.Rows[index].Cells[0].Value.ToString();
                        var title = myDataGridView.Rows[index].Cells[1].Value.ToString();

                        updateQuery = $"UPDATE ProductCategories SET title = '{title}' WHERE id={id}";
                    }

                    var command = new SqlCommand(updateQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            dataBase.closeConnection();
            ClearFields();
            RefreshDataGrid(myDataGridView);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = myDataGridView.CurrentCell.RowIndex;

            if (radioProducts.Checked)
            {
                var id = textBox1.Text;
                var title = textBox2.Text;
                var category_id = textBox3.Text;
                var storage_method_id = textBox4.Text;
                var manufacturer_id = textBox5.Text;
                var supplier_id = textBox6.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(id, title, category_id, storage_method_id, manufacturer_id, supplier_id);
                    myDataGridView.Rows[selectedRowIndex].Cells[6].Value = RowState.Modifed;
                }
            }
            else if (radioSupplyLog.Checked)
            {
                var id = textBox1.Text;
                var product_id = textBox2.Text;
                var supply_date = textBox3.Text;
                var price = textBox4.Text;
                var quantity = textBox5.Text;
                var supplier_id = textBox6.Text;
                var warehouse_to_id = textBox7.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(id, product_id, supply_date, price, quantity, supplier_id, warehouse_to_id);
                    myDataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modifed;
                }
            }
            else if (radioShippingLog.Checked)
            {
                var id = textBox1.Text;
                var product_id = textBox2.Text;
                var shipping_date = textBox3.Text;
                var price = textBox4.Text;
                var quantity = textBox5.Text;
                var buyer_id = textBox6.Text;
                var warehouse_from_id = textBox7.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(id, product_id, shipping_date, price, quantity, buyer_id, warehouse_from_id);
                    myDataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modifed;
                }
            }
            else if (radioStorage.Checked)
            {
                var product_id = textBox1.Text;
                var warehouse_id = textBox2.Text;
                var storage_method_id = textBox3.Text;
                var quantity = textBox4.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(product_id, warehouse_id, storage_method_id, quantity);
                    myDataGridView.Rows[selectedRowIndex].Cells[4].Value = RowState.Modifed;
                }
            }
            else if (radioTransfers.Checked)
            {
                var product_id = textBox1.Text;
                var warehouse_from_id = textBox2.Text;
                var warehouse_to_id = textBox3.Text;
                var transfer_date = textBox4.Text;
                var quantity = textBox5.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(product_id, warehouse_from_id, warehouse_to_id, transfer_date, quantity);
                    myDataGridView.Rows[selectedRowIndex].Cells[5].Value = RowState.Modifed;
                }
            }
            else if (radioWarehouses.Checked)
            {
                var id = textBox1.Text;
                var storage_method_id = textBox2.Text;
                var adress = textBox3.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(id, storage_method_id, adress);
                    myDataGridView.Rows[selectedRowIndex].Cells[3].Value = RowState.Modifed;
                }
            }
            else if (radioSuppliers.Checked)
            {
                var id = textBox1.Text;
                var name = textBox2.Text;
                var INN = textBox3.Text;
                var OGRN = textBox4.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(id, name, INN, OGRN);
                    myDataGridView.Rows[selectedRowIndex].Cells[4].Value = RowState.Modifed;
                }
            }
            else if (radioBuyers.Checked)
            {
                var id = textBox1.Text;
                var name = textBox2.Text;
                var INN = textBox3.Text;
                var OGRN = textBox4.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(id, name, INN, OGRN);
                    myDataGridView.Rows[selectedRowIndex].Cells[4].Value = RowState.Modifed;
                }
            }
            else if (radioManufacturers.Checked)
            {
                var id = textBox1.Text;
                var name = textBox2.Text;
                var INN = textBox3.Text;
                var OGRN = textBox4.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(id, name, INN, OGRN);
                    myDataGridView.Rows[selectedRowIndex].Cells[4].Value = RowState.Modifed;
                }
            }
            else if (radioStorageMethods.Checked)
            {
                var id = textBox1.Text;
                var title = textBox2.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(id, title);
                    myDataGridView.Rows[selectedRowIndex].Cells[2].Value = RowState.Modifed;
                }
            }
            else if (radioCategories.Checked)
            {
                var id = textBox1.Text;
                var title = textBox2.Text;

                if (myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    myDataGridView.Rows[selectedRowIndex].SetValues(id, title);
                    myDataGridView.Rows[selectedRowIndex].Cells[2].Value = RowState.Modifed;
                }
            }
        }

        private void myDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) // проверить
        {
            var selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = myDataGridView.Rows[selectedRow];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                if (radioProducts.Checked || radioSupplyLog.Checked || radioShippingLog.Checked || radioManufacturers.Checked || radioSuppliers.Checked || radioBuyers.Checked || radioWarehouses.Checked || radioTransfers.Checked || radioStorage.Checked)
                {
                    textBox3.Text = row.Cells[2].Value.ToString();
                    if (radioProducts.Checked || radioSupplyLog.Checked || radioShippingLog.Checked || radioManufacturers.Checked || radioSuppliers.Checked || radioBuyers.Checked || radioTransfers.Checked || radioStorage.Checked)
                    {
                        textBox4.Text = row.Cells[3].Value.ToString();
                        if (radioProducts.Checked || radioSupplyLog.Checked || radioShippingLog.Checked || radioTransfers.Checked)
                        {
                            textBox5.Text = row.Cells[4].Value.ToString();
                            if (radioProducts.Checked || radioSupplyLog.Checked || radioShippingLog.Checked)
                            {
                                textBox6.Text = row.Cells[5].Value.ToString();
                                if (radioSupplyLog.Checked || radioShippingLog.Checked)
                                {
                                    textBox7.Text = row.Cells[6].Value.ToString();
                                }
                            }
                        }
                    }
                }
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(myDataGridView);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var addQuery = string.Empty;

            if (radioProducts.Checked)
            {
                var title = textBox2.Text;
                var category_id = textBox3.Text;
                var storage_method_id = textBox4.Text;
                var manufacturer_id = textBox5.Text;
                var supplier_id = textBox6.Text;

                addQuery = $"INSERT INTO Products(title,category_id, storage_method_id, manufacturer_id,supplier_id) VALUES ('{title}','{category_id}',{storage_method_id},{manufacturer_id},{supplier_id})";
            }
            else if (radioSupplyLog.Checked)
            {
                var product_id = textBox2.Text;
                var supply_date = textBox3.Text;
                var price = textBox4.Text;
                var quantity = textBox5.Text;
                var supplier_id = textBox6.Text;
                var warehouse_to_id = textBox7.Text;

                addQuery = $"INSERT INTO SupplyLog(product_id,supply_date, price, quantity,supplier_id,warehouse_to_id) VALUES ({product_id},'{supply_date}',{price},{quantity},{supplier_id}, {warehouse_to_id})";
            }
            else if (radioShippingLog.Checked)
            {
                var product_id = textBox2.Text;
                var shipping_date = textBox3.Text;
                var price = textBox4.Text;
                var quantity = textBox5.Text;
                var buyer_id = textBox6.Text;
                var warehouse_from_id = textBox7.Text;

                addQuery = $"INSERT INTO ShippingLog(product_id,shipping_date, price, quantity,buyer_id, warehouse_from_id) VALUES ({product_id},'{shipping_date}',{price},{quantity},{buyer_id}, {warehouse_from_id})";
            }
            else if (radioStorage.Checked)
            {
                var product_id = textBox1.Text;
                var warehouse_id = textBox2.Text;
                var storage_method_id = textBox3.Text;
                var quantity = textBox4.Text;

                addQuery = $"INSERT INTO ProductsStorage(product_id, warehouse_id, storage_method_id,quantity) VALUES ({product_id},{warehouse_id},{storage_method_id},{quantity})";
            }
            else if (radioTransfers.Checked)
            {
                var product_id = textBox1.Text;
                var warehouse_from_id = textBox2.Text;
                var warehouse_to_id = textBox3.Text;
                var transfer_date = textBox4.Text;
                var quantity = textBox5.Text;

                addQuery = $"INSERT INTO ProductsTransfer(product_id,warehouse_from_id, warehouse_to_id, transfer_date, quantity) VALUES ({product_id},{warehouse_from_id},{warehouse_to_id},'{transfer_date}',{quantity})";
            }
            else if (radioWarehouses.Checked)
            {
                var storage_method_id = textBox2.Text;
                var adress = textBox3.Text;

                addQuery = $"INSERT INTO Warehouses(storage_method_id,adress) VALUES ({storage_method_id},'{adress}')";
            }
            else if (radioSuppliers.Checked)
            {
                var name = textBox2.Text;
                var INN = textBox3.Text;
                var OGRN = textBox4.Text;

                addQuery = $"INSERT INTO Suppliers(name,INN, OGRN) VALUES ('{name}','{INN}','{OGRN}')";
            }
            else if (radioBuyers.Checked)
            {
                var name = textBox2.Text;
                var INN = textBox3.Text;
                var OGRN = textBox4.Text;

                addQuery = $"INSERT INTO Buyers(name,INN, OGRN) VALUES ('{name}','{INN}','{OGRN}')";
            }
            else if (radioManufacturers.Checked)
            {
                var name = textBox2.Text;
                var INN = textBox3.Text;
                var OGRN = textBox4.Text;

                addQuery = $"INSERT INTO Manufacturers(name,INN, OGRN) VALUES ('{name}','{INN}','{OGRN}')";
            }
            else if (radioStorageMethods.Checked)
            {
                var title = textBox2.Text;

                addQuery = $"INSERT INTO StorageMethods(title) VALUES ('{title}')";
            }
            else if (radioCategories.Checked)
            {
                var title = textBox2.Text;

                addQuery = $"INSERT INTO ProductCategories(title) VALUES ('{title}')";
            }

            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана!");

            dataBase.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPriceDifferenceReportForm getPriceDifferenceReportForm = new GetPriceDifferenceReportForm();
            getPriceDifferenceReportForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuantityInWarehouseForm quantityInWarehouseForm = new QuantityInWarehouseForm();
            quantityInWarehouseForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetSumShippingByDateForm getSumShippingByDateForm = new GetSumShippingByDateForm();
            getSumShippingByDateForm.Show();
        }
    }
}
