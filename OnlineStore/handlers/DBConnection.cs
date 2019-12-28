using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class DBConnection
    {
        private SqlConnection dbConnection;

        public DBConnection(string connString)
        {
            dbConnection = new SqlConnection(connString);
        }

        public void Open()
        {
            if(dbConnection != null)
            {
                dbConnection.Open();
            }
        }

        public SqlConnection GetSqlConnection()
        {
            return dbConnection;
        }

        protected void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                dbConnection.Close();
            }
        }

        ~DBConnection()
        {
            this.Dispose(false);
        }
    }
}
