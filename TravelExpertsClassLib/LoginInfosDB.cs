using System;
using System.Data;
using System.Data.SqlClient;

namespace TravelExpertsClassLib
{
    public class LoginInfosDB : TravelExpertsDB
    {

        /// <summary>
        /// Create LoginInfos table if not existed
        /// </summary>
        private static void GetExistenceLoginInfosTable()
        {
            // block code style
            string CheckTable =
                " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'AccLoginInfos' ) " +
                "BEGIN " +
                "CREATE TABLE AccLoginInfos( " +
                "ID int NOT NULL IDENTITY(1,1) PRIMARY KEY, " +
                "accUserName varchar(255) NOT NULL, " +
                "accPassWord varchar(255) NOT NULL, " +
                "AgentId int , " +
                "FOREIGN KEY(AgentId) REFERENCES Agents(AgentId) " +
                "); " +
                "END";


            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(CheckTable, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

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



        public static bool CreateAccount(Agents inputAgentInfo)
        {
            bool success = true;

            // block code style
            string InsertStatement = "DECLARE @newUserName varchar(255) " +
                                        "DECLARE @newPassword varchar(255) " +
                                        "DECLARE @GetAgentId int " +
                                        "SELECT @newPassword = (AgtFirstName + AgtLastName), @newUserName = AgtEmail, @GetAgentId = AgentId  " +
                                        "FROM AGENTS WHERE " +
                                        "AgtFirstName = @inputFirstName " +
                                        "AND AgtLastName = @inputLastname " +
                                        "AND AgtEmail = @inputEmail " +
                                        "INSERT INTO AccLoginInfos(accUserName, accPassWord, AgentId) VALUES(@newUserName, @newPassword, @GetAgentId)";

            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(InsertStatement, con);


            cmd.Parameters.AddWithValue("@inputFirstName", inputAgentInfo.AgtFirstName);
            cmd.Parameters.AddWithValue("@inputLastname", inputAgentInfo.AgtLastName);
            cmd.Parameters.AddWithValue("@inputEmail", inputAgentInfo.AgtEmail);

            try
            {
                // use cmd anywhere in this block
                // any exception will be thrown to the place where this method was called
                con.Open();
                GetExistenceLoginInfosTable();
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false;

            }
            catch (Exception e)
            {

                success = false;
            }
            finally
            {
                con.Close();
            }

            return success;
        }


        public static bool FindAgentExistingAcc(string accUserName, string accPassWord, out Agents SessionStoreAgentAcc)
        {
            bool success = true;

            SessionStoreAgentAcc = new Agents();

            try
            {
                // block code style
                string selectQuery = "DECLARE @GetAgentId int " +
                                        "SELECT @GetAgentId = AgentId " +
                                        "FROM AccLoginInfos ali " +
                                        "WHERE  ali.accUserName = @inputUserName " +
                                        "AND ali.accPassWord =  @inputPassword " +
                                        "SELECT * from Agents a WHERE a.AgentId = @GetAgentId";

                using (SqlConnection con = GetConnection())
                {
                    //use "con" anywhere in this block
                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {

                        //any exception will be thrown to the place where this method was called
                        con.Open(); // open connection
                        GetExistenceLoginInfosTable();
                        cmd.Parameters.AddWithValue("@inputUserName", accUserName);
                        cmd.Parameters.AddWithValue("@inputPassword", accPassWord);

                        SqlDataReader
                            dr = cmd.ExecuteReader(CommandBehavior
                                .CloseConnection); // closes connection when done reading

                        SessionStoreAgentAcc = new Agents();

                        if (!dr.Read())
                        {
                            success = false;
                        }
                        else
                        {
                            // while there is data in data reader

                            /*
                             * [AgentId]
                              ,[AgtFirstName]
                              ,[AgtMiddleInitial]
                              ,[AgtLastName]
                              ,[AgtBusPhone]
                              ,[AgtEmail]
                              ,[AgtPosition]
                              ,[AgencyId]
                             */

                            SessionStoreAgentAcc.AgentId = Convert.ToInt32(dr["AgentId"]);
                            SessionStoreAgentAcc.AgtFirstName = dr["AgtFirstName"] as string;
                            SessionStoreAgentAcc.AgtMiddleInitial = dr["AgtMiddleInitial"] as string;
                            SessionStoreAgentAcc.AgtLastName = dr["AgtLastName"] as string;
                            SessionStoreAgentAcc.AgtBusPhone = dr["AgtBusPhone"] as string;
                            SessionStoreAgentAcc.AgtEmail = dr["AgtEmail"] as string;
                            SessionStoreAgentAcc.AgtPosition = dr["AgtPosition"] as string;
                            SessionStoreAgentAcc.AgencyId = Convert.ToInt32(dr["AgencyId"]);

                        }


                    }

                }

            }
            catch (Exception e)
            {
                throw e;
                success = false;
            }

            return success;
        }
    }
}
