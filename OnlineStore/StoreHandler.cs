using System.Data.SqlClient;

namespace OnlineStore
{
    class StoreHandler
    {
        private SqlConnection dbConnection;

        public StoreHandler(string serverName)
        {
            dbConnection = new SqlConnection("Data Source=" + serverName + ";Initial Catalog=db.sql;User ID=UserName;Password=Password");
            dbConnection.Open();
        }

        public bool AddProduct(Store store, Product product)
        {
            string pName = product.GetProductInfo().GetName();
            float pPrice = product.GetProductInfo().GetPrice();
            string pCategory = product.GetProductInfo().GetCategory();

            string storeName = store.GetStoreName();

            string query = "SELECT FROM storesProducts WHERE STORENAME = '" + storeName + "' AND PRODUCTNAME = '" + pName + "'";

            SqlCommand cmd = new SqlCommand(query, dbConnection);
			if(cmd.ExecuteScalar()==null)
            {
                query = "INSERT INTO storeProducts(STORENAME,PRODUCTNAME) VALUES('" + storeName + "','" + pName + "')";

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

            string storeName = store.GetStoreName();

            string query = "SELECT FROM storesProducts WHERE STORENAME = '" + storeName + "' AND PRODUCTNAME = '" + pName + "'";

            SqlCommand cmd = new SqlCommand(query, dbConnection);

            if (cmd.ExecuteScalar() == null)
                return false;
			else
            {
                query = "DELETE FROM storeProducts WHERE STORENAME= '" + storeName + "' AND PRODUCTNAME='" + pName + "'";

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
