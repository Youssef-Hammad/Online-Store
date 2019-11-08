using System.Data.SqlClient;

namespace OnlineStore
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

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                dbConnection.Close();
            }
        }

        ~AdminHandler()
        {
            Dispose(false);
        }
    }
}