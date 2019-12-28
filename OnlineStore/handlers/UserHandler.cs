using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace OnlineStore
{
    class UserHandler
    {
        private SqlConnection dbConnection;
        public UserHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
            dbConnection.Open();
        }

        public bool CreateAccount(User usr)
        {
            string username = usr.GetUserInfo().GetUsername();
            string email = usr.GetUserInfo().GetEmail();
            string password = usr.GetUserInfo().GetPassword();
            byte type = (byte)usr.GetUserInfo().GetUserType();
            /*this.entity = "user";
            this.param = $"{{\"USERNAME\":\"{username}\",\"EMAIL\":\"{email}\",\"PASSWORD\":\"{password}\",\"UTYPE\":{type}}}";
            if (this.POST().StatusCode == HttpStatusCode.Created)
                return true;
            else return false;*/
            string query = "INSERT INTO [USER](USERNAME,EMAIL,PASSWORD,UTYPE) VALUES('" + username + "','" + email + "','" + password + "'," + type.ToString()+")";
            SqlCommand cmd = new SqlCommand(query,dbConnection);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Login(User usr)
        {
            string username = usr.GetUserInfo().GetUsername();
            string password = usr.GetUserInfo().GetPassword();
            /*this.entity = "user";
            this.param = $"username={username};password={password}";
            if(this.GET().StatusCode == HttpStatusCode.OK)
                return true;
            else return false;*/

            string query = "SELECT * FROM [USER] WHERE USERNAME = '" + username + "' AND PASSWORD = '" + password + "'";
            SqlCommand cmd = new SqlCommand(query, dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
                return true;
            return false;
        }

        public UTYPE GetUserType(User usr)
        {
            //UTYPE retType = UTYPE.CONSUMER;
            string username = usr.GetUserInfo().GetUsername();
            /*this.entity = "user";
            this.param = $"username={username}";

            dynamic responseBody = JsonConvert.DeserializeObject(this.GetResponseBody(this.GET()));

            retType = responseBody[0].UTYPE;
            return retType;*/
            byte utype;
            string query = "SELECT UTYPE FROM [USER] WHERE USERNAME = '" + username + "'";
            SqlCommand cmd = new SqlCommand(query, dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                utype = reader.GetByte(0);
                reader.Close();
                return (UTYPE)utype;
            }
            else return (UTYPE)(-1);

        }
    }
}
