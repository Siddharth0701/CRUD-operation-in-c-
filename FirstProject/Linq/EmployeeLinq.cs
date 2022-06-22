using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FirstProject.Linq
{
    class EmployeeLinq
    {
        public void practiceLinq() 
        {
        string[] names = new string[] { "Siddharth", "Singh", "Vishal", "Harsh" };
        var query = from name in names orderby name ascending select name;
        foreach (var item in query)
	           {

                Console.WriteLine(item);
      	       }
        }
        public void oddNumber(int[] num)
        {

            Console.WriteLine("oddnumber is ");
            IEnumerable<int> oddnumber = from number in num where number % 2 != 0 select number;
            Console.WriteLine(oddnumber);
            foreach (var item in oddnumber)
            {
                Console.WriteLine(item);
            }

        }


    }
}
