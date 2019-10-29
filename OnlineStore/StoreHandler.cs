namespace OnlineStore
{
    class StoreHandler
    {
        private SqlConnection dbConnection;
        private SqlCommand cmd;

        public StoreHandler(string serverName)
        {
            // edit connection string to real values
            connectionString = "Data Source=" + serverName + ";Initial Catalog=db.sql;User ID=UserName;Password=Password";

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
        }

        public SqlCommand Cmd { get => cmd; set => cmd = value; }

        public bool AddProduct(Store store, Product product)
        {
            string pName = product.p_name;
            float pPrice = product.p_price;
            string pCategory = product.p_category;

            string storeName = store.GetStoreName();

            string query = "GET FROM storesProducts WHERE STORENAME = '" + storeName + "' AND PRODUCTNAME = '" + pName + "'";

            dbConnection.CommandText = query;
			if(dbConnection.ExecuteScalar()==null)
            {
                query = "INSERT INTO storeProducts(STORENAME,PRODUCTNAME) VALUES('" + storeName + "','" + pName + "')";

                Cmd = new SqlCommand(query, conn);

                try
                {
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
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
            string pName = product.p_name;
            float pPrice = product.p_price;
            string pCategory = product.p_category;

            string storeName = store.GetStoreName();

            string query = "GET FROM storesProducts WHERE STORENAME = '" + storeName + "' AND PRODUCTNAME = '" + pName + "'";

            dbConnection.CommandText = query;

            if (dbConnection.ExecuteScalar() == null)
                return false;
			else
            {
                query = "DELETE FROM storeProducts WHERE STORENAME= '" + storeName + "' AND PRODUCTNAME='" + pName + "'";

                Cmd = new SqlCommand(query, conn);

                try
                {
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
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
