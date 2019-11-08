using System.Data.SqlClient;

namespace OnlineStore
{
    class StoreHandler
    {
        private SqlConnection dbConnection;

        public StoreHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
            dbConnection.Open();
        }

        public bool AddProduct(Store store, Product product)
        {
            string pName = product.GetProductInfo().GetName();
            float pPrice = product.GetProductInfo().GetPrice();
            string pCategory = product.GetProductInfo().GetCategory();

            StoreInfo sInfo = store.GetStoreInfo();
            string sName = sInfo.GetName();

            string query = "SELECT FROM storesProducts WHERE STORENAME = '" + sName + "' AND PRODUCTNAME = '" + pName + "'";

            SqlCommand cmd = new SqlCommand(query, dbConnection);
			if(cmd.ExecuteScalar()==null)
            {
                query = "INSERT INTO storeProducts(STORENAME,PRODUCTNAME) VALUES('" + sName + "','" + pName + "')";

                cmd = new SqlCommand(query, dbConnection);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return false;
                }
            }
			else
            {
                return false;
            }
        }

		public bool RemoveProduct(Store store,Product product)
        {
            string pName = product.GetProductInfo().GetName();
            float pPrice = product.GetProductInfo().GetPrice();
            string pCategory = product.GetProductInfo().GetCategory();

            StoreInfo sInfo = store.GetStoreInfo();
            string sName = sInfo.GetName();

            string query = "SELECT FROM storesProducts WHERE STORENAME = '" + sName + "' AND PRODUCTNAME = '" + pName + "'";

            SqlCommand cmd = new SqlCommand(query, dbConnection);

            if (cmd.ExecuteScalar() == null)
                return false;
			else
            {
                query = "DELETE FROM storeProducts WHERE STORENAME= '" + sName + "' AND PRODUCTNAME='" + pName + "'";

                cmd = new SqlCommand(query, dbConnection);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

		public void CloseConnection()
        {
            dbConnection.Close();
        }
    }
}
