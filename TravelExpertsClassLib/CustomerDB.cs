using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TravelExpertsClassLib
{
    public class CustomerDB : TravelExpertsDB
    {
        public static Customer GetCustomer(int customerId)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement
                    = "SELECT CustomerId, CustFirstName, CustLastName, CustAddress, CustCity, CustProv, CustPostal, "
                    + "CustCountry, CustHomePhone, CustBusPhone, CustEmail, AgentId, UserName, Password "
                    + "FROM Customers "
                    + "WHERE CustomerId = @CustomerId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@CustomerId", customerId);

            try
            {
                connection.Open();
                SqlDataReader custReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (custReader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerId = (int)custReader["CustomerId"];
                    customer.CustFirstName = custReader["CustFirstName"].ToString();
                    customer.CustLastName = custReader["CustLastName"].ToString();
                    customer.CustAddress = custReader["CustAddress"].ToString();
                    customer.CustCity = custReader["CustCity"].ToString();
                    customer.CustProv = custReader["CustProv"].ToString();
                    customer.CustPostal = custReader["CustPostal"].ToString();
                    customer.CustCountry = custReader["CustCountry"].ToString();
                    customer.CustHomePhone = custReader["CustHomePhone"].ToString();
                    customer.CustBusPhone = custReader["CustBusPhone"].ToString();
                    customer.CustEmail = custReader["CustEmail"].ToString();
                    customer.AgentId = 0;
                    customer.UserName = custReader["UserName"].ToString();
                    customer.Password = custReader["Password"].ToString();

                    return customer;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Customer> GetCustomerIds()
        {
            List<Customer> CustomerIds = new List<Customer>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT CustomerId "
                                   + "FROM Customers ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer();

                    customer.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    CustomerIds.Add(customer);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return CustomerIds;
        }

        public static int GetUser(string UserName, string Password)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement
                = "SELECT CustomerId FROM Customers "
                + "WHERE UserName = @UserName AND Password = @Password";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@UserName", UserName);
            selectCommand.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader custReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (custReader.Read())
                {
                    Customer customer = new Customer();
                    int CustomerId = (int)custReader["CustomerId"];

                    return CustomerId;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }


        public static bool UpdateCustomer(Customer customer)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement =
                "UPDATE Customers SET " +
                "CustFirstName = @CustFirstName, " +
                "CustLastName = @CustLastName, " +
                "CustAddress = @CustAddress, " +
                "CustCity = @CustCity, " +
                "CustProv = @CustProv, " +
                "CustPostal = @CustPostal, " +
                "CustCountry = @CustCountry, " +
                "CustHomePhone = @CustHomePhone, " +
                "CustBusPhone = @CustBusPhone " +
                "WHERE UserName = @UserName";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@CustFirstName", customer.CustFirstName);
            updateCommand.Parameters.AddWithValue(
                "@CustLastName", customer.CustLastName);
            updateCommand.Parameters.AddWithValue(
                "@CustAddress", customer.CustAddress);
            updateCommand.Parameters.AddWithValue(
                "@CustCity", customer.CustCity);
            updateCommand.Parameters.AddWithValue(
                "@CustProv", customer.CustProv);
            updateCommand.Parameters.AddWithValue(
                "@CustPostal", customer.CustPostal);
            updateCommand.Parameters.AddWithValue(
                "@CustCountry", customer.CustCountry);
            updateCommand.Parameters.AddWithValue(
                "@CustHomePhone", customer.CustHomePhone);
            updateCommand.Parameters.AddWithValue(
                "@CustBusPhone", customer.CustBusPhone);
            updateCommand.Parameters.AddWithValue(
                "@UserName", customer.UserName);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int InsertCustomer(Customer customer)
        {
            int flag = 0;
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement
                    = "INSERT INTO Customers (CustFirstName, CustLastName, CustAddress, CustCity, CustProv, CustPostal, "
                    + "CustCountry, CustHomePhone, CustBusPhone, CustEmail, AgentId, UserName, Password) "
                    + "VALUES (@CustFirstName, @CustLastName, @CustAddress, @CustCity, @CustProv, @CustPostal, "
                    + "@CustCountry, @CustHomePhone, @CustBusPhone, @CustEmail, @AgentId, @UserName, @Password)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@CustFirstName", customer.CustFirstName);
            insertCommand.Parameters.AddWithValue("@CustLastName", customer.CustLastName);
            insertCommand.Parameters.AddWithValue("@CustAddress", customer.CustAddress);
            insertCommand.Parameters.AddWithValue("@CustCity", customer.CustCity);
            insertCommand.Parameters.AddWithValue("@CustProv", customer.CustProv);
            insertCommand.Parameters.AddWithValue("@CustPostal", customer.CustPostal);
            insertCommand.Parameters.AddWithValue("@CustCountry", customer.CustCountry);
            insertCommand.Parameters.AddWithValue("@CustHomePhone", customer.CustHomePhone);
            insertCommand.Parameters.AddWithValue("@CustBusPhone", customer.CustBusPhone);
            insertCommand.Parameters.AddWithValue("@CustEmail", customer.CustEmail);
            insertCommand.Parameters.AddWithValue("@AgentId", DBNull.Value);
            insertCommand.Parameters.AddWithValue("@UserName", customer.UserName);
            insertCommand.Parameters.AddWithValue("@Password", customer.Password);

            List<string> unames = new List<string>();
            unames = CustomerDB.CheckUserName();
            for (int i = 0; i < unames.Count; i++)
            {
                if (customer.UserName == unames[i])
                {

                    return flag;

                }
            }
            try
            {
                connection.Open();
                flag = insertCommand.ExecuteNonQuery();
            }


            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {
                connection.Close();
            }
            return flag;
        }

        public static List<String> CheckUserName()
        {
            List<String> userNames = new List<String>();
            SqlConnection connection = TravelExpertsDB.GetConnection();

            string selectStatement = "SELECT UserName "
                                   + "FROM Customers ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer();

                    customer.UserName = reader["UserName"].ToString();
                    userNames.Add(customer.UserName);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return userNames;
        }
    }
}
