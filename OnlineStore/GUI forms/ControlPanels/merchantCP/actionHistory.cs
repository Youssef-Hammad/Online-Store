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
    public partial class actionHistory : Form
    {
        private string connString;
        private MerchantHandler merchantHandler;
        private StoreActionHandler storeActionHandler;
        private List<string> merchantStoresNames;

        private void InitStoresList(User currMerchant, ComboBox comboBox)
        {
            merchantHandler = new MerchantHandler(connString);
            merchantStoresNames = merchantHandler.GetMerchantStoresNames(currMerchant);
            foreach (var storeName in merchantStoresNames)
            {
                comboBox1.Items.Add(storeName);
            }
        }

        private void FillDataGridView(DataGridView dataGridView)
        {
            SqlCommand cmd = storeActionHandler.GetActionHistory(comboBox1.Text);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            System.Data.DataSet dataset = new System.Data.DataSet();
            dataAdapter.Fill(dataset);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = dataset.Tables[0];
        }

        public actionHistory(string connString, User currUser)
        {
            this.connString = connString;
            merchantHandler = new MerchantHandler(connString);
            InitializeComponent();
            InitStoresList(currUser, comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            storeActionHandler = new StoreActionHandler(connString);
            FillDataGridView(dataGridView1);
        }

        private void actionHistory_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

                // col 0 -> action id, col 1 -> store id, col 2 -> product name, col 3 -> action statement

                string storeId = row.Cells[1].Value.ToString();
                string productName = row.Cells[2].Value.ToString();
                string actionStatement = row.Cells[3].Value.ToString();
                
                // [IN PROGRESS]

                //action actionForm = new action(connString, store, ownerName);
                //actionForm.ShowDialog();
            }
        }
    }
}
