using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FirstProject.Linq;
using System.Linq;



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
            EmployeeLinq employeeLinq = new EmployeeLinq();
            employeeLinq.practiceLinq();
            int[] numbers = new int[] { 1, 2, 3, 456, 78, 9, 5 };
            employeeLinq.oddNumber(numbers);

        }
        
   
    }
}
