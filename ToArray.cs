using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperatorExample
{
    class ToArray
    {

        public static void Main()
        {
            List<string> countries = new List<string> { "US", "India", "UK", "Australia", "Canada" };

            string[] result = (from country in countries
                               orderby country ascending
                               select country).ToArray();

            foreach (string str in result)
            {
                Console.WriteLine(str); //OutPut => US 
                                                   //India
                                                   //UK   
                                                   //Australia 
                                                   //Canada
            }
        }
    }
}
