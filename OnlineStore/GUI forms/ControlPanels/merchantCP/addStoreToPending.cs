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
    public partial class addStoreToPending : Form
    {
        private StoreHandler sHandler;
        private User currUser;
        private StoreInfo sInfo;
        private string connString;

        public addStoreToPending(string par_connString, User par_currUser)
        {
            InitializeComponent();
            sInfo = new StoreInfo();
            this.connString = par_connString;
            currUser = par_currUser;
            storeErrorLabel.Hide();
        }

        private void addStoreToPending_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sLocationTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void storeTypesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*storeTypesMenu.Items.Add("Select Store Type");
            storeTypesMenu.Items.Add("Clothes");
            storeTypesMenu.Items.Add("Entertainment");
            storeTypesMenu.Items.Add("Sports");
            storeTypesMenu.Items.Add("Technology");*/
        }

        private void rAddStoreBtn_Click(object sender, EventArgs e)
        {
            
            string storeName = sNameTxt.Text;
            string storeLocation = sLocationTxt.Text;
            string storeType = storeTypesMenu.Text;
            sHandler = new StoreHandler(connString);


            if (storeName.Length==0)
            {
                storeErrorLabel.Text = "Store Name can't be empty!";
                storeErrorLabel.Show();
            }
            else if(storeLocation.Length==0)
            {
                storeErrorLabel.Text = "Store Location can't be empty!";
                storeErrorLabel.Show();
            }
            else if(storeType.Length==0)
            {
                storeErrorLabel.Text = "Store Category can't be empty!";
                storeErrorLabel.Show();
            }
            else
            {
                sInfo.SetName(storeName);
                sInfo.SetLocation(storeLocation);
                STYPE passed=0;
                if (storeType == "Clothes")
                    passed = (STYPE)3;
                else if (storeType == "Entertainment")
                    passed = (STYPE)2;
                else if (storeType == "Sports")
                    passed = (STYPE)1;
                else if (storeType == "Technology")
                    passed = (STYPE)4;
                sInfo.SetType(passed);

                Console.WriteLine(Convert.ToInt32(passed));

                Store tempStore = new Store(sInfo);

                if (sHandler.AlreadyExists(tempStore))
                {
                    storeErrorLabel.Text = "Store already pending or exists";
                    storeErrorLabel.Show();
                }
                else
                {
                    if(sHandler.AddPendingStore(tempStore,currUser))
                    {
                        MessageBox.Show("Store Successfully Added!");
                        this.Hide();
                    }
                }
            }
        }

        private void storeNameEmpty_Click_1(object sender, EventArgs e)
        {

        }
    }
}
