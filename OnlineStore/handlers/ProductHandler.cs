﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.classes
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

        public void CloseConn()
        {
            dbConnection.Close();
        }

    }

}