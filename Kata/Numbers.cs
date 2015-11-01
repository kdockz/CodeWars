using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    class Numbers
    {
        public static bool IsSquare(int n)
        {

            //Your code goes here!
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

        public static long CountOddPentaFib(long n)
        {

            List<long> oddTerms = new List<long>();
            List<long> sequence = new List<long>();
            long sum = 0;

            if (n == 0)
            {
                return 0;
            }

            for (long i = n-5; i < n; i++)
            {
                sum += CountOddPentaFib(i);
            }

            Console.WriteLine(sum);

            return sum;
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

        public static IEnumerable<long> Pentanacci(long n)
        {

            List<long> prev = new List<long>();

            return prev;

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
