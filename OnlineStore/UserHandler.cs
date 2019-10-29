using System.Data.SqlClient;

namespace OnlineStore
{
    class UserHandler
    {
        SqlConnection dbConnection;
        public UserHandler(string serverName)
        {
            dbConnection = new SqlConnection("Data Source=" + serverName + ";Initial Catalog=emailApp;Integrated Security=True");
            dbConnection.Open();
        }

        public void CreateAccount(User usr)
        {
            // TODO: verification that username and e-mail aren't taken
            UserInfo uInfo = usr.GetUserInfo();
            string query = "insert into [USER](USERNAME, EMAIL, PASSWORD) ";
            string arg = "values('" + uInfo.GetUsername() + "', '" + uInfo.GetEmail() + "', '" + uInfo.GetPassword() + "');";

            SqlCommand cmd = new SqlCommand(query + arg, dbConnection);
            cmd.ExecuteNonQuery();
        }

        public bool Login(string usrORemail, string encryptedPwd)
        {
            // TODO: verify credentials before logging in, needs AuthenticationHandler
            if (true)
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
