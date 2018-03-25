using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperatorExample
{
    public class Quantifier
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            bool result = numbers.Any(); // output=> returns the true as the sequence contains the one 

            bool result1 = numbers.Any(x=>x>5); // returs the false that sequence not contain any element that satisfies given condition

        }
    }
}
