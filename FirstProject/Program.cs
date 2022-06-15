using System;
using System.Data.SqlClient;


namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TableCreation tb = new TableCreation();
            //tb.createTable();
            InsertData insertData = new InsertData();
             //insertData.InsertDataInToTable();
            UpdateTable ut = new UpdateTable();
            // ut.UpdateTableEntry();
            DisplayAllData dad = new DisplayAllData();
            //dad.getAllData();

            DeleteQuery dq = new DeleteQuery();
            //dq.DeleteTableEntry();




            
            





        }
   
    }
}
