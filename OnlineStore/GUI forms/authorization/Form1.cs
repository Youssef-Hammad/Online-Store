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


        // DON'T FORGET TO CHANGE SERVER NAME TO YOUR SERVER NAME BEFORE TRYING TO RUN

        public String sqlServerName = "SQL6007.site4now.net";
        public String connString;

        public login()
        {
            InitializeComponent();
            u_info = new UserInfo();

            // THE NAME OF YOUR DATABASE HAS TO BE "OnlineStore"
            connString = "Data Source=" + sqlServerName + ";Initial Catalog=DB_A5061A_okboomer;User Id=DB_A5061A_okboomer_admin;Password=okboomerserver0;MultipleActiveResultSets=true;";
        }

        private void registerBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerForm rForm = new registerForm(connString);
            rForm.ShowDialog();
        }

        private void lLoginBtn_Click(object sender, EventArgs e)
        {
            u_info.SetUsername(lUsrnameTxt.Text);
            u_info.SetPassword(lPwdTxt.Text);
            User newUser = new User(u_info);
            u_handler = new UserHandler(connString);

            if (u_handler.Login(newUser))
            {
                u_info.SetUserType(u_handler.GetUserType(newUser));
                newUser.SetUserInfo(u_info);
                if (u_info.GetUserType() == UTYPE.CONSUMER)
                {
                    UserMainPlatform uPlatform = new UserMainPlatform(newUser, connString);
                    uPlatform.Show();

                }
                else
                {
                    mainPlatform mPlatform = new mainPlatform(newUser, connString);
                    mPlatform.Show();
                }
                this.Hide();
            }
            else MessageBox.Show("Login failed, check credentials");
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
