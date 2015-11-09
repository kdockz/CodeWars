using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Numbers.IsSquare(9));
            //Console.WriteLine(Series.SeriesNthSum(5));

            //Console.WriteLine(Numbers.CountOddFibonacci(121, 5));
            //Console.WriteLine(Numbers.CountOddFibonacci(121, 5));
            //Console.WriteLine(Numbers.CountOddPentaFibonacci(68));

            Console.WriteLine(Series.PowerOfSumToN(10, 1, 2) - Series.SumOfPowerToN(10,2));
            //Console.WriteLine(Numbers.SumOfMultiples(9, 3));
            //Console.WriteLine(Numbers.SumOfMultiples(10, 3));

            //Console.WriteLine(Numbers.SumOfMultiples(1000, 3) + Numbers.SumOfMultiples(1000, 5) - Numbers.SumOfMultiples(1000, 3 * 5));
            //Console.WriteLine(Numbers.SumEvenFibonacci(10, 2));
            //Console.WriteLine(string.Join(" ", Numbers.FibonacciUpToNth(10, 2).ToArray()));
            //Console.WriteLine(string.Join(" ", Numbers.SumEvenFibonacci(4000000, 2)));
            //Console.WriteLine(string.Join(" ", Numbers.FibonacciByValue(4000000, 2).ToArray()));
            Stopwatch sw = new Stopwatch();

            sw.Start();

            //var pairs = Numbers.FactorPairs(30);
            //var palindromes = Numbers.PalindromesOfSize(5);

            //foreach (var palindrome in palindromes)
            //{
            //Console.WriteLine(palindrome);
            //Numbers.FactorPairs(palindrome).ForEach(delegate (long[] pair) { Console.WriteLine(string.Join(" ", pair)); });
            //}

            //Console.WriteLine(Numbers.LargestPalindromeWithEqualSizePairs(6));
            //Console.WriteLine(string.Join(" ", Numbers.SmallestMultiple(30)));
            //Console.WriteLine(string.Join(" ", Numbers.Factors(2329089562800)));
            //Console.WriteLine(string.Join(" ", Numbers.Factors(20961806065200)));
            //Console.WriteLine(string.Join(" ", Numbers.Factors(105)));
            //Console.WriteLine(string.Join(" ", Numbers.Factors(9419588158802421600)));
            for (int i = 1; i <= 46; i++)
            {
                //Console.WriteLine("{0}: {1}", i, string.Join(" ", Numbers.SmallestMultiple(i)));
            }
            sw.Stop();

            Console.WriteLine("Total time: {0}", sw.Elapsed);
            //Numbers.FactorPairs(1001).ForEach(delegate(long[] pair) { Console.WriteLine(string.Join(" ", pair)); });
            //Console.WriteLine(string.Join(" ", Numbers.PrimeFactors(30).ToArray()));;
            //Numbers.PrimeFactors(4000478);
            //Numbers.PrimeFactors(600851475143);
        }
    }
}
