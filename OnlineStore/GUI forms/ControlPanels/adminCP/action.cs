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
    public partial class action : Form
    {
        private string connString;
        private Store store;
        private StoreHandler storeHandler;
        private string ownerName;

        public action(string connString, Store store, string ownerName)
        {
            InitializeComponent();
            this.connString = connString;
            this.store = store;
            storeHandler = new StoreHandler(connString);
            this.ownerName = ownerName;
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            StoreInfo uinfo = store.GetStoreInfo();
            if(storeHandler.AddApprovedStore(store, ownerName))
            {
                storeHandler.RemoveFromPending(store);
                MessageBox.Show("Store approved successfully");
            }
            else
            {
                MessageBox.Show("Approving failed");
            }
        }

        private void Decline_Click(object sender, EventArgs e)
        {
            if(storeHandler.RemoveFromPending(store))
            {
                MessageBox.Show("Store removed from pending table successfully");
            }
            else
            {
                MessageBox.Show("Removing from pending sfailed");
            }
        }

        private void action_Load(object sender, EventArgs e)
        {

        }
    }
}
