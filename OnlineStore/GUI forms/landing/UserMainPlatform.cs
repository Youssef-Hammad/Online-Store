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
    public partial class UserMainPlatform : Form
    {
        private User currUser;
        private String connString;
        private ProductHandler productHandler;
        private List<Product> productList;

        public UserMainPlatform(User newUser, String connString)
        {
            InitializeComponent();
            currUser = newUser;
            this.connString = connString;
            purchaseErrorLabel.Hide();
            productHandler = new ProductHandler(connString);

            productList = this.productHandler.GetAllApprovedProducts();

            foreach (var iterator in productList)
            {
                //Console.WriteLine(iterator.GetProductInfo().GetName());
                ItemsComboBox.Items.Add(iterator.GetProductInfo().GetName());
            }
        }

        private void UserMainPlatform_Load(object sender, EventArgs e)
        {

        }

        private void UserMainPlatform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            if(ItemsComboBox.Text == "")
            {
                purchaseErrorLabel.Show();
            }
            else
            {
                foreach (var iterator in productList)
                {
                    if (iterator.GetProductInfo().GetName() == ItemsComboBox.Text)
                    {
                        int quantity = productHandler.GetQuantity(iterator);
                        PurchaseItemForm purchaseItemForm = new PurchaseItemForm(currUser, connString, iterator.GetProductInfo().GetName(), iterator.GetProductInfo().GetBrand().GetName(), quantity);
                        purchaseItemForm.Show();
                        break;
                    }
                }
            }
        }

        private void purchaseErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
