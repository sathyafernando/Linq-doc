using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperatorExample
{
    public class ConcatesOperator
    {
        static void Main(string[] args)
        {
            int[] number1 = { 1, 2, 3 };
            int[] number2 = { 4, 5, 6 };

            var result = number1.Concat(number2); // output => 1,2,3,4,5,6
        }
    }
   
}
