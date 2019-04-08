using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TravelExpertsClassLib
{
    public class CustomersDB : TravelExpertsDB
    {
        public static List<Customers> GetCustomerId(string a, string b)
        {
            List<Customers> customers = new List<Customers>();
            try
            {
                Customers cust; // for reading


                string selectQuery = "SELECT CustomerId FROM Customers WHERE CustFirstName='{a}' AND CustLastName='{b}'";



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
                            cust = new Customers();
                            cust.CustomerId = (int)dr["CustomerId"];







                            customers.Add(cust);


                        }
                    }

                }
            }

            catch (Exception e)
            {
                throw e;
            }

            return customers;
        }


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
            cmd.Parameters.AddWithValue("@CustProv", input.CustProv);
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


        public static bool AddCustomer(Customers input)
        {

            bool success = true;

            // block code style
            string InsertStatement = "INSERT INTO Customers" +
                                        "( CustFirstName," +
                                           "CustLastName," +
                                           "CustAddress," +
                                           "CustCity," +
                                           "CustProv," +
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
                                            "@CustProv, " +
                                            "@CustPostal, " +
                                            //"@CustCountry " +
                                            "@CustHomePhone, " +
                                            "@CustBusPhone, " +
                                            "@CustEmail, " +
                                            "@AgentId, " +
                                            "@username, " +
                                            "@userPass " +

                                       ")";


            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(InsertStatement, con);


            cmd.Parameters.AddWithValue("@CustFirstName", input.CustFirstName);
            cmd.Parameters.AddWithValue("@CustLastName", input.CustLastName);
            cmd.Parameters.AddWithValue("@CustAddress", input.CustAddress);
            cmd.Parameters.AddWithValue("@CustCity", input.CustCity);
            cmd.Parameters.AddWithValue("@CustProv", input.CustProv);
            cmd.Parameters.AddWithValue("@CustPostal", input.CustPostal);
            //cmd.Parameters.AddWithValue("@CustCountry", input.CustCountry);
            cmd.Parameters.AddWithValue("@CustHomePhone", input.CustHomePhone);
            cmd.Parameters.AddWithValue("@CustBusPhone", input.CustBusPhone);
            cmd.Parameters.AddWithValue("@CustEmail", input.CustEmail);

            if (input.AgentId == null)
                cmd.Parameters.AddWithValue("@AgentId", DBNull.Value);
            else
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

