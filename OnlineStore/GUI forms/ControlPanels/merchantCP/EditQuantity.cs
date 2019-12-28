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
    public partial class EditQuantity : Form
    {
        private User currUser;
        private MerchantHandler merchantHandler;
        private StoreHandler storeHandler;
        private List<Store> stores;
        private List<string> productNames;
        private string choosenStoreName;
        private string choosemProductName;
        private int newQty;

        private void InitStoreList(List<Store> storeList, ComboBox comboBox)
        {
            foreach (Store store in storeList)
            {
                string storeName = store.GetStoreInfo().GetName();
                comboBox.Items.Add(storeName);
            }
        }

        private void InitProductList(List<string> prodList, ComboBox comboBox)
        {
            foreach (string productName in prodList)
            {
                comboBox.Items.Add(productName);
            }
        }

        public EditQuantity(string connString, User currUser)
        {
            this.currUser = currUser;
            merchantHandler = new MerchantHandler(connString);
            storeHandler = new StoreHandler(connString);
            stores = merchantHandler.GetMerchantStores(currUser);
            InitializeComponent();
            InitStoreList(stores, comboBox1);
        }

        private void EditQuantity_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            choosenStoreName = comboBox1.Text;
            productNames = storeHandler.GetStoreProducts(currUser, choosenStoreName);
            InitProductList(productNames, comboBox2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            choosemProductName = comboBox2.Text;
            newQty = Convert.ToInt32(textBox1.Text);
            merchantHandler.EditProductQty(currUser, choosenStoreName, choosemProductName, newQty);
            MessageBox.Show("Product quantity updated successfuly");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
