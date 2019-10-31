using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class registerForm : Form
    {
        private User user;
        private UserInfo u_info;
        private UserHandler u_handler;
        private String password;

        public registerForm()
        {
            InitializeComponent();
            u_info = new UserInfo();
        }

        private void rUsrnameTxt_TextChanged(object sender, EventArgs e)
        {
            u_info.SetUsername(rUsrnameTxt.Text);
        }

        private void rEmailTxt_TextChanged(object sender, EventArgs e)
        {
            u_info.SetEmail(rEmailTxt.Text);
        }

        private void rPwdTxt_TextChanged(object sender, EventArgs e)
        {
            password = rPwdTxt.Text;
        }

        private void rVerifyPwdTxt_TextChanged(object sender, EventArgs e)
        {
            String passToVerify = rVerifyPwdTxt.Text;
            if(password.Equals(passToVerify))
            {
                u_info.SetPassword(password);
            }
            else
            {
                textBox1.Text = "Passwords don't match";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rRegisterBtn_Click(object sender, EventArgs e)
        {
            user = new User(u_info);

            // Remove comments when adding a server name

            //u_handler = new UserHandler(/* srever name */);
            //u_handler.CreateAccount(user);
        }
    }
}
