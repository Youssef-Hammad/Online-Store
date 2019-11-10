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

            BrandHandler b_handler = new BrandHandler(connString);
            List<String> brandsNames = b_handler.GetBrandsNames();
            b_handler.Dispose();

            foreach (var brandName in brandsNames)
            {
                comboBox1.Items.Add(brandName);
            }
        }

        private void rAddProductBtn_Click(object sender, EventArgs e)
        {
            p_info.SetName(pNameTxt.Text);
            p_info.SetPrice(float.Parse(pPriceTxt.Text));
            p_info.SetCategory(pCategoryTxt.Text);

            BrandInfo bInfo = new BrandInfo();
            bInfo.SetName(comboBox1.Text);

            Brand newBrand = new Brand(bInfo);

            p_info.SetBrand(bInfo);
            Product product = new Product(p_info);
            p_handler = new ProductHandler(connString);

            if (p_handler.AddProduct(product))      // adds to APPROVEDPRODUCTS table
                MessageBox.Show("add operation was successful");
            else
                MessageBox.Show("Can't add product");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pCategoryTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
