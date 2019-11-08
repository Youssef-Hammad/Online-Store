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
        private String connString;


        public addProduct(String connString)
        {
            InitializeComponent();
            p_info = new ProductInfo();
            this.connString = connString;
        }

        private void rAddProductBtn_Click(object sender, EventArgs e)
        {
            p_info.SetName(pNameTxt.Text);
            p_info.SetPrice(float.Parse(pPriceTxt.Text));
            p_info.SetCategory(pCategoryTxt.Text);
            BrandInfo bInfo = new BrandInfo();//(pBrandTxt.Text, pCategoryTxt.Text);
            bInfo.SetName(pBrandTxt.Text);
            bInfo.SetCategory(pCategoryTxt.Text);
            Brand newBrand = new Brand(bInfo);
            p_info.SetBrand(bInfo);

            p_handler = new ProductHandler(connString);
            Product product = new Product(p_info);
            if (p_handler.AddProduct(product))
                MessageBox.Show("add operation was successful");
        }
    }
}
