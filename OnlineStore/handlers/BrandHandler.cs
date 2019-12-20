using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    class BrandHandler
    {
        private DBConnection dbConnection;
        private SqlConnection sqlConnection;

        public BrandHandler(string connString)
        {
            dbConnection = new DBConnection(connString);
            dbConnection.Open();
            sqlConnection = dbConnection.GetSqlConnection();
        }

        public bool AddBrand(Brand brand)
        {

            string brandName = brand.GetBrandInfo().GetName();
            string brandCat = brand.GetBrandInfo().GetCategory();

            string query = "IF NOT EXISTS (SELECT * FROM BRAND WHERE BRANDNAME = '" + brandName + "' AND BRANDCAT = '" + brandCat + "')" + 
                           "Begin INSERT INTO BRAND VALUES ('" + brandName + "','" + brandCat + "') End";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            return cmd.ExecuteNonQuery() > 0;       // this return the number of affected rows, if > 0, brand added and no duplications found
        }

        public List<string> GetBrandsNames()
        {
            string query = "SELECT BRANDNAME FROM BRAND;";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

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
            dbConnection.Dispose(false);
        }

    }
}
