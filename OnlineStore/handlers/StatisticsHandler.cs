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
        private SqlConnection dbConnection;

        public StatisticsHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
            dbConnection.Open();
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

                SqlCommand commandStoreID = new SqlCommand(queryStoreID, dbConnection);
                reader = commandStoreID.ExecuteReader();

                if (!reader.Read())
                    return 0;

                queryCount = "SELECT COUNT(*) FROM STORES INNER JOIN PURCHASEHISTORY on PURCHASEHISTORY.SID = " + Convert.ToString(reader.GetInt32(0));

                reader.Close();

                SqlCommand commandCount = new SqlCommand(queryCount, dbConnection);

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

                SqlCommand commandStoreID = new SqlCommand(queryStoreID, dbConnection);
                reader = commandStoreID.ExecuteReader();
                if (!reader.Read())
                    return 0;
                queryProductViews = "SELECT PRODUCTVIEWS FROM STORESTATISTICS WHERE SID = " + Convert.ToString(reader.GetInt32(0));

                reader.Close();

                SqlCommand commandProdutViews = new SqlCommand(queryProductViews, dbConnection);
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

                SqlCommand commandStoreID = new SqlCommand(queryStoreID, dbConnection);
                reader = commandStoreID.ExecuteReader();

                if (!reader.Read())
                    return returnList;

                queryProducts = "SELECT BRANDNAME,PRODUCTNAME,PRODUCTPRICE,PRODUCTCAT FROM APPROVEDPRODUCTS INNER JOIN PRODUCTSTOCK ON APPROVEDPRODUCTS.PID = PRODUCTSTOCK.PID WHERE PRODUCTSTOCK.QTY = 0 AND PRODUCTSTOCK.SID = " + Convert.ToString(reader.GetInt32(0));

                reader.Close();

                SqlCommand commandProducts = new SqlCommand(queryProducts, dbConnection);

                reader = commandProducts.ExecuteReader();

                while (reader.Read())
                {
                    queryBrandInfo = "SELECT * FROM BRAND WHERE BRANDNAME = '" + reader.GetString(0) + "'";
                    SqlCommand commandBrand = new SqlCommand(queryBrandInfo, dbConnection);
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

        ~StatisticsHandler()
        {
            Dispose(false);
        }

    }
}
