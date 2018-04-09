using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperatorExample
{
    class Combine
    {
       

        public void Linq()
        {
            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };

            int dotProduct = vectorA.Combine(vectorB, (a, b) => a * b).Sum();

            Console.WriteLine("Dot product: {0}", dotProduct);
        }
    }

    public static class CustomSequenceOperators
    {
        public static IEnumerable Combine(this IEnumerable first, IEnumerable second,
        Func func)
        {
            using (IEnumerator e1 = first.GetEnumerator(), e2 = second.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext())
                {
                    yield return func(e1.Current, e2.Current);
                }
            }
        }
    }
}
