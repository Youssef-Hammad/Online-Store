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
        private List<Store> merchantStores;
        private User currUser;

        private void InitStoresList(User currMerchant, ComboBox comboBox)
        {
            merchantHandler = new MerchantHandler(connString);
            merchantStores = merchantHandler.GetMerchantStores(currMerchant);
            foreach (Store store in merchantStores)
            {
                comboBox1.Items.Add(store.GetStoreInfo().GetName());
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
            this.currUser = currUser;
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

                // col 0 -> action id, col 1 -> store id, col 2 -> product name, col 3 -> action statement, col 4 -> quantity

                Int32 storeId = (Int32) row.Cells[1].Value;
                string productName = row.Cells[2].Value.ToString();
                string actionStatement = row.Cells[3].Value.ToString();
                Int32 quantity = (Int32) row.Cells[4].Value;

                Undo actionForm = new Undo(connString, currUser, storeId, productName, quantity, actionStatement);
                actionForm.ShowDialog();

                actionHistory_Load(sender, e);
            }
        }
    }
}
