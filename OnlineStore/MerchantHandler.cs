﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class MerchantHandler
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private String connectionString;
        //private Product product;

        public MerchantHandler()
        {
            // edit connection string to real values
            connectionString = "Data Source=ServerName;Initial Catalog=db.sql;User ID=UserName;Password=Password";

            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public List<String> GetMerchantStores(User merchant)
        {
            String m_username = merchant.GetUserInfo().GetUsername();
            String query = "SELECT STORENAME from [merchantStores] as m where m.MERCHANTNAME = '" + m_username + "';";

            cmd = new SqlCommand(query, conn);
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
            AuthenticationHandler a_handler = new AuthenticationHandler();
            return a_handler.VerifyUser(merchant);
        }

        public void CloseConnection()
        {
            conn.Close();
        }


    }
}