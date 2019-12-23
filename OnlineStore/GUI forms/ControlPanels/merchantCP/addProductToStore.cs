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
    public partial class addProductToStore : Form
    {
        private User merchant;
        private MerchantHandler merchHandler;
        private ProductHandler productHandler;
        private string connString;
        private List<string> storeList;
        private List<string> productList;

        public addProductToStore(User currUser, string connString)
        {
            InitializeComponent();
            AddProductErrorLabel.Hide();
            this.connString = connString;
            this.merchant = currUser;
            merchHandler = new MerchantHandler(connString);
            productHandler = new ProductHandler(connString);
            storeList = merchHandler.GetMerchantStoresNames(currUser);
            foreach (string iterator in storeList)
            {
                //Console.WriteLine(iterator.GetStoreInfo().GetName());
                storeComboBox.Items.Add(iterator);
            }
            productList = productHandler.GetAllApprovedProductsNames();
            foreach (string iterator in productList)
            {
                productComboBox.Items.Add(iterator);
            }
        }

        private void addProductToStore_Load(object sender, EventArgs e)
        {

        }

        private void rAddProductBtn_Click(object sender, EventArgs e)
        {
            if (productComboBox.Text == "")
            {
                AddProductErrorLabel.Text = "Please Select A Product";
                AddProductErrorLabel.Show();
            }
            else if (storeComboBox.Text == "")
            {
                AddProductErrorLabel.Text = "Please Select A Store";
                AddProductErrorLabel.Show();
            }
            else if (stockTextBox.Text == "")
            {
                AddProductErrorLabel.Text = "Please Set Stock Quantity";
                AddProductErrorLabel.Show();
            }
            else
            {
                string productName = productComboBox.Text;
                string storeName = storeComboBox.Text;
                string quantity = stockTextBox.Text;
                if (productHandler.isValidQuantity(quantity))
                {
                    if (merchHandler.AddProductToStore(productName, storeName, merchant, Int32.Parse(quantity)))
                    {
                        MessageBox.Show("Product Added Successfully");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Product Already Exists In Chosen Store");
                    }
                }
                else
                {
                    AddProductErrorLabel.Text = "Stock must contain only numbers";
                    AddProductErrorLabel.Show();
                }
            }
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
