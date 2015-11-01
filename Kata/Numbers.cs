using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Kata
{
    class Numbers
    {
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

        public static bool IsEven(long n)
        {
            return ((n & 1) == 0);
            //return (n % 2 == 0);
        }

        public static long CountOddPentaFibonacci(long n)
        {
            return (long)((n - 1) / 6) + (long)((n - 2) / 6) + 1;
        }

        public static long CountOddFibonacci(long n, int previousSize)
        {
            return (Fibonacci(n, previousSize).Where(num => !num.IsEven)).Distinct().Count();
        }

        public static IEnumerable<long> Fibonacci(long n)
        {
            long prev = 0;
            long cur = 0;
            long val = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i == 1)
                {
                    cur += i;
                }
                else
                {
                    val = prev + cur;
                    prev = cur;
                    cur = val;
                }

                yield return cur;
            }

            yield break;
        }

        public static IEnumerable<BigInteger> Fibonacci(long n, int previousSize)
        {
            BigInteger[] previousN = new BigInteger[previousSize];
            previousN[1] = 1;
            BigInteger cur;
            
            for (int i = 0; (i < previousSize) && (i <= n); i++)
            {
                //Base case
                if (i <= 0)
                {
                    yield return 0;
                }
                //Base case
                else if (i == 1)
                {
                    yield return 1;
                }
                else
                {
                    cur = previousN.Aggregate<BigInteger>(BigInteger.Add);
                    previousN[i] = cur;

                    yield return cur;
                }
            }

            for (int i = previousSize; i <= n; i++)
            {
                cur = previousN.Aggregate<BigInteger>(BigInteger.Add);

                for (int x = 1; x < previousSize; x++)
                {
                    previousN[x - 1] = previousN[x];
                }

                previousN[previousSize - 1] = cur;

                yield return cur;
            }


            yield break;

        }

        public static IEnumerator<long> Range(long n)
        {
            var number = 0;

            while (number != n)
            {
                yield return number++;
            }

            yield break;
        }
    }
}
