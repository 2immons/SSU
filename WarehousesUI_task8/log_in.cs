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

    public partial class log_in : Form
    {
        DataBase dataBase = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(237, 233, 223);
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.globals.IsAdmin = true;
            Program.globals.IsUser = false;
            TablesListForm tableListAdmin = new TablesListForm();
            this.Hide();
            tableListAdmin.ShowDialog();
            this.Show();
            Program.globals.IsUser = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.globals.IsUser = true;
            Program.globals.IsAdmin = false;
            TablesListForm tableListAdmin = new TablesListForm();
            this.Hide();
            tableListAdmin.ShowDialog();
            this.Show();
        }
    }
}
