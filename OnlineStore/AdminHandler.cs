namespace OnlineStore
{
    class AdminHandler
    {
        private SqlConnection dbConnection;

        public AdminHandler(string serverName)
        {
            // edit connection string to real values
            connectionString = "Data Source=" + serverName + ";Initial Catalog=db.sql;User ID=UserName;Password=Password";

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
        }

        public bool VerifyIsAdmin(User admin)
        {
            if (admin.GetUserInfo().GetType() == ADMIN)
                return true;
            else
                return false;
        }
        public void CloseConnection()
        {
            dbConnection.Close();
        }
    }
}