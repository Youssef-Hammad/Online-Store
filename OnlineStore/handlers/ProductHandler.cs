using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineStore
{
    class ProductHandler
    {
        private SqlConnection sqlConnection;
        private DBConnection dbConnection;
        //private Product product;

        public ProductHandler(string connString)
        {
            dbConnection = new DBConnection(connString);
            dbConnection.Open();
            sqlConnection = dbConnection.GetSqlConnection();
        }

        public bool isFirstPurchase(User user)
        {
            string purchaseHistryQuery = "SELECT * FROM PURCHASEHISTORY WHERE USERNAME = '" + user.GetUserInfo().GetUsername() + "'";
            SqlCommand purchaseHistryCmd = new SqlCommand(purchaseHistryQuery, sqlConnection);
            SqlDataReader historyReader = purchaseHistryCmd.ExecuteReader();
            if (historyReader.Read())
                return false;
            return true;
        }

        public int GetDiscountPercent(User user,int qty)
        {
            int returnPercent = 0;
            if (user.GetUserInfo().GetUserType() == UTYPE.MERCHANT)
                returnPercent += 15;
            if (isFirstPurchase(user))
                returnPercent += 5;
            if (qty >= 2)
                returnPercent += 10;
            return returnPercent;
        }

        public bool AddProduct(Product product)
        {
            String p_name = product.GetProductInfo().GetName();
            float p_price = product.GetProductInfo().GetPrice();
            String p_category = product.GetProductInfo().GetCategory();
            string b_name = product.GetProductInfo().GetBrand().GetName();

            String query = "INSERT INTO APPROVEDPRODUCTS(BRANDNAME, PRODUCTNAME, PRODUCTPRICE, PRODUCTCAT) VALUES('" + b_name + "', '" + p_name + "', " + p_price + ", '" + p_category + "');";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

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
        /*public List<Product> GetAllApprovedProducts()
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

            //Console.WriteLine(counter);
            //Console.WriteLine(productList.Count);
            //Console.WriteLine(productList[productList.Count - 2].GetProductInfo().GetName());

            //return productList;
        //}*/
        public List<string> GetAllApprovedProductsNames()
        {
            List<string> productList = new List<string>();
            ProductInfo productInfo = new ProductInfo();

            String query = "SELECT * FROM APPROVEDPRODUCTS";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            BrandInfo brandInfo = new BrandInfo();
            int counter = 0;

            while (reader.Read())
            {
                //Console.WriteLine(reader.GetString(2));
                productList.Add(reader.GetString(2));
                counter++;
            }
            reader.Close();

            /*for(int i = 0; i < productList.Count; i++)
                Console.WriteLine(productList[i].GetProductInfo().GetName());*/

            Console.WriteLine(counter);
            Console.WriteLine(productList.Count);
            //Console.WriteLine(productList[productList.Count - 2].GetProductInfo().GetName());

            return productList;
        }
        public Product GetProductWithName(string productName)
        {
            string query = "SELECT * FROM APPROVEDPRODUCTS WHERE PRODUCTNAME='" + productName + "'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            ProductInfo productInfo = new ProductInfo();
            while(reader.Read())
            {
                productInfo.SetName(reader.GetString(2));
                productInfo.SetPrice((float)reader.GetDouble(3));
                BrandInfo brandInfo = new BrandInfo();
                string brandInfoQuery = "SELECT * FROM BRAND WHERE BRANDNAME='" + reader.GetString(1) + "'";
                SqlCommand brandInfoCmd = new SqlCommand(brandInfoQuery, sqlConnection);
                SqlDataReader brandInfoReader = brandInfoCmd.ExecuteReader();
                while(brandInfoReader.Read())
                {
                    brandInfo.SetCategory(brandInfoReader.GetString(1));
                    brandInfo.SetName(brandInfoReader.GetString(0));
                }
                productInfo.SetBrand(brandInfo);
            }
            Product returnedProduct = new Product(productInfo);
            return returnedProduct;
        }
        public void BuyProduct(string username,float price,string productName,string brandName,int qty)
        {
            string query = "SELECT PID FROM APPROVEDPRODUCTS WHERE BRANDNAME = '" + brandName + "' AND PRODUCTNAME = '" + productName + "'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            int productID = 0;

            while(reader.Read())
            {
                productID = reader.GetInt32(0);
                break;
            }
            reader.Close();
            string stockQuery = "SELECT SID,QTY FROM PRODUCTSTOCK WHERE PID = " + productID.ToString();
            SqlCommand stockCmd = new SqlCommand(stockQuery, sqlConnection);
            SqlDataReader stockReader = stockCmd.ExecuteReader();
            int quantity = 0;
            int storeID = 0;
            while (stockReader.Read())
            {
                storeID = stockReader.GetInt32(0);
                quantity = stockReader.GetInt32(1);
                break;
            }
            quantity -= qty; ;
            string updateQuery = "UPDATE PRODUCTSTOCK SET QTY = " + quantity.ToString() + " WHERE PID = " + productID.ToString() +" AND SID = "+storeID.ToString();
            SqlCommand updateCmd = new SqlCommand(updateQuery, sqlConnection);
            updateCmd.ExecuteNonQuery();

            string purchaseHistoryQuery = "INSERT INTO PURCHASEHISTORY(USERNAME,PID,SID,QTY,COST) VALUES('" + username + "'," + productID.ToString() + "," + storeID.ToString() + "," + qty.ToString() + "," + price.ToString() + ")";
            SqlCommand purchaseHistoryCmd = new SqlCommand(purchaseHistoryQuery, sqlConnection);
            purchaseHistoryCmd.ExecuteNonQuery();
        }

        public bool isValidQuantity(string quantity)
        {
            foreach(char c in quantity)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public int GetQuantity(Product product)
        {
            String query = "SELECT * FROM APPROVEDPRODUCTS WHERE BRANDNAME = '" + product.GetProductInfo().GetBrand().GetName() + "' AND PRODUCTNAME = '"+product.GetProductInfo().GetName()+"'";
            int productID=0;
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                productID = reader.GetInt32(0);
            reader.Close();

            String quantityQuery = "SELECT * FROM PRODUCTSTOCK WHERE PID = " + productID.ToString();
            SqlCommand cmdQuantity = new SqlCommand(quantityQuery, sqlConnection);
            SqlDataReader quantityReader = cmdQuantity.ExecuteReader();
            int quantity = 0;
            while (quantityReader.Read())
            {
                quantity = Math.Max(quantity,quantityReader.GetInt32(2));
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
                sqlConnection.Close();
            }
        }

        ~ProductHandler()
        {
            Dispose(false);
        }
    }

}
