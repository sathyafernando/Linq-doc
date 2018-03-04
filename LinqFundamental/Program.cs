using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int smallNumber = numbers.Min();
            int smallestEvenNumber = numbers.Where(number => number % 2 == 0).Min();

            int largestNumber = numbers.Max();
            int largestEvenNumber = numbers.Where(number => number % 2 == 0).Min();

            int sumOfAllNumber = numbers.Sum();
            int sumOfAllEvenNumber = numbers.Where(number => number % 2 == 0).Min();

            int countOfAllNumber = numbers.Count();
            int countOfAllEvenNumber = numbers.Where(number => number % 2 == 0).Min();
        }
    }
}
