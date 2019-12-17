using System;
using System.Collections.Generic;
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
            string b_name = product.GetProductInfo().GetBrand().GetName();

            String query = "INSERT INTO APPROVEDPRODUCTS(BRANDNAME, PRODUCTNAME, PRODUCTPRICE, PRODUCTCAT) VALUES('" + b_name + "', '" + p_name + "', " + p_price + ", '" + p_category + "');";
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
        public List<Product> GetAllApprovedProducts()
        {
            List<Product> productList = new List<Product>();
            ProductInfo productInfo = new ProductInfo();

            String query = "SELECT * FROM APPROVEDPRODUCTS";
            SqlCommand cmd = new SqlCommand(query,dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            BrandInfo brandInfo = new BrandInfo();
            int counter = 0;

            while(reader.Read())
            {
                //Console.WriteLine(reader.GetString(2));
                productInfo.SetName(reader.GetString(2));
                productInfo.SetPrice((float)reader.GetDouble(3));
                productInfo.SetCategory(reader.GetString(4));
                String brandQuery = "SELECT * FROM BRAND WHERE BRANDNAME = '" + reader.GetString(1) + "'";
                SqlCommand brandCmd = new SqlCommand(brandQuery,dbConnection);
                SqlDataReader brandReader = brandCmd.ExecuteReader();
                while(brandReader.Read())
                {
                    brandInfo.SetCategory(brandReader.GetString(1));
                    brandInfo.SetName(brandReader.GetString(0));
                }
                brandReader.Close();
                productInfo.SetBrand(brandInfo);
                Product product = new Product(productInfo);
                //Console.WriteLine(product.GetProductInfo().GetName());
                productList.Add(product);
                counter++;
            }
            reader.Close();

            /*for(int i = 0; i < productList.Count; i++)
                Console.WriteLine(productList[i].GetProductInfo().GetName());*/

            Console.WriteLine(counter);
            Console.WriteLine(productList.Count);
            Console.WriteLine(productList[productList.Count - 2].GetProductInfo().GetName());

            return productList;
        }

        public void BuyProduct(string productName,string brandName)
        {
            string query = "SELECT PID FROM APPROVEDPRODUCTS WHERE BRANDNAME = '" + brandName + "' AND PRODUCTNAME = '" + productName + "'";
            SqlCommand cmd = new SqlCommand(query, dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            int productID = 0;

            while(reader.Read())
            {
                productID = reader.GetInt32(0);
                break;
            }
            reader.Close();
            string stockQuery = "SELECT QTY FROM PRODUCTSTOCK WHERE PID = " + productID.ToString();
            SqlCommand stockCmd = new SqlCommand(stockQuery, dbConnection);
            SqlDataReader stockReader = stockCmd.ExecuteReader();
            int quantity = 0;
            while (stockReader.Read())
            {
                quantity = reader.GetInt32(0);
                break;
            }
            quantity--;
            string updateQuery = "UPDATE PRODUCTSTOCK SET QTY = " + quantity + " WHERE PID = " + productID;
            SqlCommand updateCmd = new SqlCommand(updateQuery, dbConnection);
            updateCmd.ExecuteNonQuery();
        }

        public int GetQuantity(Product product)
        {
            String query = "SELECT * FROM APPROVEDPRODUCTS WHERE BRANDNAME = '" + product.GetProductInfo().GetBrand().GetName() + "' AND PRODUCTNAME = '"+product.GetProductInfo().GetName()+"'";
            int productID=0;
            SqlCommand cmd = new SqlCommand(query,dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                productID = reader.GetInt32(0);
            reader.Close();

            String quantityQuery = "SELECT * FROM PRODUCTSTOCK WHERE PID = " + productID.ToString();
            SqlCommand cmdQuantity = new SqlCommand(quantityQuery,dbConnection);
            SqlDataReader quantityReader = cmdQuantity.ExecuteReader();
            int quantity = 0;
            while (quantityReader.Read())
            {
                quantity = quantityReader.GetInt32(2);
            }
            return quantity;
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
