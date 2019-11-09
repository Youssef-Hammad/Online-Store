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
            string queryCount="";
            string queryStoreID = "";
            SqlDataReader reader;
            foreach (var iterator in storeList)
            {
                queryStoreID = "SELECT SID FROM STORES WHERE STORENAME = '" + iterator.GetStoreInfo().GetName() + "' AND STORELOC = '" + iterator.GetStoreInfo().GetLocaction() + "'";

                SqlCommand commandStoreID = new SqlCommand(queryStoreID, dbConnection);
                reader = commandStoreID.ExecuteReader();

                queryCount = "SELECT COUNT(*) FROM STORES INNER JOIN PURCHASEHISTORY on PURCHASEHISTORY.SID = "+ reader.GetString(0);

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
            foreach(var iterator in storeList)
            {
                queryStoreID = "SELECT SID FROM STORES WHERE STORENAME = '" + iterator.GetStoreInfo().GetName() + "' AND STORELOC = '" + iterator.GetStoreInfo().GetLocaction() + "'";

                SqlCommand commandStoreID = new SqlCommand(queryStoreID, dbConnection);
                reader = commandStoreID.ExecuteReader();

                queryProductViews = "SELECT PRODUCTVIEWS FROM STORESTATISTICS WHERE SID = " + reader.GetString(0);

                SqlCommand commandProdutViews = new SqlCommand(queryProductViews, dbConnection);
                reader = commandProdutViews.ExecuteReader();

                returnValue += Convert.ToInt32(reader.GetString(0));
            }
            return returnValue;
        }

        public List<Product> GetSoldOutProducts(List<Store> storeList)
        {
            List<Product> returnList = new List<Product>();
            string queryStoreID = "";
            string queryProducts = "";
            string queryBrandInfo = "";
            BrandInfo tempBrandInfo = new BrandInfo();
            SqlDataReader readerBrand;
            SqlDataReader reader;
            ProductInfo tempProductInfo = new ProductInfo();

            foreach(var iterator in storeList)
            {
                queryStoreID = "SELECT SID FROM STORES WHERE STORENAME = '" + iterator.GetStoreInfo().GetName() + "' AND STORELOC = '" + iterator.GetStoreInfo().GetLocaction() + "'";

                SqlCommand commandStoreID = new SqlCommand(queryStoreID, dbConnection);
                reader = commandStoreID.ExecuteReader();

                queryProducts = "SELECT BRANDNAME,PRODUCTNAME,PRODUCTPRICE,PRODUCTCAT FROM APPROVEDPRODUCTS INNER JOIN PRODUCTSTOCK ON APPROVEDPRODUCTS.PID = PRODUCTSTOCK.PID WHERE PRODUCTSTOCK.QTY = 0 AND PRODUCTSTOCK.SID = " + reader.GetString(0);

                SqlCommand commandProducts = new SqlCommand(queryProducts, dbConnection);

                while(reader.Read())
                {
                    queryBrandInfo = "SELECT * FROM BRAND WHERE BRANDNAME = '" + reader.GetString(0) + "'";
                    SqlCommand commandBrand = new SqlCommand(queryBrandInfo, dbConnection);
                    readerBrand = commandBrand.ExecuteReader();
                    tempBrandInfo.SetName(readerBrand.GetString(0));
                    tempBrandInfo.SetCategory(readerBrand.GetString(1));

                    tempProductInfo.SetBrand(tempBrandInfo);

                    tempProductInfo.SetName(reader.GetString(1));
                    tempProductInfo.SetPrice(Convert.ToInt32(reader.GetString(2)));
                    tempProductInfo.SetCategory(reader.GetString(3));

                    Product tempProduct = new Product(tempProductInfo);
                    returnList.Add(tempProduct);
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
