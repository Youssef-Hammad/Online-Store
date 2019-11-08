using System;
using System.Data.SqlClient;

namespace OnlineStore
{
    class AuthenticationHandler
    {
        SqlConnection dbConnection;

        public AuthenticationHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
            dbConnection.Open();
        }

        public bool VerifyUser(User user)
        {
            string username = user.GetUserInfo().GetUsername();
            string email    = user.GetUserInfo().GetEmail();
            string pwd      = user.GetUserInfo().GetPassword();
            if ((VerifyUsername(username) || VerifyEmail(email)))
                if (VerifyPassword((VerifyEmail(email) ? email : username), pwd))
                    return true;
            return false;
        }

        public bool VerifyUsername(string username)
        {
            string query = "SELECT count(USERNAME) from [USER] where USERNAME = '" + username + "';";
            SqlCommand cmd = new SqlCommand(query, dbConnection);
            int usernameCheck = Convert.ToInt16(cmd.ExecuteScalar());
            if (usernameCheck == 1)
                return true;
            return false;
        }

        public bool VerifyEmail(string email)
        {
            string query = "SELECT count(USERNAME) from [USER] where EMAIL = '" + email + "';";
            SqlCommand cmd = new SqlCommand(query, dbConnection);
            int emailCheck = Convert.ToInt16(cmd.ExecuteScalar());
            if (emailCheck == 1)
                return true;
            return false;
        }

        public bool VerifyPassword(string usrORemail, string encryptedPwd)
        {
            string query = "";
            if(VerifyEmail(usrORemail))
                query = "SELECT count(USERNAME) from [USER] where EMAIL = '" + usrORemail + "' AND [PASSWORD] = '" + encryptedPwd + "';";
            if(VerifyUsername(usrORemail))
                query = "SELECT count(USERNAME) from [USER] where USERNAME = '" + usrORemail + "' AND [PASSWORD] = '" + encryptedPwd + "';";

            SqlCommand cmd = new SqlCommand(query, dbConnection);
            int pwdCheck = Convert.ToInt16(cmd.ExecuteScalar());
            if (pwdCheck == 1)
                return true;
            return false;
        }

        public void CloseConnection()
        {
            dbConnection.Close();
        }
    }
}
