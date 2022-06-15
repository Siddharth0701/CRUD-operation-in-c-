using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace FirstProject
{
    class UpdateTable
    {


        SqlConnection con = null;
        public void UpdateTableEntry()
        {
            string connectionString = "Data Source = .; Initial Catalog = shop; Integrated Security = True; TrustServerCertificate = true";
            try
            {
               
                Console.WriteLine("Enter the name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the id");
                int i = int.Parse(Console.ReadLine());
                 con = new SqlConnection(connectionString);
               SqlCommand cmd = new SqlCommand($"Update customers set [name]='{name}' where id={i}", con);
               
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Connection stablish");
                Console.WriteLine("Table updated sucessfully");

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
