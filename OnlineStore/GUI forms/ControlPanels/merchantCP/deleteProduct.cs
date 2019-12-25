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
    public partial class deleteProduct : Form
    {
        private User currUser;
        private List<Store> stores;
        private List<string> productNames;
        private MerchantHandler merchantHandler;
        private StoreHandler storeHandler;
        private string choosenStoreName;
        private string productToDelete;

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

        public deleteProduct(string connString, User merchant)
        {
            currUser = merchant;
            merchantHandler = new MerchantHandler(connString);
            storeHandler = new StoreHandler(connString);
            stores = merchantHandler.GetMerchantStores(currUser);
            InitializeComponent();
            InitStoreList(stores, comboBox1);
        }

        private void deleteProduct_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LiveStatistics_Click(object sender, EventArgs e)
        {
            merchantHandler.DeleteProductFromStore(currUser, choosenStoreName, productToDelete);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosenStoreName = comboBox1.Text;
            productNames = storeHandler.GetStoreProducts(currUser, choosenStoreName);
            InitProductList(productNames, comboBox2);
            productToDelete = comboBox2.Text;
        }
    }
}
