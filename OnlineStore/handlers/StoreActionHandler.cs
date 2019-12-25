﻿using System;
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
        private MerchantHandler merchantHandler;
        private string connString;
        //private enum ACTIONTYPE { ADD, EDIT, DELETE };


        public StoreActionHandler(string connString)
        {
            dbConnection = new DBConnection(connString);
            dbConnection.Open();
            sqlConnection = dbConnection.GetSqlConnection();
            this.connString = connString;
        }

        public SqlCommand GetActionHistory(string storeName)
        {
            string query = "SELECT STOREACTIONS.AID, STOREACTIONS.[SID], APPROVEDPRODUCTS.PRODUCTNAME, STOREACTIONS.[STATEMENT], STOREACTIONS.QTY " +
                           "FROM STOREACTIONS, APPROVEDPRODUCTS WHERE STOREACTIONS.PID = APPROVEDPRODUCTS.PID " +
                           "AND STOREACTIONS.[SID] IN (SELECT [SID] FROM STORES WHERE STORES.STORENAME = '" + storeName + "');";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            return cmd;
        }

        public void SaveAction(User merchant, string storeName, string productName, int quantity, string action)
        {
            string merchantName = merchant.GetUserInfo().GetUsername();
            string query = "SELECT [SID] FROM STORES WHERE STORENAME = '" + storeName + "' AND OWNERUSR = '" + merchantName + "';";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            Int32 storeId = (Int32) cmd.ExecuteScalar();

            query = "SELECT PID FROM APPROVEDPRODUCTS WHERE PRODUCTNAME = '" + productName + "';";
            cmd = new SqlCommand(query, sqlConnection);
            Int32 productId = (Int32) cmd.ExecuteScalar();

            query = "INSERT INTO STOREACTIONS ([SID], PID, QTY, [STATEMENT]) VALUES ('" + storeId + "', '" + productId + "', '" + quantity + "', '" + action + "');";
            cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
        }

        public void UndoAction(User merchant, Int32 storeId, string productName, Int32 quantity, string action)
        {
            merchantHandler = new MerchantHandler(connString);
            string query = "SELECT STORENAME FROM STORES WHERE [SID] = '" + storeId + "';";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            string storeName = (string)cmd.ExecuteScalar();

            if (action.Equals("add"))
            {
                merchantHandler.DeleteProductFromStore(merchant, storeName, productName);
            }
            else if (action.Equals("delete"))
            {
                merchantHandler.AddProductToStore(productName, storeName, merchant, quantity);
            }
        }
        
        ~StoreActionHandler()
        {
            dbConnection.Dispose(false);
        }
    }
}
