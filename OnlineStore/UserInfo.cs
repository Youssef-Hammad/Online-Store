namespace OnlineStore
{
    enum UTYPE { ADMIN, MERCHANT, CONSUMER };
    class UserInfo
    {
        private string u_username;
        private string u_email;
        private string u_password;
        private UTYPE u_type;

        public string GetUsername()
        {
            return u_username;
        }

        public string GetEmail()
        {
            return u_email;
        }

        public string GetPassword()
        {
            return u_password;
        }

        public UTYPE GetUserType()
        {
            return u_type;
        }

        public void SetUsername(string username)
        {
            u_username = username;
        }

        public void SetEmail(string email)
        {
            u_email = email;
        }

        public void SetPassword(string encryptedPassword)
        {
            u_password = encryptedPassword;
        }

        public void SetUserType(UTYPE type)
        {
            u_type = type;
        }
    }
}
