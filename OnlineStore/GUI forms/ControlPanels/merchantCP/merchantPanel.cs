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
    public partial class merchantPanel : Form
    {
        private String connString;
        private User currUser;
        private List<string> accessibleStores;

        public merchantPanel(User newUser, String connString)
        {
            InitializeComponent();
            currUser = newUser;
            this.connString = connString;
            if(currUser.GetUserInfo().GetUserType() == UTYPE.COLLABORATOR)
            {
                rAddStoreBtn.Enabled = false;
                LiveStatistics.Enabled = false;
                button1.Enabled = false;
                CollaboratorHandler cHandler = new CollaboratorHandler(connString);
                accessibleStores = cHandler.GetAccessibleStores(currUser.GetUserInfo().GetUsername());
            }
        }

        private void rAddStoreBtn_Click(object sender, EventArgs e)
        {
            addStoreToPending pendingPanel = new addStoreToPending(connString, currUser);
            pendingPanel.Show();
        }

        private void LiveStatisticsBtn_Click(object sender, EventArgs e)
        {
            LiveStatistics LiveStatisticsWindow = new LiveStatistics(connString, currUser);
            LiveStatisticsWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCollaborator addCollab = new addCollaborator(currUser, connString);
            addCollab.Show();
        }
    }
}
