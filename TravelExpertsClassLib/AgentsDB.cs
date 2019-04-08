using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace TravelExpertsClassLib
{
    public class AgentsDB : TravelExpertsDB
    {
        protected static string FullNameCap(string fname, string lname)
        {
            if (String.IsNullOrEmpty(fname) || String.IsNullOrEmpty(lname))
                throw new ArgumentException("Invalid Input, result failed ! Please use nonempty string");
            return fname.First().ToString().ToUpper() + fname.Substring(1) + " " + lname.First().ToString().ToUpper() + lname.Substring(1);

        }

        public static List<Agents> GetAllAgents()
        {
            List<Agents> Agents = new List<Agents>();

            try
            {
                Agents agent; // for reading


                string selectQuery = "SELECT * FROM Agents";



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
                            agent = new Agents();
                            agent.AgentId = Convert.ToInt32(dr["AgentId"]);
                            agent.AgtFirstName = dr["AgtFirstName"] as string;
                            agent.AgtMiddleInitial = dr["AgtMiddleInitial"] as string;
                            agent.AgtLastName = dr["AgtLastName"] as string;
                            agent.AgtFullName = FullNameCap(agent.AgtFirstName, agent.AgtLastName);
                            agent.AgtBusPhone = dr["AgtBusPhone"] as string;
                            agent.AgtEmail = dr["AgtEmail"] as string;
                            agent.AgtPosition = dr["AgtPosition"] as string;
                            agent.AgencyId = Convert.ToInt32(dr["AgencyId"]);

                            Agents.Add(agent);
                        }
                    }

                }
            }

            catch (Exception e)
            {
                throw e;
            }

            return Agents;
        }
    }
}
