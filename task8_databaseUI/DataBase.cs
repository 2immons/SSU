using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace task8_databaseUI
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-S2PE4SN\\SQLEXPRESS;Database=Warehouses;Trusted_Connection=True;");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed) 
            { 
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
