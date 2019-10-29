using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    class ProductHandler
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private String connectionString;
        private Product product;

        public ProductHandler()
        {
            // edit connection string to real values
            connectionString = "Data Source=ServerName;Initial Catalog=db.sql;User ID=UserName;Password=Password";

            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public SqlCommand Cmd { get => cmd; set => cmd = value; }

        public bool AddProduct(Product product)
        {
            String p_name = product.GetProductInfo().GetName();
            float p_price = product.GetProductInfo().GetPrice();
            String p_category = product.GetProductInfo().GetCategory();

            String query = "INSERT INTO products(NAME, PRICE, CATEGORY)VALUES(" + p_name + ", " + p_price + ", " + p_category + ")";
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

        public void CloseConn()
        {
            conn.Close();
        }

    }

}
