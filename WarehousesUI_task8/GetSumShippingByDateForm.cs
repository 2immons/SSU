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

namespace WarehousesUI_task8
{
    public partial class GetSumShippingByDateForm : Form
    {
        DataBase dataBase = new DataBase();

        public GetSumShippingByDateForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(237, 233, 223);
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reportQuery = $"EXEC GetSumOfShippingPriceByDate '{textBox1.Text.ToString()}'";
            var command = new SqlCommand(reportQuery, dataBase.getConnection());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                textBox2.Text = reader.GetInt32(0).ToString();

            reader.Close();

            dataBase.closeConnection();
        }
    }
}
