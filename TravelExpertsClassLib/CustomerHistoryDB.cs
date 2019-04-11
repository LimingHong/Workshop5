using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TravelExpertsClassLib
{
    /// <summary>
    /// this class will connect to the database and through the query on its methods displays the customer's purchases history 
    /// and the total of them
    /// </summary>
    /// 

    //method for getting customer's purchases history
    public class CustomerHistoryDB : TravelExpertsDB
    {
        public static List<CustomerHistory> PurchaseList(int ID)
        {
            List<CustomerHistory> list = new List<CustomerHistory>();
            CustomerHistory hist;

            string prchtHistory = "select c.CustomerId, c.CustFirstName, d.Description, d.destination, d.baseprice " +
                        "from Customers c INNER JOIN Bookings b ON(c.CustomerId = b.CustomerId) INNER JOIN BookingDetails d ON(b.BookingId = d.BookingId) " +
                        "where c.CustomerId = " + ID +/*change this condition for a variable like @username but has to be set prior or a session*/
                        "group by c.CustomerId, c.CustFirstName, d.Description, d.destination, d.baseprice";


            //SqlConnection con = GetConnection();
            //SqlCommand cmd = new SqlCommand(prchtHistory, con);

            using (SqlConnection con = GetConnection())
            {
                //use "con" anywhere in this block
                using (SqlCommand cmd = new SqlCommand(prchtHistory, con))
                {

                    //any exception will be thrown to the place where this method was called
                    con.Open(); // open connection

                    SqlDataReader
                        dr = cmd.ExecuteReader(CommandBehavior
                            .CloseConnection); // closes connection when done reading

                    while (dr.Read()) // while there is data in data reader
                    {
                        hist = new CustomerHistory();
                        hist.CustomerId = (int)dr["CustomerId"];
                        hist.CustFirstName = (string)dr["CustFirstName"];
                        hist.BasePrice = Convert.ToInt32(dr["BasePrice"]);
                        hist.Destination = (string)dr["Destination"];
                        hist.Description = (string)dr["Description"];

                        list.Add(hist);


                    }
                }
            }

            return list;
        }

        //    try
        //    {
        //        con.Open();
        //        SqlDataReader read = cmd.ExecuteNonQuery();

        //        //return PurchaseList();

        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //    return PurchaseList();
        //}




        //method for total


        //method for getting total of the customer's purchases 
        public static decimal totHist(int ID)
        {
            decimal total = 0;

            string totPrch = "select sum(d.BasePrice)" +
              "from Customers c INNER JOIN Bookings b ON(c.CustomerId = b.CustomerId) INNER JOIN BookingDetails d ON(b.BookingId = d.BookingId)" +
              "where c.CustomerId =" + ID;
            using (SqlConnection con = GetConnection())
            {
                //use "con" anywhere in this block
                using (SqlCommand cmd = new SqlCommand(totPrch, con))
                {

                    //any exception will be thrown to the place where this method was called
                    con.Open(); // open connection
                    var outPut = cmd.ExecuteScalar();

                    if (outPut != DBNull.Value)
                    {
                        total = Convert.ToDecimal(outPut);

                    }
                    else
                    {
                        total = 0;
                    }

                }
            }
            return total;
        }



    }
}
