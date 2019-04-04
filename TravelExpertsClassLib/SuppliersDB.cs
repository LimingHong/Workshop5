using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace TravelExpertsClassLib
{
    public class SuppliersDB : TravelExpertsDB
    {

        //Method for creation of the list which will display data
        public static List<Suppliers> GetSuppliers()
        {
            List<Suppliers> newSuppliers = new List<Suppliers>(); // empty list object
            try
            {
                Suppliers currentSupllier; // for reading

                string selectJoinQuery = "SELECT * FROM Suppliers";

                // block code style
                using (SqlConnection con = GetConnection())
                {
                    // use con anywhere in this block
                    using (SqlCommand cmd = new SqlCommand(selectJoinQuery, con))
                    {
                        // use cmd anywhere in this block
                        // any exception will be thrown to the place wher this method was called
                        con.Open();

                        // this will auto close connection when done
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dr.Read())  // while there is still data in the datareader
                        {
                            currentSupllier = new Suppliers();
                            //SupplierId SupName
                            currentSupllier.SupplierId = Convert.ToInt64(dr["SupplierId"]);
                            currentSupllier.SupName = dr["SupName"] as string;


                            newSuppliers.Add(currentSupllier);
                        }
                    }
                } //  the object gets recycled


            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error. Failed to retrieve Suppliers information");
            }

            return newSuppliers;
        }
        public static bool UpdateSupplier(Suppliers oldSuppliers, Suppliers newSuppliers)
        {
            bool success = true;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Suppliers set " +
                               "SupName=@SupName " +
                               "WHERE SupplierId=@OldSupplierId ";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            if (newSuppliers.SupName == null)
            { cmd.Parameters.AddWithValue("@SupName", DBNull.Value); }
            else
            { cmd.Parameters.AddWithValue("@SupName", newSuppliers.SupName); }

            cmd.Parameters.AddWithValue("@OldSupplierID", oldSuppliers.SupName);

            if (oldSuppliers.SupName == null)
            { cmd.Parameters.AddWithValue("@OldSupName", DBNull.Value); }
            else
                cmd.Parameters.AddWithValue("@OldSupName", oldSuppliers.SupName);

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

        public static bool AddSupplier(Suppliers Sup)
        {
            bool success = true;

            SqlConnection con = TravelExpertsDB.GetConnection();

            string insertStatement = "INSERT INTO Suppliers(SupplierId, SupName) " +
                                     "VALUES (@MaxSupId , @SupName)";

            SqlCommand cmd = new SqlCommand(insertStatement, con);

            cmd.Parameters.AddWithValue("@SupName", Sup.SupName);
            cmd.Parameters.AddWithValue("@MaxSupId", Sup.SupplierId);


            try
            {
                con.Open();
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return success;
        }

        public static bool UpdateSupplier(Suppliers newSupplier)
        {
            bool success = true;

            SqlConnection con = TravelExpertsDB.GetConnection();

            string insertStatement = "UPDATE Suppliers SET SupName = @SupName " +
                                     "WHERE SupplierId = @SupplierId ";

            SqlCommand cmd = new SqlCommand(insertStatement, con);

            cmd.Parameters.AddWithValue("@SupName", newSupplier.SupName);
            cmd.Parameters.AddWithValue("@SupplierId", newSupplier.SupplierId);


            try
            {
                con.Open();
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return success;
        }
    }
}
