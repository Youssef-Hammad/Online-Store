namespace OnlineStore.classes
{

    class User
    {
        private UserInfo u_info;

        public User(UserInfo userInfo)
        {
            u_info = userInfo;
        }

        public UserInfo GetUserInfo()
        {
            return u_info;
        }

        public void SetUserInfo(UserInfo userInfo)
        {
            u_info = userInfo;
        }
    }
}
