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

        public List<String> GetMerchantStores(User merchant)
        {
            String m_username = merchant.GetUserInfo().GetUsername();
            String query = "SELECT STORENAME from [merchantStores] as m where m.MERCHANTNAME = '" + m_username + "';";

            SqlCommand cmd = new SqlCommand(query, dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<String> stores = new List<String>();

            while (reader.Read())
            {
                stores.Add(reader.GetString(0));
            }

            return stores;
        }

        public bool VerifyMerchant(User merchant)
        {
            AuthenticationHandler AuthHandler = new AuthenticationHandler(dbConnection.ConnectionString);
            return AuthHandler.VerifyUser(merchant) && merchant.GetUserInfo().GetUserType() == UTYPE.MERCHANT;
        }

        public void CloseConnection()
        {
            dbConnection.Close();
        }

        ~MerchantHandler()
        {
            this.CloseConnection();
        }
    }
}
