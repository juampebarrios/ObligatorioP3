using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repositorio
{

    public class Conexion : IDbConnection
    {
        SqlConnection conn = null;

        //sql string mac:
      //  private string connectionString = "Server=tcp:127.0.0.1,1433;Database=ViveroP3;MultipleActiveResultSets=true;User=sa;Password=bigStrongPwd1997;";

        //sql string windows:
        private string connectionString = "data source=.\\; database=ViveroP3; Integrated Security = true";

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public int ConnectionTimeout => conn.ConnectionTimeout;

        public Conexion()
        {
            conn = new SqlConnection(connectionString);
        }
        public string Database => conn.Database;


        public ConnectionState State => conn.State;

        public IDbTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        public void ChangeDatabase(string databaseName)
        {
        }

        public void Close()
        {
            conn.Close();
        }

        public IDbCommand CreateCommand()
        {
            return conn.CreateCommand();
        }

        public void Dispose()
        {
            conn.Dispose();
        }

        public void Open()
        {
            conn.Open();
        }
    }
}
