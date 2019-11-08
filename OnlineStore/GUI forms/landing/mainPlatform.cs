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
    public partial class mainPlatform : Form
    {
        private User currUser;
        private String connString;

        public mainPlatform(User newUser, String connString)
        {
            InitializeComponent();
            currUser = newUser;
            this.connString = connString;
        }

        private void mControlPanelBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(currUser.GetUserInfo().GetUserType() == UTYPE.ADMIN)
            {
                adminPanel adminCP = new adminPanel(connString);
                adminCP.Show();
            }
            if(currUser.GetUserInfo().GetUserType() == UTYPE.MERCHANT)
            {
                merchantPanel merchantCP = new merchantPanel(currUser, connString);
                merchantCP.Show();
            }
        }

        private void mainPlatform_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }
    }
}
