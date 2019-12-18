using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OnlineStore
{
    class UserHandler : WebServiceHandler
    {
        public bool CreateAccount(User usr)
        {
            string username = usr.GetUserInfo().GetUsername();
            string email = usr.GetUserInfo().GetEmail();
            string password = usr.GetUserInfo().GetPassword();
            byte type = (byte)usr.GetUserInfo().GetUserType();
            this.entity = "user";
            this.param = $"{{\"USERNAME\":\"{username}\",\"EMAIL\":\"{email}\",\"PASSWORD\":\"{password}\",\"UTYPE\":{type}}}";
            if (this.POST().StatusCode == HttpStatusCode.Created)
                return true;
            else return false;
        }

        public bool Login(User usr)
        {
            string username = usr.GetUserInfo().GetUsername();
            string password = usr.GetUserInfo().GetPassword();
            this.entity = "user";
            this.param = $"username={username};password={password}";
            if(this.GET().StatusCode == HttpStatusCode.OK)
                return true;
            else return false;
        }

        public UTYPE GetUserType(User usr)
        {
            UTYPE retType = UTYPE.CONSUMER;
            string username = usr.GetUserInfo().GetUsername();
            this.entity = "user";
            this.param = $"username={username}";

            dynamic responseBody = JsonConvert.DeserializeObject(this.GetResponseBody(this.GET()));

            retType = responseBody[0].UTYPE;
            return retType;
        }
    }
}
