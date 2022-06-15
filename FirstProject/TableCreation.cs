using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FirstProject
{
    class TableCreation
    {


        #region add
        //Console.WriteLine("Hello Siddharth !");

        ////Console.WriteLine("Enter First number number");
        ////int a = int.Parse(Console.ReadLine());
        ////Console.WriteLine("Enter a second number");
        ////int b = int.Parse(Console.ReadLine());
        ////int c = a + b;
        ////Console.WriteLine("Addition of  "+c);
        ///
        #endregion
        SqlConnection con = null;
        public void createTable()
        {
            string connectionString = "Data Source = .; Initial Catalog = shop; Integrated Security = True; TrustServerCertificate = true";
            try
            {
                con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("create table customers(id int not null, name varchar(50), email varchar(50));", con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Connection stablish");
                Console.WriteLine("Table create sucessfully");

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
