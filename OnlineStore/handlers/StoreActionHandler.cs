using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class StoreActionHandler
    {
        private DBConnection dbConnection;
        private SqlConnection sqlConnection;
        private enum ACTIONTYPE { ADD, EDIT, DELETE };


        public StoreActionHandler(string connString)
        {
            dbConnection = new DBConnection(connString);
            dbConnection.Open();
            sqlConnection = dbConnection.GetSqlConnection();
        }

        public SqlCommand GetActionHistory(string storeName)
        {
            string query = "SELECT STOREACTIONS.AID, STOREACTIONS.[SID], APPROVEDPRODUCTS.PRODUCTNAME, STOREACTIONS.[STATEMENT] " +
                           "FROM STOREACTIONS, APPROVEDPRODUCTS WHERE STOREACTIONS.PID = APPROVEDPRODUCTS.PID " +
                           "AND STOREACTIONS.[SID] IN (SELECT [SID] FROM STORES WHERE STORES.STORENAME = '" + storeName + "');";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            return cmd;
        }

        ~StoreActionHandler()
        {
            dbConnection.Dispose(false);
        }
    }
}
