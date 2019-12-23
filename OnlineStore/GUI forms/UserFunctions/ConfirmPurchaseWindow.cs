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
    public partial class ConfirmPurchaseWindow : Form
    {
        private User currUser;
        private String connString;
        private String productName;
        private String productBrand;
        private float totalPrice;
        private int quantity;
        private float discountPrice;
        private float finalPrice;

        public ConfirmPurchaseWindow(User newUser, string connString, string pName, string pBrand, float pPrice, float dPrice, int pQuantity)
        {
            InitializeComponent();
            currUser = newUser;
            this.connString = connString;
            productName = pName;
            totalPrice = pPrice;
            discountPrice = dPrice;
            productBrand = pBrand;
            quantity = pQuantity;
            finalPrice = totalPrice - discountPrice;
            originalPriceLabel.Text = totalPrice.ToString();
            discountOffersLabel.Text = discountPrice.ToString();
            finalPriceLabel.Text = finalPrice.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ConfirmPurchaseWindow_Load(object sender, EventArgs e)
        {

        }
        

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            ProductHandler pHandler = new ProductHandler(connString);
            pHandler.BuyProduct(currUser.GetUserInfo().GetUsername(),finalPrice,productName, productBrand, quantity);
            this.Hide();
            MessageBox.Show("Product Successfully Purchased!");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
