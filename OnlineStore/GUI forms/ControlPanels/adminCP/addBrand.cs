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
    public partial class addBrand : Form
    {
        private string connString;
        private BrandInfo b_info;
        private BrandHandler brandHandler;

        public addBrand(string connString)
        {
            InitializeComponent();
            this.connString = connString;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rAddProductBtn_Click(object sender, EventArgs e)
        {
            b_info = new BrandInfo();
            b_info.SetName(pCategoryTxt.Text);
            b_info.SetCategory(textBox1.Text);
            Brand brand = new Brand();
            brand.SetBrandInfo(b_info);

            brandHandler = new BrandHandler(connString);
            if (brandHandler.AddBrand(brand))
            {
                MessageBox.Show("Brand added successfully");
            }
            else
            {
                MessageBox.Show("Adding failed");
            }
        }

        private void pCategoryTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
