using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class AdminUser : IUser
    {
        public string u_username { set; get; }
        public string u_email    { set; get; }
        public string u_password { set; get; }
    }
}
