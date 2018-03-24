using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFundamental
{
    public class DefaultIfEmpty
    {

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            IEnumerable<int> result = numbers.DefaultIfEmpty();
            foreach(int i in result)
            {
                Console.WriteLine(i);  //OutPut => 1,2,3
            }

            int[] numbers1 = { };
            IEnumerable<int> result1 = numbers1.DefaultIfEmpty();
            foreach (int i in result1)
            {
                Console.WriteLine(i);  //OutPut => 0
            }

            int[] numbers2 = { };
            IEnumerable<int> result2 = numbers2.DefaultIfEmpty(100); // set default value when no element
            foreach (int i in result2)
            {
                Console.WriteLine(i);  //OutPut => 100
            }
        }
    }
}
