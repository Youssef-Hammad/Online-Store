using System.Data.SqlClient;

namespace OnlineStore.classes
{
    class AdminHandler
    {
        private SqlConnection dbConnection;

        public AdminHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
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