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
    public partial class PurchaseItemForm : Form
    {
        private User currUser;
        private String connString;
        private String productName;
        private String productBrand;
        private int quantity;
        
        public PurchaseItemForm(User newUser, String connString, String p_name, String p_brand, int p_quantity)
        {
            InitializeComponent();
            currUser = newUser;
            this.connString = connString;
            productName = p_name;
            productBrand = p_brand;
            quantity = p_quantity;
            ItemNameLabel.Text = "Product Name: "+productName;
            FetchedBrandNameLabel.Text = "Brand: "+productBrand;
            FetchedQuantityLabel.Text = "Quantity: "+quantity.ToString();
            ItemPictureBtn.Text = productName;
            purchaseErrorLabel.Hide();
        }

        private void PurchaseItemForm_Load(object sender, EventArgs e)
        {

        }

        private void ItemPictureBtn_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            if(QuantityTextBox.Text == "")
            {
                purchaseErrorLabel.Text = "Please fill out the Quantity Text Box to continue";
                purchaseErrorLabel.Show();
            }
            else if(AddressTextBox.Text == "")
            {
                purchaseErrorLabel.Text = "Please fill out the Address Text Box to continue";
                purchaseErrorLabel.Show();
            }
            else if(AgreementsCheckBox.Checked == false)
            {
                purchaseErrorLabel.Text = "Please Agree to the terms and conditions to continue";
                purchaseErrorLabel.Show();
            }
            else
            {
                String QuantityStr = QuantityTextBox.Text;
                bool ValidQuantity = true;
                for (int i = 0; i < QuantityStr.Length; i++)
                {
                    if(QuantityStr[i]<'0'||QuantityStr[i]>'9')
                    {
                        ValidQuantity = false;
                        break;
                    }
                }
                if(ValidQuantity)
                {
                    int QuantityInt = Convert.ToInt32(QuantityStr);
                    if(QuantityInt>quantity)//compares input quantity with available quantity
                    {
                        purchaseErrorLabel.Text = "The quantity available is not sufficient for your input";
                        purchaseErrorLabel.Show();
                    }
                    else if(QuantityInt<=0)
                    {
                        purchaseErrorLabel.Text = "Invalid Number, minimum quantity is 1";
                    }
                    else
                    {
                        ProductHandler pHandler = new ProductHandler(connString);
                        pHandler.BuyProduct(productName, productBrand, QuantityInt);
                        this.Hide();
                        MessageBox.Show("Product Successfully Purchased!");

                    }
                }
                else
                {
                    purchaseErrorLabel.Text = "Invalid Input for Quantity. Must Contain only numbers";
                    purchaseErrorLabel.Show();
                }
            }
        }

        private void purchaseErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void AgreementsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
