using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class StatisticsHandler
    {
        private DBConnection dbConnection;
        private SqlConnection sqlConnection;

        public StatisticsHandler(string connString)
        {
            dbConnection = new DBConnection(connString);
            dbConnection.Open();
            sqlConnection = dbConnection.GetSqlConnection();
        }

        public int GetNumberOfPurchases(List<Store> storeList)
        {
            int returnValue = 0;
            string queryCount = "";
            string queryStoreID = "";
            SqlDataReader reader;
            foreach (var iterator in storeList)
            {
                queryStoreID = "SELECT SID FROM STORES WHERE STORENAME = '" + iterator.GetStoreInfo().GetName() + "' AND STORELOC = '" + iterator.GetStoreInfo().GetLocaction() + "'";

                SqlCommand commandStoreID = new SqlCommand(queryStoreID, sqlConnection);
                reader = commandStoreID.ExecuteReader();

                if (!reader.Read())
                    return 0;

                queryCount = "SELECT COUNT(*) FROM STORES INNER JOIN PURCHASEHISTORY on PURCHASEHISTORY.SID = " + Convert.ToString(reader.GetInt32(0));

                reader.Close();

                SqlCommand commandCount = new SqlCommand(queryCount, sqlConnection);

                returnValue += Convert.ToInt32(commandCount.ExecuteScalar());

            }
            return returnValue;
        }

        public int GetProductViews(List<Store> storeList)
        {
            int returnValue = 0;
            string queryProductViews = "";
            string queryStoreID = "";
            SqlDataReader reader;
            foreach (var iterator in storeList)
            {
                queryStoreID = "SELECT SID FROM STORES WHERE STORENAME = '" + iterator.GetStoreInfo().GetName() + "' AND STORELOC = '" + iterator.GetStoreInfo().GetLocaction() + "'";

                SqlCommand commandStoreID = new SqlCommand(queryStoreID, sqlConnection);
                reader = commandStoreID.ExecuteReader();
                if (!reader.Read())
                    return 0;
                queryProductViews = "SELECT PRODUCTVIEWS FROM STORESTATISTICS WHERE SID = " + Convert.ToString(reader.GetInt32(0));

                reader.Close();

                SqlCommand commandProdutViews = new SqlCommand(queryProductViews, sqlConnection);
                reader = commandProdutViews.ExecuteReader();

                if (!reader.Read())
                    return 0;

                returnValue += Convert.ToInt32(reader.GetInt32(0));
                reader.Close();
            }
            return returnValue;
        }

        public List<KeyValuePair<Product, Store>> GetSoldOutProducts(List<Store> storeList)
        {
            List<KeyValuePair<Product, Store>> returnList = new List<KeyValuePair<Product, Store>>();
            string queryStoreID = "";
            string queryProducts = "";
            string queryBrandInfo = "";
            BrandInfo tempBrandInfo = new BrandInfo();
            SqlDataReader readerBrand;
            SqlDataReader reader;
            ProductInfo tempProductInfo = new ProductInfo();

            foreach (var iterator in storeList)
            {
                queryStoreID = "SELECT SID FROM STORES WHERE STORENAME = '" + iterator.GetStoreInfo().GetName() + "' AND STORELOC = '" + iterator.GetStoreInfo().GetLocaction() + "'";

                SqlCommand commandStoreID = new SqlCommand(queryStoreID, sqlConnection);
                reader = commandStoreID.ExecuteReader();

                if (!reader.Read())
                    return returnList;

                queryProducts = "SELECT BRANDNAME,PRODUCTNAME,PRODUCTPRICE,PRODUCTCAT FROM APPROVEDPRODUCTS INNER JOIN PRODUCTSTOCK ON APPROVEDPRODUCTS.PID = PRODUCTSTOCK.PID WHERE PRODUCTSTOCK.QTY = 0 AND PRODUCTSTOCK.SID = " + Convert.ToString(reader.GetInt32(0));

                reader.Close();

                SqlCommand commandProducts = new SqlCommand(queryProducts, sqlConnection);

                reader = commandProducts.ExecuteReader();

                while (reader.Read())
                {
                    queryBrandInfo = "SELECT * FROM BRAND WHERE BRANDNAME = '" + reader.GetString(0) + "'";
                    SqlCommand commandBrand = new SqlCommand(queryBrandInfo, sqlConnection);
                    readerBrand = commandBrand.ExecuteReader();

                    if (!readerBrand.Read())
                        break;

                    tempBrandInfo.SetName(readerBrand.GetString(0));
                    tempBrandInfo.SetCategory(readerBrand.GetString(1));

                    readerBrand.Close();

                    tempProductInfo.SetBrand(tempBrandInfo);

                    tempProductInfo.SetName(reader.GetString(1));
                    tempProductInfo.SetPrice((float)reader.GetDouble(2));
                    tempProductInfo.SetCategory(reader.GetString(3));

                    Product tempProduct = new Product(tempProductInfo);
                    returnList.Add(new KeyValuePair<Product, Store>(tempProduct, iterator));
                }

            }

            return returnList;
        }

        public int SumUser()
        {
            string query = "SELECT COUNT(*) FROM [USER] WHERE UTYPE = 2;";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count;
        }

        public string MaxUser()
        {
            string query = "SELECT u.USERNAME, u.EMAIL, MAX(p.QTY) " +
                            "FROM [USER] as u, PURCHASEHISTORY as p " +
                            "WHERE u.USERNAME = p.USERNAME " +
                            "GROUP BY u.USERNAME, u.EMAIL;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            string output = "";
            if(reader.HasRows)
            {
                output += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
                return output;
            }

            output = "No data in the database";
            return output;
        }

        public string MinUser()
        {
            string query = "SELECT u.USERNAME, u.EMAIL, MIN(p.QTY) " +
                            "FROM [USER] as u, PURCHASEHISTORY as p " +
                            "WHERE u.USERNAME = p.USERNAME " +
                            "GROUP BY u.USERNAME, u.EMAIL;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            string output = "";
            if (reader.HasRows)
            {
                output += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
                return output;
            }

            output = "No data in the database";
            return output;
        }

        public string AvgUser()
        {
            string query = "SELECT u.USERNAME, u.EMAIL, AVG(p.QTY) " +
                            "FROM [USER] as u, PURCHASEHISTORY as p " +
                            "WHERE u.USERNAME = p.USERNAME " +
                            "GROUP BY u.USERNAME, u.EMAIL;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            string output = "";
            if (reader.HasRows)
            {
                output += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
                return output;
            }

            output = "No data in the database";
            return output;
        }

        public int SumProduct()
        {
            string query = "SELECT COUNT(*) FROM PURCHASEHISTORY;";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count;
        }

        public string MaxProduct()
        {
            string query = "SELECT a.PRODUCTNAME, a.PRODUCTPRICE, a.PRODUCTCAT,  MAX(p.QTY) " +
                           "FROM APPROVEDPRODUCTS AS a, PURCHASEHISTORY AS p " +
                           "WHERE a.PID = p.PID " +
                           "GROUP BY a.PRODUCTNAME, a.PRODUCTPRICE, a.PRODUCTCAT;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            string output = "";
            if (reader.HasRows)
            {
                output += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString();
                return output;
            }

            output = "No data in the database";
            return output;
        }

        public string MinProduct()
        {
            string query = "SELECT a.PRODUCTNAME, a.PRODUCTPRICE, a.PRODUCTCAT,  MIN(p.QTY) " +
                           "FROM APPROVEDPRODUCTS AS a, PURCHASEHISTORY AS p " +
                           "WHERE a.PID = p.PID " +
                           "GROUP BY a.PRODUCTNAME, a.PRODUCTPRICE, a.PRODUCTCAT;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            string output = "";
            if (reader.HasRows)
            {
                output += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString();
                return output;
            }

            output = "No data in the database";
            return output;
        }

        public string AvgProduct()
        {
            string query = "SELECT a.PRODUCTNAME, a.PRODUCTPRICE, a.PRODUCTCAT,  AVG(p.QTY) " +
                           "FROM APPROVEDPRODUCTS AS a, PURCHASEHISTORY AS p " +
                           "WHERE a.PID = p.PID " +
                           "GROUP BY a.PRODUCTNAME, a.PRODUCTPRICE, a.PRODUCTCAT;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            string output = "";
            if (reader.HasRows)
            {
                output += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString();
                return output;
            }

            output = "No data in the database";
            return output;
        }

        ~StatisticsHandler()
        {
            dbConnection.Dispose(false);
        }

    }
}
