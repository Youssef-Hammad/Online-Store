using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    interface IUser
    {
        string u_username { get; set; }
        string u_email    { get; set; }
        string u_password { get; set; }
    }
}
