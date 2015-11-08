using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Kata
{
    class Numbers
    {


        /// <summary>
        /// Determines i a given number n is a square number.
        /// That is, if n is the product of some number m times itself.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>boolean</returns>
        public static bool IsSquare(int n)
        {
            if (n < 0)
            {
                return false;
            }
            else
            {
                for (var i = 0; i <= n; i++)
                {
                    if (i * i > n)
                    {
                        return false;
                    }
                    else if (i * i == n)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public static bool IsEven(int n)
        {
           return IsEven((long)n);
        }

        /// <summary>
        /// Determines if a number is even.
        /// Uses bit math to determine if the first bit for a given number n is not set. (i.e. equal to zero)
        /// </summary>
        /// <param name="n"></param>
        /// <returns>boolean</returns>
        public static bool IsEven(long n)
        {
            return ((n & 1) == 0);
        }

        public static long CountOddPentaFibonacci(long n)
        {
            return (long)((n - 1) / 6) + (long)((n - 2) / 6) + 1;
        }

        public static long CountOddFibonacci(long n, int previousSize)
        {
            return FibonacciUpToNth(n, previousSize).Where(num => !IsEven(num)).Distinct().Count();
        }

        public static long SumEvenFibonacci(long n, int previousSize)
        {
            return FibonacciByValue(n, previousSize).Where(num => IsEven(num)).Sum();
        }

        public static IEnumerable<long> FibonacciUpToNth(long n, int previousSize)
        {
            var iter = Fibonacci(previousSize);

            for (int i = 0; i < n; i++)
            {
                iter.MoveNext();
                yield return iter.Current;
            }

            yield break;
        }

        public static IEnumerable<long> FibonacciByValue(long n, int previousSize)
        {
            var iter = Fibonacci(previousSize);

            while (iter.Current <= n)
            {
                iter.MoveNext();
                if (iter.Current <= n)
                {
                    yield return iter.Current;
                }
            }

            yield break;
        }

        public static IEnumerator<long> Fibonacci(long previousSize)
        {
            Queue<long> previousNqueue = new Queue<long>();
            previousNqueue.Enqueue(0);
            long cur = 0;

            while (true)
            {
                yield return cur;

                //Base case
                if (cur <= 0)
                {
                    cur += 1;
                    previousNqueue.Enqueue(cur);
                }
                else
                {
                    cur = previousNqueue.Sum();
                    previousNqueue.Enqueue(cur);

                    if (previousNqueue.Count > previousSize)
                    {
                        previousNqueue.Dequeue();
                    }
                }
            }
        }

        public static uint SumOfMultiples(uint n, uint multiple)
        {
            if (n == 0)
            {
                return 0;
            }

            var num = (n - 1) / multiple;
            var sum = (((1 + num) * num) / 2) * multiple;

            return sum;
        }

        public static List<long> Factors(long n)
        {
            List<long> factors = new List<long>();

            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                    factors.Add(n / i);
                    
                }
            }

            factors.Sort();

            return factors;
        }

        public static List<long[]> FactorPairs(long n)
        {
            List<long[]> factors = new List<long[]>();
            

            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    long[] pair = new long[2];
                    pair[0] = i;
                    pair[1] = n / i;
                    factors.Add(pair);
                }
            }

            return factors;
        }

        public static List<long> PrimeFactors(long n)
        {
            List<long> primeFactors = new List<long>();

            for (int i = 2; i*i <= n; i++)
            {
                while (n % i == 0)
                {
                    n = n / i;
                    primeFactors.Add(i);
                }
            }

            primeFactors.Add(n);

            return primeFactors;
        }

        public static long LargestPrimeFactor(long n)
        {
            List<long> primeFactors = PrimeFactors(n);

            return primeFactors.Max();
        }

        public static IEnumerable<string> DescendingPalindromes(long digitSize)
        {
            long maxNum = 0;
            for (int i = 0; i < digitSize; i++)
            {
                maxNum = Convert.ToInt32(string.Format("{0}{1}", maxNum, 9));
            }
            Console.WriteLine("MaxNum: {0}", maxNum);

            var maxProduct = maxNum * maxNum;
            Console.WriteLine("MaxProduct: {0}", maxProduct);

            long validDigits = (long)Math.Ceiling(maxProduct.ToString().Length / 2d);
            Console.WriteLine("ValidDigits: {0}", validDigits);

            List<int> palindrome = new List<int>();

            for (long i = maxNum; i > 0; i--)
            {
                var num = ToDigitList(i);
                palindrome.AddRange(num);
                num.Reverse();
                palindrome.AddRange(num);

                Console.WriteLine(string.Join("", palindrome.ToArray()));
                yield return string.Join("", palindrome.ToArray());

                palindrome.Clear();
            }

            yield break;
        }

        public static List<int> ToDigitList(long n)
        {
            List<int> num = new List<int>();

            while (n > 0)
            {
                int digit = (int)(n % 10);
                num.Add(digit);
                
                n = n / 10;
            }

            num.Reverse();

            return num;
        }
        
    }
}
