
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOperatorExample
{
    class Tolist
    {


        //  Example 1: Convert int array to List<int>

        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            List<int> result = numbers.ToList();

            foreach (int i in result)
            {
                Console.WriteLine(i);  // OutPut => 1 2 3 4 5 
            }



            //Example 2: Convert List<string> to string array. The items in the array should be sorted in ascending order.


            List<string> countries = new List<string> { "US", "India", "UK", "Australia", "Canada" };

            string[] result1 = (from country in countries
                                orderby country ascending
                                select country).ToArray();

            foreach (string str in result1)
            {
                Console.WriteLine(str); //  OutPut => US India UK Australia Canada
            }
        }


    }
}
