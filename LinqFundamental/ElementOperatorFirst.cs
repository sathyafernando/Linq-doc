using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFundamental
{
    public class ElementOperatorFirst
    {
        static void Main(string[] args)
        {
            int[] number1 = { };
            int result1 = number1.First();
            Console.WriteLine("Result", result1); //***Throw InvalidOperationException

            int[] number = { 1, 2, 3, 4, 5, 6 };
            int result = number.First();
            Console.WriteLine("Result", result); //Out Put => 1
        }
    }
}
