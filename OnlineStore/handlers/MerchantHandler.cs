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
        private string connString;

        public MerchantHandler(string connString)
        {
            dbConnection = new DBConnection(connString);
            dbConnection.Open();
            sqlConnection = dbConnection.GetSqlConnection();
            this.connString = connString;
        }

        public List<Store> GetMerchantStores(User merchant)
        {
            String m_username = merchant.GetUserInfo().GetUsername();
            String query = "SELECT STORENAME, STORELOC, STYPE FROM STORES WHERE OWNERUSR = '" + m_username + "'";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Store> stores = new List<Store>();
            
            while (reader.Read())
            {
                StoreInfo storeInfo = new StoreInfo();
                storeInfo.SetName(reader.GetString(0));
                storeInfo.SetLocation(reader.GetString(1));
                int type = reader.GetByte(2);
                storeInfo.SetType((STYPE)type);
                stores.Add(new Store(storeInfo));
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
                StoreActionHandler storeActionHandler = new StoreActionHandler(connString);
                storeActionHandler.SaveAction(merchant, storeName, productName, quantity, "add");
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void DeleteProductFromStore(User merchant, string storeName, string productName)
        {
            string merchantName = merchant.GetUserInfo().GetUsername();
            string query = "SELECT QTY FROM PRODUCTSTOCK " +
                           "WHERE [SID] IN ( SELECT [SID] FROM STORES " +
                           "WHERE STORENAME = '" + storeName + "' AND OWNERUSR = '" + merchantName + "') " +
                           "AND PID IN ( SELECT PID FROM APPROVEDPRODUCTS " +
                           "WHERE PRODUCTNAME = '" + productName + "');";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            int quantity = (int) cmd.ExecuteScalar();

            query = "DELETE FROM PRODUCTSTOCK " +
                           "WHERE [SID] IN ( SELECT [SID] FROM STORES " +
                           "WHERE STORENAME = '" + storeName + "' AND OWNERUSR = '" + merchantName + "') " +
                           "AND PID IN ( SELECT PID FROM APPROVEDPRODUCTS " +
                           "WHERE PRODUCTNAME = '" + productName + "');";
            cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();

            StoreActionHandler storeActionHandler = new StoreActionHandler(connString);
            storeActionHandler.SaveAction(merchant, storeName, productName, quantity, "delete");
        }

        public bool VerifyMerchant(User merchant)
        {
            AuthenticationHandler AuthHandler = new AuthenticationHandler(sqlConnection.ConnectionString);
            return AuthHandler.VerifyUser(merchant) && merchant.GetUserInfo().GetUserType() == UTYPE.MERCHANT;
        }

        ~MerchantHandler()
        {
            dbConnection.Dispose(false);
        }
    }
}
