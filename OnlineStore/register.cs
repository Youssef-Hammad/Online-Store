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
        private String passToVerify;

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
            passToVerify = rVerifyPwdTxt.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rRegisterBtn_Click(object sender, EventArgs e)
        {
            if (rEmailTxt.Text.Trim() == string.Empty || rPwdTxt.Text.Trim() == string.Empty
                || rVerifyPwdTxt.Text.Trim() == string.Empty || rUsrnameTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fill empty fields");
                return;
            }
            if(!password.Equals(passToVerify))
            {
                textBox1.Text = "passwords don't match";
            }
            else
            {
                textBox1.Text = string.Empty;
                u_info.SetPassword(password);
                user = new User(u_info);
                // Remove comments when adding a server name

                //u_handler = new UserHandler(/* srever name */);
                //u_handler.CreateAccount(user);
            }
        }
    }
}
