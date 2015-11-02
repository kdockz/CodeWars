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
            //Console.WriteLine(string.Join(" ", Numbers.Fibonacci(15).ToArray()));
            //Console.WriteLine(string.Join(" ", Numbers.Fibonacci(15, 5).ToArray()));
            //Console.WriteLine(string.Join(" ", Numbers.Fibonacci(-20, 5).ToArray()));
            //Console.WriteLine(string.Join(" ", Numbers.Fibonacci(0, 5).ToArray()));
            //Console.WriteLine(string.Join(" ", Numbers.Fibonacci(1, 5).ToArray()));
            //Console.WriteLine(string.Join(" ", Numbers.Fibonacci(2, 5).ToArray()));
            //Console.WriteLine(string.Join(" ", Numbers.Fibonacci(3, 5).ToArray()));
            //Console.WriteLine(string.Join(" ", Numbers.Fibonacci(15, 2).ToArray()));
            //Console.WriteLine(string.Join(" ", Numbers.Fibonacci(10, 5).ToArray()));
            //Console.WriteLine(string.Join(" ", Numbers.Fibonacci(56, 10).ToArray()));
            /*foreach(var i in Numbers.Range(10))
            {
                Console.WriteLine(i);
            }*/

            /*var iter = Numbers.Range(10);

            while(iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }*/

            //Console.WriteLine(Numbers.CountOddFibonacci(121, 5));
            //Console.WriteLine(Numbers.CountOddPentaFibonacci(68));

            Console.WriteLine(Numbers.SumOfMultiples(10, 1));
            Console.WriteLine(Numbers.SumOfMultiples(9, 3));
            Console.WriteLine(Numbers.SumOfMultiples(10, 3));

            Console.WriteLine(Numbers.SumOfMultiples(10, 3) + Numbers.SumOfMultiples(10, 5) - Numbers.SumOfMultiples(10, 3 * 5));

        }
    }
}
