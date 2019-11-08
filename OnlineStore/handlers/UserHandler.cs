﻿using System.Data.SqlClient;

namespace OnlineStore.classes
{
    class UserHandler
    {
        SqlConnection dbConnection;
        AuthenticationHandler authHandler;
        public UserHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
            authHandler = new AuthenticationHandler(connString);
            dbConnection.Open();
        }

        public bool CreateAccount(User usr)
        {
            string username = usr.GetUserInfo().GetUsername();
            string email = usr.GetUserInfo().GetEmail();
            string pwd = usr.GetUserInfo().GetPassword();
            int type = (int)usr.GetUserInfo().GetUserType();
            if(!authHandler.VerifyEmail(email) && !authHandler.VerifyUsername(username))
            {
                string query = "insert into [USER](USERNAME, EMAIL, PASSWORD, TYPE) ";
                string arg = "values('" + username + "', '" + email + "', '" + pwd + "', '" + type + "');";
                SqlCommand cmd = new SqlCommand(query + arg, dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public bool Login(User usr)
        {
            if (authHandler.VerifyUser(usr))
                return true;
            else return false;
        }

        public void EditUsername(string newUsername)
        {
            //TODO: doesn't need to be done in this sprint
        }

        public void EditEmail(string newEmail)
        {
            //TODO: doesn't need to be done in this sprint
        }

        public void EditPassword(string newEncryptedPassword)
        {
            //TODO: doesn't need to be done in this sprint
        }

        public void CloseConnection()
        {
            dbConnection.Close();
        }
    }
}