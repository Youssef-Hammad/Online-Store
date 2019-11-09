using System;
using System.Data.SqlClient;

namespace OnlineStore
{
    class StoreHandler
    {
        private SqlConnection dbConnection;

        public StoreHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
            dbConnection.Open();
        }

        public bool alreadyExists(Store store)
        {
            string storeName = store.GetStoreInfo().GetName();
            string storeLocation = store.GetStoreInfo().GetLocaction();

            string queryCheckExisting = "SELECT * FROM STORES WHERE STORENAME = '" + storeName + "' AND STORELOC = '" + storeLocation + "'";

            SqlCommand commandCheckExisting = new SqlCommand(queryCheckExisting, dbConnection);

            string queryCheckPendingExisting = "SELECT * FROM PENDINGSTORES WHERE STORENAME = '" + storeName + "' AND STORELOC = '"+storeLocation+"'";

            SqlCommand commandCheckPendingExisting = new SqlCommand(queryCheckPendingExisting, dbConnection);

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

        public bool AddStore(Store store, User merchant)
        {
            string storeName = store.GetStoreInfo().GetName();
            string storeLocation = store.GetStoreInfo().GetLocaction();

            int storeType=0;
            STYPE tempType = store.GetStoreInfo().GetStoreType();
            if (tempType == (STYPE)1)
                storeType = 1;
            else if (tempType == (STYPE)2)
                storeType = 2;
            else if (tempType == (STYPE)3)
                storeType = 3;
            else if (tempType == (STYPE)4)
                storeType = 4;


            string ownerName = merchant.GetUserInfo().GetUsername();

            string queryInsertStore= "INSERT INTO PENDINGSTORES(STORENAME,OWNERNAME,STORELOC,STYPE) VALUES('"+storeName+"','"+ownerName+"','"+storeLocation+"',"+storeType.ToString()+")";

            SqlCommand commandInsertStore = new SqlCommand(queryInsertStore, dbConnection);

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

            SqlCommand cmd = new SqlCommand(query, dbConnection);
			if(cmd.ExecuteScalar()==null)
            {
                query = "INSERT INTO storeProducts(STORENAME,PRODUCTNAME) VALUES('" + sName + "','" + pName + "')";

                cmd = new SqlCommand(query, dbConnection);

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

		public bool RemoveProduct(Store store,Product product)
        {
            string pName = product.GetProductInfo().GetName();
            float pPrice = product.GetProductInfo().GetPrice();
            string pCategory = product.GetProductInfo().GetCategory();

            StoreInfo sInfo = store.GetStoreInfo();
            string sName = sInfo.GetName();

            string query = "SELECT FROM storesProducts WHERE STORENAME = '" + sName + "' AND PRODUCTNAME = '" + pName + "'";

            SqlCommand cmd = new SqlCommand(query, dbConnection);

            if (cmd.ExecuteScalar() == null)
                return false;
			else
            {
                query = "DELETE FROM storeProducts WHERE STORENAME= '" + sName + "' AND PRODUCTNAME='" + pName + "'";

                cmd = new SqlCommand(query, dbConnection);

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
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                dbConnection.Close();
            }
        }

        ~StoreHandler()
        {
            Dispose(false);
        }
    }
}
