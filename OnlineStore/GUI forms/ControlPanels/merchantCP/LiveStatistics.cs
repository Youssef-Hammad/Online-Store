using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class LiveStatistics : Form
    {
        private string connString;
        private User currUser;
        private MerchantHandler merchHandler;
        private StatisticsHandler statHandler;
        private List<Store> merchStoreList;

        public LiveStatistics(string par_connString, User par_currUser)
        {
            InitializeComponent();
            this.connString = par_connString;
            this.currUser = par_currUser;
            this.merchHandler = new MerchantHandler(connString);
            this.statHandler = new StatisticsHandler(connString);
            merchStoreList = merchHandler.GetMerchantStores(currUser);
        }

        private void LiveStatistics_Load(object sender, EventArgs e)
        {

        }

        private void showViewsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showViewsCheckBox.Checked == true)
                NumberOfViewsLabel.Show();
            else
                NumberOfViewsLabel.Hide();
        }

        private void NumberOfViewsLabel_Click(object sender, EventArgs e)
        {

        }

        private void showPurchasesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPurchasesCheckBox.Checked == true)
                NumberOfPurchasesLabel.Show();
            else
                NumberOfPurchasesLabel.Hide();
        }

        private void ShowStatisticsBtn_Click(object sender, EventArgs e)
        {
            
            int numberOfViews = statHandler.GetProductViews(merchStoreList);
            int numberOfPurchases = statHandler.GetNumberOfPurchases(merchStoreList);

            NumberOfPurchasesLabel.Text = "Number of Purchases: " + Convert.ToString(numberOfPurchases);
            NumberOfViewsLabel.Text = "Number of views: " + Convert.ToString(numberOfViews);



            List<KeyValuePair<Product, Store>> soldoutProducts = statHandler.GetSoldOutProducts(merchStoreList);

            foreach (var iterator in soldoutProducts)
            {
                string listOutput = "Product: " + iterator.Key.GetProductInfo().GetName() + ". Belonging to Store: " + iterator.Value.GetStoreInfo().GetName() + " Located at: " + iterator.Value.GetStoreInfo().GetLocaction();
                ListViewItem listViewItem = new ListViewItem(listOutput);
                SoldoutListView.Items.Add(listViewItem);
            }

        }

        private void SoldoutListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SoldoutListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
