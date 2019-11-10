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
    public partial class adminPanel : Form
    {
        private String connString;
        public adminPanel(String connString)
        {
            InitializeComponent();
            this.connString = connString;
        }

        private void rRegisterBtn_Click(object sender, EventArgs e)
        {
            addProduct productForm = new addProduct(connString);
            productForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBrand brandForm = new addBrand(connString);
            brandForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewPendindStores storesForm = new viewPendindStores(connString);
            storesForm.ShowDialog();
        }
    }
}
