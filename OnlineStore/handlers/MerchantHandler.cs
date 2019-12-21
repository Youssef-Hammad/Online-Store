using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineStore
{
    class MerchantHandler
    {
        private DBConnection dbConnection;
        private SqlConnection sqlConnection;

        public MerchantHandler(string connString)
        {
            dbConnection = new DBConnection(connString);
            dbConnection.Open();
            sqlConnection = dbConnection.GetSqlConnection();
        }

        public List<Store> GetMerchantStores(User merchant)
        {
            String m_username = merchant.GetUserInfo().GetUsername();
            String query = "SELECT * FROM STORES WHERE OWNERUSR = '" + m_username + "'";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Store> stores = new List<Store>();
            StoreInfo storeInfo = new StoreInfo();
            int idx = 0;
            while (reader.Read())
            {
                storeInfo.SetName(reader.GetString(1));
                storeInfo.SetLocation(reader.GetString(2));
                int type = reader.GetByte(4);
                storeInfo.SetType((STYPE)type);
                Store store = new Store(storeInfo);
                //Console.WriteLine(store.GetStoreInfo().GetName());
                stores.Add(store);
                //Console.WriteLine(stores[idx].GetStoreInfo().GetName());
                idx++;
            }
            reader.Close();

            for (int i = 0; i < stores.Count; i++)
            {
                Console.WriteLine(stores[i].GetStoreInfo().GetName());
            }

            return stores;
        }
        public List<string> GetMerchantStoreNames(User merchant)
        {
            String m_username = merchant.GetUserInfo().GetUsername();
            String query = "SELECT * FROM STORES WHERE OWNERUSR = '" + m_username + "'";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> stores = new List<string>();
            int idx = 0;
            while (reader.Read())
            {
                //Console.WriteLine(store.GetStoreInfo().GetName());
                stores.Add(reader.GetString(1));
                //Console.WriteLine(stores[idx].GetStoreInfo().GetName());
                idx++;
            }
            reader.Close();

            return stores;
        }

        public bool AddProductToStore(string productName, string storeName, User merchant, int quantity)
        {
            int productID = 0;
            int storeID = 0;
            ProductInfo productInfo = new ProductInfo();
            StoreInfo storeInfo = new StoreInfo();
            string productQuery = "SELECT * FROM APPROVEDPRODUCTS WHERE PRODUCTNAME = '" + productName + "'";
            SqlCommand productCmd = new SqlCommand(productQuery, sqlConnection);
            SqlDataReader productReader = productCmd.ExecuteReader();
            if (productReader.Read())
            {
                /*productInfo.SetName(productReader.GetString(2));
                productInfo.SetPrice((float)productReader.GetDouble(3));
                productInfo.SetCategory(productReader.GetString(4));*/
                productID = productReader.GetInt32(0);
                /*BrandInfo brandInfo = new BrandInfo();
                string brandQuery = "SELECT * FROM BRAND WHERE BRANDNAME = '" + productReader.GetString(1) + "'";
                SqlCommand brandCmd = new SqlCommand(brandQuery, dbConnection);
                SqlDataReader brandReader = brandCmd.ExecuteReader();
                if (brandReader.Read())
                {
                    brandInfo.SetName(brandReader.GetString(0));
                    brandInfo.SetCategory(brandReader.GetString(1));
                }
                else
                {
                    return false;
                }
                productInfo.SetBrand(brandInfo);*/
            }
            else
            {
                return false;
            }
            string storeQuery = "SELECT * FROM STORES WHERE STORENAME = '" + storeName + "' AND OWNERUSR = '" + merchant.GetUserInfo().GetUsername() + "'";
            SqlCommand storeCmd = new SqlCommand(storeQuery, sqlConnection);
            SqlDataReader storeReader = storeCmd.ExecuteReader();
            if (storeReader.Read())
            {
                /*storeInfo.SetName(storeReader.GetString(1));
                storeInfo.SetLocation(storeReader.GetString(2));
                storeInfo.SetType((STYPE)storeReader.GetInt16(3));*/
                storeID = storeReader.GetInt32(0);
            }
            else
            {
                return false;
            }
            string insertQuery = "INSERT INTO PRODUCTSTOCK(SID,PID,QTY) VALUES(" + storeID.ToString() + "," + productID.ToString() + "," + quantity.ToString() + ")";
            SqlCommand insertCmd = new SqlCommand(insertQuery, sqlConnection);
            try
            {
                insertCmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool VerifyMerchant(User merchant)
        {
            AuthenticationHandler AuthHandler = new AuthenticationHandler(sqlConnection.ConnectionString);
            return AuthHandler.VerifyUser(merchant) && merchant.GetUserInfo().GetUserType() == UTYPE.MERCHANT;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                sqlConnection.Close();
            }
        }

        ~MerchantHandler()
        {
            Dispose(false);
        }
    }
}
