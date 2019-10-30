using System.Data.SqlClient;

namespace OnlineStore
{
    class AdminHandler
    {
        private SqlConnection dbConnection;

        public AdminHandler(string serverName)
        {
            dbConnection = new SqlConnection("Data Source=" + serverName + ";Initial Catalog=db.sql;User ID=UserName;Password=Password");
            dbConnection.Open();
        }

        public bool VerifyIsAdmin(User admin)
        {
            if (admin.GetUserInfo().GetUserType() == UTYPE.ADMIN)
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