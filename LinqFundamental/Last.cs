using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFundamental
{
    public class Last
    {
        static void Main(string[] args)
        {
            int[] number1 = { };
            int result1 = number1.Last();
            Console.WriteLine("Result", result1); //***Throw InvalidOperationException

            int[] number = { 1, 2, 3, 4, 5, 6 };
            int result = number.Last();
            Console.WriteLine("Result", result); //Out Put => 6

            int[] number2 = { 1, 2, 3, 4, 5, 6 };
            int result2 = number2.Last(x =>x%2==0);
            Console.WriteLine("Result", result2); //Out Put => 6

            int[] number3 = { 1, 2, 3, 4, 5, 6 };
            int result3 = number3.Last(x => x % 2 == 100);
            Console.WriteLine("Result", result3); //Out Put => 0
        }
    }
}
