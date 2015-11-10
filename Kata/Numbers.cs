using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics;
namespace Kata
{
    public static class Numbers
    {

        /// <summary>
        /// Storing the powers of 10 into an array to assist with total runtime
        /// of functions that need to access the powers of 10 regularly.
        /// </summary>
        private static long[] m_PowersOfTen = new long[] { 1,
                                                           10,
                                                           100,
                                                           1000,
                                                           10000,
                                                           100000,
                                                           1000000,
                                                           10000000,
                                                           100000000,
                                                           1000000000,
                                                           10000000000,
                                                           100000000000,
                                                           1000000000000,
                                                           10000000000000,
                                                           100000000000000,
                                                           1000000000000000,
                                                           10000000000000000,
                                                           100000000000000000,
                                                           1000000000000000000 };

        /// <summary>
        /// Determines if a given number n is a square number.
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

        /// <summary>
        /// Helper function used to check if values of type long are even.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Mathematical formula for counting the number of odd digits
        /// in a fibonacci sequence where the next number is always 
        /// determined by the sum of the previous 5 digits.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long CountOddPentaFibonacci(long n)
        {
            return (long)((n - 1) / 6) + (long)((n - 2) / 6) + 1;
        }


        /// <summary>
        /// Counts the odd numbers in a given fibonacci sequence.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="previousN"></param>
        /// <returns></returns>
        public static long CountOddFibonacci(long n, int previousN)
        {
            return FibonacciUpToNth(n, previousN).Where(num => !IsEven(num)).Distinct().Count();
        }

        /// <summary>
        /// Sum of the even numbers in a given fibonacci sequence.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="previousN"></param>
        /// <returns></returns>
        public static long SumEvenFibonacci(long n, int previousN)
        {
            return FibonacciByValue(n, previousN).Where(num => IsEven(num)).Sum();
        }

        /// <summary>
        /// Fibonacci sequence of size N where all values up to N
        /// is the sum of the previousN numbers before it.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="previousN"></param>
        /// <returns></returns>
        public static IEnumerable<long> FibonacciUpToNth(long n, int previousN)
        {
            var iter = Fibonacci(previousN);

            for (int i = 0; i < n; i++)
            {
                iter.MoveNext();
                yield return iter.Current;
            }

            yield break;
        }

        /// <summary>
        /// Fibonacci sequence of an undetermined size where all values
        /// are the sum of the previousN numbers before it and the last
        /// digit in the sequence is equal to or less than N.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="previousN"></param>
        /// <returns></returns>
        public static IEnumerable<long> FibonacciByValue(long n, int previousN)
        {
            var iter = Fibonacci(previousN);

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

        /// <summary>
        /// Helper function for Fibonacci that generates the numbers in a 
        /// Fibonacci sequence where the next value is the sum of the previousN
        /// numbers before it.
        /// </summary>
        /// <param name="previousN"></param>
        /// <returns></returns>
        public static IEnumerator<long> Fibonacci(long previousN)
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

                    if (previousNqueue.Count > previousN)
                    {
                        previousNqueue.Dequeue();
                    }
                }
            }
        }

        /// <summary>
        /// Returns all the factors of a given N.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<ulong> Factors(ulong n)
        {
            List<ulong> factors = new List<ulong>();

            for (ulong i = 1; i * i <= n; i++)
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

        /// <summary>
        /// Returns all the pairs of factors of a given N.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<long[]> FactorPairs(long n)
        {
            List<long[]> factors = new List<long[]>();

            factors.Add(new[] { 1, n });

            for (long i = 2; i * i < n; i++)
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

        /// <summary>
        /// Returns all the prime factors of a given N.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns the largest prime factor of a given N.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long LargestPrimeFactor(long n)
        {
            List<long> primeFactors = PrimeFactors(n);

            return primeFactors.Max();
        }

        /// <summary>
        /// Returns the smallest factor that is NOT 1 of a given N.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long SmallestFactor(long n)
        {
            for (long i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return i;
                }
            }

            return n;
        }

        /// <summary>
        /// Calculates the smallest number in which 1 to N
        /// are all factors of.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static ulong SmallestMultiple(long n)
        {
            ulong num = 1;
            
            for (int i = 1; i <= n; i++)
            {
                if (num % (ulong)i != 0)
                {
                    num *= (ulong)SmallestFactor(i);
                }
            }

            return num;
        }

        /// <summary>
        /// Finds the largest palindrome that has a factor pair 
        /// with both factors of length pairSize.
        /// </summary>
        /// <param name="pairSize"></param>
        /// <returns></returns>
        public static long LargestPalindromeWithEqualSizePairs(int pairSize)
        {
            List<long[]> pairs;

            foreach (var palindrome in DescendingPalindromes(pairSize*2))
            {
                pairs = FactorPairs(palindrome);

                foreach (var pair in pairs)
                {
                    if (pair.All(num => num.ToString().Length == pairSize))
                    {
                        return palindrome;
                    }
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds all palindromes with a length equal to or less than the
        /// given length and returns them in descending order.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static IEnumerable<long> DescendingPalindromes(int length)
        {
            for (var j = length; j >= 2; j--)
            {
                foreach (var palindrome in PalindromesOfSizeN(j))
                {
                    yield return palindrome;
                }
            }

            yield break;
        }

        /// <summary>
        /// Finds all palindromes of a given length;
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static IEnumerable<long> PalindromesOfSizeN(int length)
        {
            int validDigits = (int)Math.Ceiling(length / 2d);
            List<int> palindrome = new List<int>(length);
            var oddLength = !IsEven(length);

            for (long i = m_PowersOfTen[validDigits] - 1; i >= m_PowersOfTen[validDigits - 1]; i--)
            {
                var num = ToDigitList(i);

                palindrome.AddRange(num);

                if (oddLength)
                {
                    num.RemoveAt(num.Count - 1);
                }

                num.Reverse();

                palindrome.AddRange(num);

                yield return palindrome.ToNumber();

                palindrome.Clear();
            }

            yield break;
        }

        public static long NthPrimeNumber(long n)
        {
            var iter = PrimeNumber();

            for (int i = 1; i <= n; i++)
            {
                iter.MoveNext();

                if (i == n)
                {
                    return iter.Current;
                }
            }

            return -1;
        }

        public static IEnumerator<long> PrimeNumber()
        {
            long num = 0;

            while (true)
            {
                if (Factors((ulong)num).Count == 2)
                {
                    Console.WriteLine(num);
                    yield return num;
                }

                if (num == 0)
                {
                    num += 2;
                }
                else if (num < 3)
                {
                    num += 1;
                }
                else
                {
                    num += 2;
                }
            }
        }
                     
        /// <summary>
        /// Converts a long to a list of integers.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Converts a list of integers to a long.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// 9781797784617
        public static long ToNumber(this List<int> n)
        {
            long num = 0;

            n.Reverse();

            for (int i = 0; i < n.Count; i++)
            {
                num += n[i] * m_PowersOfTen[i];
            }

            return num;
        }
    }
}
