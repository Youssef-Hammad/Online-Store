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
    public partial class addCollaborator : Form
    {
        private string connString;
        private User currUser;
        public addCollaborator(User currUser, string connString)
        {
            InitializeComponent();
            this.currUser = currUser;
            this.connString = connString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollaboratorHandler collabHandler = new CollaboratorHandler(connString);
            if (collabHandler.AddCollaborator(currUser.GetUserInfo().GetUsername(), textBox1.Text))
                MessageBox.Show("Collaborator added successfully!");
            else MessageBox.Show("Adding collaborator failed.");
        }
    }
}
