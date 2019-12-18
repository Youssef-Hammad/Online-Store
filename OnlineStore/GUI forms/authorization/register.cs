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
        private String password;
        private String passToVerify;
        private String connString;

        public registerForm(String connString)
        {
            InitializeComponent();
            u_info = new UserInfo();
            this.connString = connString;
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

        private void rRegisterBtn_Click(object sender, EventArgs e)
        {
            if (rEmailTxt.Text.Trim() == string.Empty || rPwdTxt.Text.Trim() == string.Empty
                || rVerifyPwdTxt.Text.Trim() == string.Empty || rUsrnameTxt.Text.Trim() == string.Empty || (MrB.Checked == false && CrB.Checked == false))
            {
                MessageBox.Show("Fill empty fields");
                return;
            }
            if(!password.Equals(passToVerify))
            {
                errMsg.Text = "passwords don't match";
            }
            else
            {
                errMsg.Text = string.Empty;
                u_info.SetPassword(password);
                if (CrB.Checked)
                    u_info.SetUserType(UTYPE.CONSUMER);
                else u_info.SetUserType(UTYPE.MERCHANT);

                user = new User(u_info);

                UserHandler u_handler = new UserHandler();
                if (u_handler.CreateAccount(user))
                {
                    MessageBox.Show("Registration successful");
                    this.Close();
                }
                else MessageBox.Show("Registration Failed");
            }
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            CrB.Checked = true;
        }
    }
}
