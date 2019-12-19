using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

            while (reader.Read())
            {
                storeInfo.SetName(reader.GetString(1));
                storeInfo.SetLocation(reader.GetString(2));
                int type = reader.GetByte(4);
                storeInfo.SetType((STYPE)type);
                Store store = new Store(storeInfo);
                stores.Add(store);
            }
            reader.Close();

            return stores;
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
