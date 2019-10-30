using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class MerchantHandler
    {
        private SqlConnection dbConnection;

        public MerchantHandler(string serverName)
        {
            dbConnection = new SqlConnection("Data Source=" + serverName + ";Initial Catalog=db.sql;User ID=UserName;Password=Password");
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
            AuthenticationHandler AuthHandler = new AuthenticationHandler();
            return AuthHandler.VerifyUser(merchant) && merchant.GetUserInfo().GetUserType() == UTYPE.MERCHANT;
        }

        public void CloseConnection()
        {
            dbConnection.Close();
        }


    }
}
