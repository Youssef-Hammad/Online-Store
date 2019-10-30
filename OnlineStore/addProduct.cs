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
    public partial class addProduct : Form
    {
        private ProductHandler p_handler;
        private ProductInfo p_info;

        public addProduct()
        {
            InitializeComponent();
            p_info = new ProductInfo();
        }

        private void pNameTxt_TextChanged(object sender, EventArgs e)
        {
            p_info.SetName(pNameTxt.Text);
        }

        private void pPriceTxt_TextChanged(object sender, EventArgs e)
        {
            String input = pPriceTxt.Text;
            if (input.Contains("."))
            {
                input = input.Replace(".", ",");
            }
            float price = Convert.ToSingle(input);
            p_info.SetPrice(price);
        }

        private void pCategoryTxt_TextChanged(object sender, EventArgs e)
        {
            p_info.SetCategory(pCategoryTxt.Text);
        }

        private void rRegisterBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product(p_info);
            MessageBox.Show(p_info.GetName() + " " + p_info.GetPrice() + " " + p_info.GetCategory());
            p_handler.AddProduct(product);
        }

        private void pNameTxt_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
