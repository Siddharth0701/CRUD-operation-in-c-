using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace FirstProject
{
    class DeleteQuery
    {


        SqlConnection con = null;
        public void DeleteTableEntry()
        {
            string connectionString = "Data Source = .; Initial Catalog = shop; Integrated Security = True; TrustServerCertificate = true";
            try
            {

              
                Console.WriteLine("Enter the id");
                int i = int.Parse(Console.ReadLine());
                con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand($"delete from customers where id={i}", con);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Connection stablish");
                Console.WriteLine("Table data deleted sucessfully");

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
