using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFundamental
{
    class FirstOrDefault
    {
        public class ElementOperatorFirst
        {
            static void Main(string[] args)
            {
                int[] number1 = { };
                int result1 = number1.FirstOrDefault();
                Console.WriteLine("Result", result1); //OutPut => 0

                int[] number2 = { 1, 2, 3, 4, 5, 6 };
                int result2 = number2.FirstOrDefault();
                Console.WriteLine("Result", result2); //Out Put => 1

                int[] number3 = { 1, 2, 3, 4, 5, 6 };
                int result3 = number3.FirstOrDefault(x =>x%2==0);
                Console.WriteLine("Result", result3); //Out Put => 2

                int[] number4 = { 1, 2, 3, 4, 5, 6 };
                int result4 = number4.FirstOrDefault(x => x % 2 == 100);
                Console.WriteLine("Result", result4); //Out Put => 0
            }
        }
    }
}
}
