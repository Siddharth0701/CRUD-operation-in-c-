using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FirstProject
{
	class DisplayAllData
	{

        SqlConnection con = null;
        public void getAllData()
        {
            string connectionString = "Data Source = .; Initial Catalog = shop; Integrated Security = True; TrustServerCertificate = true";
            try
            {
                con = new SqlConnection(connectionString);
               

                 SqlCommand cmd = new SqlCommand("select * from customers", con);
                con.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                //foreach(var data in sqlDataReader)
                //{
                //    Console.WriteLine(data);
                //}
                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["id"]+"-"+sqlDataReader["name"]+"-"+sqlDataReader["email"]);
                }
              
                Console.WriteLine("Fetch All the values sucessfully");

            }
            catch (Exception e)
            {
                Console.WriteLine("error message" + e);
            }


            finally
            {
                con.Close();
            }
        }





    }
}


