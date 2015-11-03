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
    }
}
