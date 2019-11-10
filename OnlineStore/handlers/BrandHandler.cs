using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class BrandHandler
    {
        SqlConnection dbConnection;

        public BrandHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
            dbConnection.Open();
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

        public void AddBrand(Brand brand)
        {

            string brandName = brand.GetBrandInfo().GetName();
            string brandCat = brand.GetBrandInfo().GetCategory();

            string query = "INSERT into BRAND values ('" + brandName + "', '" + brandCat + "');";
            SqlCommand cmd = new SqlCommand(query, dbConnection);
            cmd.ExecuteNonQuery();
        }

        public List<string> GetBrandsNames()
        {
            string query = "SELECT BRANDNAME FROM BRAND;";

            SqlCommand cmd = new SqlCommand(query, dbConnection);

            var reader = cmd.ExecuteReader();
            List<string> brands = new List<String>();

            while (reader.Read())
            {
                brands.Add(reader.GetString(0));
            }
            return brands;
        }

        ~BrandHandler()
        {
            Dispose(false);
        }

    }
}
