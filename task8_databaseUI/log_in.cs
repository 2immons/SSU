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
    public partial class log_in : Form
    {
        DataBase dataBase = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableListAdmin tableListAdmin = new TableListAdmin();
            this.Hide();
            tableListAdmin.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableListUser tableListUser = new TableListUser();
            this.Hide();
            tableListUser.ShowDialog();
            this.Show();
        }
    }
}
