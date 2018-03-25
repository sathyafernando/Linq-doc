using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperatorExample
{
    public class ElementAtOperator
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1,2,3,4,5 };
            int result1 = numbers1.ElementAt(1);
            Console.WriteLine(result1); //OutPut => 2

            int[] numbers = { };
            int result = numbers.Single();
            Console.WriteLine(result); //OutPut => Error

            int[] numbers2 = { 1, 2};
            int result2 = numbers2.ElementAt(2);
            Console.WriteLine(result2); //OutPut => IndexOutOfBoundException

        }
    }
}