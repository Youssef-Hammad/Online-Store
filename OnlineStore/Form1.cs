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
    public partial class login : Form
    {
        private UserInfo u_info;
        private UserHandler u_handler;

        public login()
        {
            InitializeComponent();
            u_info = new UserInfo();
        }

        private void registerBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerForm rForm = new registerForm();
            rForm.ShowDialog();
        }

        private void lUsrnameTxt_TextChanged(object sender, EventArgs e)
        {
            u_info.SetUsername(lUsrnameTxt.Text);
        }

        private void lPwdTxt_TextChanged(object sender, EventArgs e)
        {
            u_info.SetUsername(lPwdTxt.Text);
        }

        private void lLoginBtn_Click(object sender, EventArgs e)
        {
            User user = new User(u_info);
            //u_handler = new UserHandler(/* server name */);
            //u_handler.Login(user);
        }
    }
}
