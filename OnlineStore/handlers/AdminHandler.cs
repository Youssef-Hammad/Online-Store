using System.Data.SqlClient;

namespace OnlineStore
{
    class AdminHandler
    {
        private DBConnection dbConnection;
        private SqlConnection sqlConnection;

        public AdminHandler(string connString)
        {
            dbConnection = new DBConnection(connString);
            dbConnection.Open();
            sqlConnection = dbConnection.GetSqlConnection();
        }

        public bool VerifyIsAdmin(User admin)
        {
            if (admin.GetUserInfo().GetUserType() == UTYPE.ADMIN)
                return true;
            else
                return false;
        }

        ~AdminHandler()
        {
            dbConnection.Dispose(false);
        }
    }
}