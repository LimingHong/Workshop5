using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
    /// <summary>
    /// this class will connect to the database and through the query on its methods displays the customer's purchases history 
    /// and the total of them
    /// </summary>
    /// 

        //method for getting customer's purchases history
    public class CustomerHistoryDB:TravelExpertsDB
    {
        public static List<CustomerHistory> PurchaseList()
        {
            string prchtHistory = "select  c.CustFirstName, d.Description, d.destination, d.baseprice" +
                        "from Customers c INNER JOIN Bookings b ON(c.CustomerId = b.CustomerId) INNER JOIN BookingDetails d ON(b.BookingId = d.BookingId)" +
                        "where c.CustomerId = 128" + /*change this condition for a variable like @username but has to be set prior or a session*/
                        "group by  c.CustFirstName, d.Description, d.destination, d.baseprice";
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(prchtHistory, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return PurchaseList();

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }
        }

       
    }



    //method for getting total of the customer's purchases 
    

}
