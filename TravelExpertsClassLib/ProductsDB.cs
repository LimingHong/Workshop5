using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TravelExpertsClassLib
{
    public class ProductsDB : TravelExpertsDB
    {


        //method for creating an empty list wich will display data
        public static List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();
            try
            {
                Products Pro; // for reading

                string selectQuery = "SELECT ProductId,  ProdName " +
                                     "FROM Products " +
                                     "ORDER BY ProductId";
                using (SqlConnection con = GetConnection())
                {
                    //use "con" anywhere in this block
                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {

                        //any exception will be thrown to the place where this method was called
                        con.Open(); // open connection

                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // closes connection when done reading

                        while (dr.Read())// while there is data in data reader
                        {
                            Pro = new Products();
                            Pro.ProductId = Convert.ToInt32(dr["ProductId"]);
                            if (dr["ProdName"] != DBNull.Value)
                            { Pro.ProdName = Convert.ToString(dr["ProdName"]); }
                            else
                            {
                                Pro.ProdName = null;
                            }




                            products.Add(Pro);
                        }
                    }

                }
            }

            catch (Exception e)
            {
                throw e;
            }
            return products;





        }

        public static bool UpdateProduct(Products oldProducts, Products newProducts)
        {
            bool success = true;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Products set " +
                               "ProdName=@ProdName " +
                               "WHERE ProductId=@OldProductId ";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            if (newProducts.ProdName == null)
            { cmd.Parameters.AddWithValue("@ProdName", DBNull.Value); }
            else
            { cmd.Parameters.AddWithValue("@ProdName", newProducts.ProdName); }

            cmd.Parameters.AddWithValue("@OldProductID", oldProducts.ProductId);

            if (oldProducts.ProdName == null)
            { cmd.Parameters.AddWithValue("@OldProdName", DBNull.Value); }
            else
                cmd.Parameters.AddWithValue("@OldProdName", oldProducts.ProdName);

            try
            {
                con.Open();
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false; //did not update()

            }
            catch (Exception ex) { throw ex; }
            finally { con.Close(); }

            return success;


        }

        public static int AddProduct(Products prod)
        {
            int prodID = 0;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Products (ProdName) " +
                                     "VALUES(@ProdName)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@ProdName", prod.ProdName);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                string selectQuery = "SELECT IDENT_CURRENT('Products') FROM Products"; // identity value
                SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                prodID = Convert.ToInt32(selectCommand.ExecuteScalar()); // single value
                // typecasting (int) does not work
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return prodID;
        }




    }
}
