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
    public partial class viewPendindStores : Form
    {
        private string connString;
        private StoreInfo s_info;

        public viewPendindStores(string connString)
        {
            InitializeComponent();
            this.connString = connString;
            s_info = new StoreInfo();
        }

        private void viewPendindStores_Load(object sender, EventArgs e)
        {
            this.pENDINGSTORESTableAdapter.Fill(this.pENDINGSTORES._PENDINGSTORES);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

                // col 0 -> store name, col 1 -> owner name, col 2 -> store loc, col 3 -> store type

                s_info.SetName(row.Cells[0].Value.ToString());
                string ownerName = row.Cells[1].Value.ToString();
                s_info.SetLocation(row.Cells[2].Value.ToString());

                STYPE storeType = (STYPE)Enum.Parse(typeof(STYPE), row.Cells[3].Value.ToString());
                s_info.SetType(storeType);
                Store store = new Store(s_info);
                action actionForm = new action(connString, store, ownerName);
                actionForm.ShowDialog();

                viewPendindStores_Load(sender, e);  // to update datagrid view after taking an action accept/decline
            }
        }
    }
}
