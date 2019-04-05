using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
    class CustomersDB
    {
        public static bool UpdateCustomer(Customers input)
        {

            

            Customers customer; // for reading

            bool success = true;

            // block code style
            string UpdateStatement = " UPDATE Customers SET " +
                                     "CustFirstName = @CustFirstName, " +
                                     "CustLastName = @CustLastName, " +
                                     "CustAddress = @CustAddress, " +
                                     "CustCity = @CustCity, " +
                                     "CustProv = @CustProv, " +
                                     "CustPostal = @CustPostal " +
                                     //"CustCountry =@CustCountry" +
                                     "CustHomePhone = @CustHomePhone" +
                                     "CustBusPhone =@CustBusPhone" +
                                     "CustEmail =@CustEmail" +
                                     "AgentId =@AgentId" +
                                     "WHERE CustomerId = @CustomerId";


            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(UpdateStatement, con);


            cmd.Parameters.AddWithValue("@CustFirstName", input.CustFirstName);
            cmd.Parameters.AddWithValue("@CustLastName", input.CustLastName);
            cmd.Parameters.AddWithValue("@CustAddress", input.CustAddress);
            cmd.Parameters.AddWithValue("@CustCity", input.CustCity);
            cmd.Parameters.AddWithValue("@CustPostal", input.CustPostal);
            //cmd.Parameters.AddWithValue("@CustCountry", input.CustCountry);
            cmd.Parameters.AddWithValue("@CustHomePhone", input.CustHomePhone);
            cmd.Parameters.AddWithValue("@CustBusPhone", input.CustBusPhone);
            cmd.Parameters.AddWithValue("@CustEmail", input.CustEmail);

            cmd.Parameters.AddWithValue("@AgentId", input.AgentId);

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

        private static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True";

            // ERIC version
            //string connectionString = @"Data Source=localhost;Initial Catalog=TravelExperts;Integrated Security=True";


            return new SqlConnection(connectionString);
        }

        public static bool AddCustomer(Customers input)
        {

            bool success = true;

            // block code style
            string InsertStatement = "INSERT INTO Customers" +
                                        "( CustFirstName," +
                                           "CustLastName," +
                                           "CustAddress," +
                                           "CustCity," +
                                           "CustPostal," +
                                           //"CustCountry,"+
                                           "CustHomePhone," +
                                           "CustBusPhone," +
                                           "CustEmail," +
                                           "AgentId," +
                                           "username," +
                                           "userPass)" +
                                           "VALUES " +
                                        "( " +
                                            "@CustFirstName, " +
                                            "@CustLastName, " +
                                            "@CustAddress, " +
                                            "@CustCity, " +
                                            "@CustPostal, " +
                                            //"@CustCountry " +
                                            "@CustHomePhone " +
                                            "@CustBusPhone " +
                                            "@CustEmail " +
                                            "@AgentId " +
                                            "@username " +
                                            "@userPass " +

                                       ")";


            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(InsertStatement, con);


            cmd.Parameters.AddWithValue("@CustFirstName", input.CustFirstName);
            cmd.Parameters.AddWithValue("@CustLastName", input.CustLastName);
            cmd.Parameters.AddWithValue("@CustAddress", input.CustAddress);
            cmd.Parameters.AddWithValue("@CustCity", input.CustCity);
            cmd.Parameters.AddWithValue("@CustPostal", input.CustPostal);
            //cmd.Parameters.AddWithValue("@CustCountry", input.CustCountry);
            cmd.Parameters.AddWithValue("@CustHomePhone", input.CustHomePhone);
            cmd.Parameters.AddWithValue("@CustBusPhone", input.CustBusPhone);
            cmd.Parameters.AddWithValue("@CustEmail", input.CustEmail);
            cmd.Parameters.AddWithValue("@AgentId", input.AgentId);
            cmd.Parameters.AddWithValue("@username", input.username);
            cmd.Parameters.AddWithValue("@userPass", input.userPass);

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

