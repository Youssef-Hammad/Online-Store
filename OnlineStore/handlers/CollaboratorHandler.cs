using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineStore
{
    class CollaboratorHandler
    {
        private DBConnection dbConnection;
        private SqlConnection sqlConnection;

        public CollaboratorHandler(string connString)
        {
            dbConnection = new DBConnection(connString);
            dbConnection.Open();
            sqlConnection = dbConnection.GetSqlConnection();
        }


        public bool AddCollaborator(string ownerUsername, string collaboratorUsername)
        {
            try
            {
                string query = "INSERT INTO COLLABS(OUSERNAME, CUSERNAME) VALUES('" + ownerUsername + "', '" + collaboratorUsername + "');";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.ExecuteNonQuery();

                query = "UPDATE [USER] SET UTYPE = 3 WHERE USERNAME = '" + collaboratorUsername + "';";
                cmd = new SqlCommand(query, sqlConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool VerifyIsCollaborator(string ownerUsername, string collaboratorUsername)
        {
            string query = "SELECT * FROM COLLABS WHERE OUSERNAME = '" + ownerUsername + "' AND CUSERNAME = '" + collaboratorUsername + "'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read())
                return false;
            reader.Close();
            return true;
        }

        public List<string> GetAccessibleStores(string collaboratorUsername)
        {
            List<string> storeNames = new List<string>();
            string ownerUsername = "";
            string query = "SELECT OUSERNAME FROM COLLABS WHERE CUSERNAME = '" + collaboratorUsername + "';";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                ownerUsername = reader.GetString(0);

            query = "SELECT STORENAME FROM STORES WHERE OWNERUSER = '" + ownerUsername + "';";
            cmd = new SqlCommand(query, sqlConnection);
            while (reader.Read())
                storeNames.Add(reader.GetString(0));

            return storeNames;
        }

        ~CollaboratorHandler()
        {
            dbConnection.Dispose(false);
        }
    }
}
