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
        SqlConnection dbConnection;

        public BrandHandler(string connString)
        {
            dbConnection = new SqlConnection(connString);
            dbConnection.Open();
        }

        public bool AddBrand(Brand brand)
        {

            string brandName = brand.GetBrandInfo().GetName();
            string brandCat = brand.GetBrandInfo().GetCategory();

            // insert the given brand if doesn't exists (i.e brand name AND brand category don't exist 

            string query = "IF NOT EXISTS ( SELECT * FROM BRAND WHERE BRANDNAME = '" + brandName + "' and BRANDCAT = '" + brandCat + "')" +
                           "Begin INSERT INTO BRAND VALUES ('" + brandName + "','" + brandCat + "') End";
         
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

        ~BrandHandler()
        {
            Dispose(false);
        }

    }
}
