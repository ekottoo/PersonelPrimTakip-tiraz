using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Sql
{
    public class SqlConnectionManager
    {
        private SqlConnection _connection;
        private string _connectionString; 

        public SqlConnectionManager()
        {

            _connectionString = "Server=MSI;Database=PersonelPrimTakipveItiraz;Trusted_Connection=True;";
            _connection = new SqlConnection(_connectionString);
        }

        public SqlConnection GetConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
            return _connection;
        }

        public void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }
    }
}
