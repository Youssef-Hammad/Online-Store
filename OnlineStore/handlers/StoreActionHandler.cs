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

        public void StoreAddAction(string storeName, string productName)
        {
            string query = "SELECT [SID] FROM STORES WHERE STORENAME = '" + storeName + "';";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            Int32 storeId = reader.GetInt32(0);

            query = "SELECT PID FROM STORES WHERE PRODUCTNAME = '" + productName + "';";
            cmd = new SqlCommand(query, sqlConnection);
            reader = cmd.ExecuteReader();
            Int32 productId = reader.GetInt32(0);

            string action = "ADD";

            query = "INSERT INTO STOREACTIONS VALUES('" + storeId + "','" + productId + "','" + action + "');";
            cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
        }

        ~StoreActionHandler()
        {
            dbConnection.Dispose(false);
        }
    }
}
