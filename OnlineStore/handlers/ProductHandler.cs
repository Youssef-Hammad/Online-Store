using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineStore
{
    class ProductHandler
    {
        private SqlConnection dbConnection;
        //private Product product;

        public ProductHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
            dbConnection.Open();
        }

        public bool AddProduct(Product product)
        {
            String p_name = product.GetProductInfo().GetName();
            float p_price = product.GetProductInfo().GetPrice();
            String p_category = product.GetProductInfo().GetCategory();

            String query = "INSERT INTO products(NAME, PRICE, CATEGORY) VALUES('" + p_name + "', " + p_price + ", '" + p_category + "')";
            SqlCommand cmd = new SqlCommand(query, dbConnection);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                dbConnection.Close();
            }
        }

        ~ProductHandler()
        {
            Dispose(false);
        }
    }

}
