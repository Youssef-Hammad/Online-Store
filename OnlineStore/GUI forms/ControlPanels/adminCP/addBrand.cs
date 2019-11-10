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
        private BrandInfo b_info;
        private BrandHandler brandHandler;
        private string connString;

        public addBrand(string connString)
        {
            InitializeComponent();
            this.connString = connString;
        }

        private void addBrand_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rAddProductBtn_Click(object sender, EventArgs e)
        {
            b_info = new BrandInfo();
            b_info.SetName(textBox1.Text);
            b_info.SetCategory(pNameTxt.Text);
            Brand brand = new Brand();
            brand.SetBrandInfo(b_info);


            brandHandler = new BrandHandler(connString);
            if(brandHandler.AddBrand(brand))
            {
                MessageBox.Show("Operation was successful");
            }
            else
            {
                MessageBox.Show("Can't add brand");
            }
            brandHandler.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
