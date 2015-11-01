using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Numbers.IsSquare(9));
            //Console.WriteLine(Series.SeriesNthSum(5));

            //Numbers.CountOddPentaFib(0);
            //Numbers p = new Numbers();
            //p.CountOddPentaFib(5);

            //Numbers p2 = new Numbers();
            //p2.CountOddPentaFib(10);
            Console.WriteLine(string.Join(" ", Numbers.Fibonacci(15).ToArray()));

                /*foreach(var i in Numbers.Range(10))
                {
                    Console.WriteLine(i);
                }*/

                var iter = Numbers.Range(10);

            while(iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }

        }
    }
}
