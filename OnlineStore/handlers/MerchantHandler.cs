using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OnlineStore
{
    class MerchantHandler
    {
        private SqlConnection dbConnection;

        public MerchantHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
            dbConnection.Open();
        }

        public List<Store> GetMerchantStores(User merchant)
        {
            String m_username = merchant.GetUserInfo().GetUsername();
            String query = "SELECT * FROM STORES WHERE OWNERUSR = '" + m_username + "'";

            SqlCommand cmd = new SqlCommand(query, dbConnection);
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
            AuthenticationHandler AuthHandler = new AuthenticationHandler(dbConnection.ConnectionString);
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
                dbConnection.Close();
            }
        }

        ~MerchantHandler()
        {
            Dispose(false);
        }
    }
}
