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
    public partial class Undo : Form
    {
        private string connString, productName, actionStatement;
        private Int32 storeId, quantity, actionId;
        private User currUser;
        private StoreActionHandler storeActionHandler;

        public Undo(string connString, Int32 actionId, User currUser, Int32 storeId, string productName, Int32 quantity, string actionStatement)
        {
            this.connString = connString;
            this.actionId = actionId;
            this.storeId = storeId;
            this.productName = productName;
            this.actionStatement = actionStatement;
            this.currUser = currUser;
            this.quantity = quantity;
            storeActionHandler = new StoreActionHandler(connString);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storeActionHandler.UndoAction(currUser, actionId, storeId, productName, quantity, actionStatement);
            MessageBox.Show("Action Reverted");
        }
    }
}
