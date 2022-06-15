using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace FirstProject
{
    class InsertData
    {
        SqlConnection con = null;
        public void InsertDataInToTable()
        {
            string connectionString = "Data Source = .; Initial Catalog = shop; Integrated Security = True; TrustServerCertificate = true";
            try
            {
                con = new SqlConnection(connectionString);
                // SqlCommand cmd = new SqlCommand("insert into customers((id,name,email) values('1','Siddharth','siddharth@gmail.com'),('2','Singh','Singh@gmail.com'));", con);

                SqlCommand cmd = new SqlCommand("insert into customers(id,[name],email)values('4','mohan','moh@gmail.com');", con);
                con.Open();
                cmd.ExecuteNonQuery();
                //Console.WriteLine("Connection stablish");
                Console.WriteLine("Data inserted sucessfully");

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
