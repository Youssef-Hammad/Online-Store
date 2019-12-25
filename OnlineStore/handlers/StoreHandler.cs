using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OnlineStore
{
    class StoreHandler
    {
        private DBConnection dbConnection;
        private SqlConnection sqlConnection;

        public StoreHandler(string connString)
        {
            dbConnection = new DBConnection(connString);
            dbConnection.Open();
            sqlConnection = dbConnection.GetSqlConnection();
        }

        public bool AlreadyExists(Store store)
        {
            string storeName = store.GetStoreInfo().GetName();
            string storeLocation = store.GetStoreInfo().GetLocaction();

            string queryCheckExisting = "SELECT * FROM STORES WHERE STORENAME = '" + storeName + "' AND STORELOC = '" + storeLocation + "'";

            SqlCommand commandCheckExisting = new SqlCommand(queryCheckExisting, sqlConnection);

            string queryCheckPendingExisting = "SELECT * FROM PENDINGSTORES WHERE STORENAME = '" + storeName + "' AND STORELOC = '"+storeLocation+"'";

            SqlCommand commandCheckPendingExisting = new SqlCommand(queryCheckPendingExisting, sqlConnection);

            bool exist = true, pending = true;

            SqlDataReader reader = commandCheckExisting.ExecuteReader();

            if (!reader.Read())
                exist = false;
            reader.Close();
            reader = commandCheckPendingExisting.ExecuteReader();

            if (!reader.Read())
                pending = false;

            reader.Close();
            return (pending || exist);//returns true if store exists in STORES or in PENDINGSTORES
        }

        public bool AddPendingStore(Store store, User merchant)
        {
            string storeName = store.GetStoreInfo().GetName();
            string storeLocation = store.GetStoreInfo().GetLocaction();
            int storeType = (int)store.GetStoreInfo().GetStoreType();

            string ownerName = merchant.GetUserInfo().GetUsername();

            string queryInsertStore= "INSERT INTO PENDINGSTORES(STORENAME,OWNERNAME,STORELOC,STYPE) VALUES('"+storeName+"','"+ownerName+"','"+storeLocation+"',"+storeType.ToString()+")";

            SqlCommand commandInsertStore = new SqlCommand(queryInsertStore, sqlConnection);

            try
            {
                commandInsertStore.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool AddApprovedStore(Store store, string ownerName)
        {
            string storeName = store.GetStoreInfo().GetName();
            string storeLoc = store.GetStoreInfo().GetLocaction();
            int storeType = (int)store.GetStoreInfo().GetStoreType();

            string query = "INSERT INTO STORES VALUES ('" + storeName + "','" + storeLoc + "','" + ownerName + "','" + storeType + "');";

            SqlCommand commandInsertStore = new SqlCommand(query, sqlConnection);

            try
            {
                commandInsertStore.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }

        public bool RemoveFromPending(Store store)
        {
            string storeName = store.GetStoreInfo().GetName();
            string storeLoc = store.GetStoreInfo().GetLocaction();

            string query = "DELETE FROM PENDINGSTORES WHERE STORENAME = '" + storeName + "' AND STORELOC = '" + storeLoc + "';";
            SqlCommand commandInsertStore = new SqlCommand(query, sqlConnection);
            try
            {
                commandInsertStore.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }

        public bool AddProduct(Store store, Product product)
        {
            string pName = product.GetProductInfo().GetName();
            float pPrice = product.GetProductInfo().GetPrice();
            string pCategory = product.GetProductInfo().GetCategory();

            StoreInfo sInfo = store.GetStoreInfo();
            string sName = sInfo.GetName();

            string query = "SELECT FROM storesProducts WHERE STORENAME = '" + sName + "' AND PRODUCTNAME = '" + pName + "'";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
			if(cmd.ExecuteScalar() == null)
            {
                query = "INSERT INTO storeProducts(STORENAME,PRODUCTNAME) VALUES('" + sName + "','" + pName + "')";

                cmd = new SqlCommand(query, sqlConnection);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return false;
                }
            }
			else
            {
                return false;
            }
        }

        public List<string> GetStoreProducts(User merchant, string storeName)
        {
            string merchantName = merchant.GetUserInfo().GetUsername();
            string query = "SELECT PRODUCTNAME " +
                           "FROM APPROVEDPRODUCTS, PRODUCTSTOCK " +
                           "WHERE APPROVEDPRODUCTS.PID = PRODUCTSTOCK.PID " +
                           "AND PRODUCTSTOCK.[SID] IN ( SELECT [SID] FROM STORES " +
                           "WHERE STORENAME = '" + storeName + "' AND OWNERUSR = '" + merchantName + "');";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> productNames = new List<string>();
            while (reader.Read())
            {
                productNames.Add(reader.GetString(0));
            }
            reader.Close();
            return productNames;
        }

        ~StoreHandler()
        {
            dbConnection.Dispose(false);
        }
    }
}
