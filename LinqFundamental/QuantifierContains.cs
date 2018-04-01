using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperatorExample
{
    public class QuantifierContains
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            bool result = numbers.Contains(3); // output=> true
            
            string[] countries = {"USA" , "iNDIA" , "UK" };

            bool result1 = countries.Contains("india"); // false

            bool result2 = countries.Contains("india" , StringComparer.OrdinalIgnoreCase); // true

        }

    }
}
