using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperatorExample
{
   public class SingleOperator
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1};
            int result1 = numbers1.Single();
            Console.WriteLine(result1); //OutPut => 1

            int[] numbers = {  };
            int result = numbers.Single(); 
            Console.WriteLine(result); //OutPut => Error

            int[] numbers2 = { 1, 2, 3 };
            int result2 = numbers2.Single(x=>x%2==0);
            Console.WriteLine(result2); //OutPut => 2

            int[] numbers3 = { 1, 2, 3 , 4};
            int result3 = numbers3.Single(x => x % 2 == 0);
            Console.WriteLine(result3); //OutPut => Error

        }
    }
}
