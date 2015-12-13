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

            //Console.WriteLine(Series.PowerOfSumToN(10, 1, 2) - Series.SumOfPowerToN(10,2));
            //Console.WriteLine(Numbers.NthPrimeNumber(3));
            //Numbers.NthPrimeNumber(10001);
            Console.WriteLine(Series.LargestProduct("7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450", 13));
            //Console.WriteLine(string.Join(" ", Numbers.Factors(20003)));
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
            //for (int i = 1; i <= 46; i++)
            //{
            //Console.WriteLine("{0}: {1}", i, string.Join(" ", Numbers.SmallestMultiple(i)));
            //}

            //Console.WriteLine(string.Join(" ", Numbers.PythagoreanTripleSum(1000)));
            //Console.WriteLine(Numbers.PythagoreanTripleProduct(Numbers.PythagoreanTripleSum(1000)));

            //Console.WriteLine(Numbers.NthPrimeNumber(3));
            //Console.WriteLine(Numbers.PrimeNumberSum(2000000));

            //Numbers.EulerGrid();
            //Console.WriteLine(Numbers.SolveGrid(4));

            Console.WriteLine(Series.FirstTriangleNumberWithFactorCount(500));
            sw.Stop();

            Console.WriteLine("Total time: {0}", sw.Elapsed);
            //Numbers.FactorPairs(1001).ForEach(delegate(long[] pair) { Console.WriteLine(string.Join(" ", pair)); });
            //Console.WriteLine(string.Join(" ", Numbers.PrimeFactors(30).ToArray()));;
            //Numbers.PrimeFactors(4000478);
            //Numbers.PrimeFactors(600851475143);
        }
    }
}
