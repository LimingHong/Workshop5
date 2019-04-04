using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TravelExpertsClassLib
{
    public class PackagesDB : TravelExpertsDB
    {

        //method for creating an empty list wich will display data
        public static List<Packages> GetPackages()
        {
            List<Packages> packages = new List<Packages>();
            try
            {
                Packages pkg; // for reading

                //PackageId
                //PkgName
                //PkgStartDate
                //PkgEndDate
                //PkgDesc
                //PkgBasePrice
                //PkgAgencyCommission
                string selectQuery = "SELECT PackageId,  PkgName, PkgStartDate, PkgEndDate, " +
                                     "        PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages " +
                                     "ORDER BY PackageId";



                using (SqlConnection con = GetConnection())
                {
                    //use "con" anywhere in this block
                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {

                        //any exception will be thrown to the place where this method was called
                        con.Open(); // open connection

                        SqlDataReader
                            dr = cmd.ExecuteReader(CommandBehavior
                                .CloseConnection); // closes connection when done reading

                        while (dr.Read()) // while there is data in data reader
                        {
                            pkg = new Packages();
                            pkg.PackageId = (int)dr["PackageId"];
                            pkg.PkgName = (string)dr["PkgName"];

                            pkg.PkgDesc = dr["PkgDesc"] as string;
                            pkg.PkgBasePrice = Convert.ToDecimal(dr["PkgBasePrice"]);
                            pkg.PkgAgencyCommission = Convert.ToDecimal(dr["PkgAgencyCommission"]);

                            //pkg.PkgStartDate = (DateTime)dr["PkgStartDate"];
                            //pkg.PkgEndDate = (DateTime)dr["PkgEndDate"];


                            // PkgStartDate with exception handling for null values
                            if (dr["PkgStartDate"] != DBNull.Value)
                            {
                                pkg.PkgStartDate = Convert.ToDateTime(dr["PkgStartDate"]);

                            }
                            else
                            {
                                pkg.PkgStartDate = null;
                            }

                            // PkgEndDate with exception handling for null values
                            if (dr["PkgEndDate"] != DBNull.Value)
                            {
                                pkg.PkgEndDate = Convert.ToDateTime(dr["PkgEndDate"]);

                            }
                            else
                            {
                                pkg.PkgEndDate = null;
                            }



                            packages.Add(pkg);


                        }
                    }

                }
            }

            catch (Exception e)
            {
                throw e;
            }

            return packages;
        }

        public static bool UpdatePackage(Packages inputPackages)
        {

            //PackageId
            //PkgName
            //PkgStartDate
            //PkgEndDate
            //PkgDesc
            //PkgBasePrice
            //PkgAgencyCommission

            Packages pkg; // for reading

            bool success = true;

            // block code style
            string UpdateStatement = " UPDATE Packages SET " +
                                     "PkgName = @PkgName, " +
                                     "PkgStartDate = @PkgStartDate, " +
                                     "PkgEndDate = @PkgEndDate, " +
                                     "PkgDesc = @PkgDesc, " +
                                     "PkgBasePrice = @PkgBasePrice, " +
                                     "PkgAgencyCommission = @PkgAgencyCommission " +
                                     "WHERE PackageId = @PackageId";


            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(UpdateStatement, con);


            cmd.Parameters.AddWithValue("@PkgName", inputPackages.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", inputPackages.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", inputPackages.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", inputPackages.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", inputPackages.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", inputPackages.PkgAgencyCommission);
            cmd.Parameters.AddWithValue("@PackageId", inputPackages.PackageId);

            try
            {
                // use cmd anywhere in this block
                // any exception will be thrown to the place where this method was called
                con.Open();
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false;

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }

            return success;
        }

        public static bool AddPackage(Packages inputPackages)
        {

            bool success = true;

            // block code style
            string InsertStatement = "INSERT INTO Packages" +
                                        "( PkgName," +
                                           "PkgStartDate," +
                                           "PkgEndDate," +
                                           "PkgDesc," +
                                           "PkgBasePrice," +
                                           "PkgAgencyCommission)" +
                                           "VALUES " +
                                        "( " +
                                            "@PkgName, " +
                                            "@PkgStartDate, " +
                                            "@PkgEndDate, " +
                                            "@PkgDesc, " +
                                            "@PkgBasePrice, " +
                                            "@PkgAgencyCommission " +

                                        ")";


            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(InsertStatement, con);


            cmd.Parameters.AddWithValue("@PkgName", inputPackages.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", inputPackages.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", inputPackages.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", inputPackages.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", inputPackages.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", inputPackages.PkgAgencyCommission);

            try
            {
                // use cmd anywhere in this block
                // any exception will be thrown to the place where this method was called
                con.Open();
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false;

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }

            return success;
        }


    }
}
