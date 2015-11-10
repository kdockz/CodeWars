using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    class Series
    {
        public static string SeriesNthSum(int n)
        {
            double sum = 0;     

            for (int i = 0; i < n; i++)
            {
                sum += (1d / ((i * 3d) + 1d));
            }

            //return Math.Round(sum, 2).ToString();
            //return String.Format("{0:0.00}", sum);
            return sum.ToString("0.00");
        }
        public static ulong SumOfMultiplesToN(ulong n, ulong multiple)
        {
            if (n == 0)
            {
                return 0;
            }

            var num = (n) / multiple;
            var sum = (((1 + num) * num) / 2) * multiple;

            return sum;
        }
        public static ulong SumOfMultiplesBelowN(ulong n, ulong multiple)
        {
            if (n == 0)
            {
                return 0;
            }

            var num = (n - 1) / multiple;
            var sum = (((1 + num) * num) / 2) * multiple;

            return sum;
        }

        public static ulong PowerOfSumToN(ulong n, ulong multiple, ulong power )
        {
            var num = SumOfMultiplesToN(n, multiple);

            return (ulong)Math.Pow(num, power);
        }

        public static ulong SumOfPowerToN(ulong n, ulong power)
        {
            ulong sum = 0;
            for (ulong i = 1; i <= n; i++)
            {
                sum += (ulong)Math.Pow(i, power);
            }
            return sum;
        }

        /// <summary>
        /// Returns the largest product in a number of length N, where 
        /// the adjacentNum adjacent digits have the largest product.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="adjacentNum"></param>
        /// <returns></returns>
        /// Go back and optimize code.
        public static string LargestProduct(string n, int adjacentNum)
        {
            List<int> num = new List<int>();
            ulong product = 1;
            ulong largest = 0;
            ulong digits = 0;
            Console.WriteLine(n.Length);
            for (int i = 0; i <= n.Length - adjacentNum; i++)
            {
                num = Numbers.ToDigitList(Int64.Parse(n.Substring(i, adjacentNum)));

                if (num.ToString().Length < adjacentNum)
                {
                    product = 0;
                }
                else
                {
                    product = 1;
                    //product = (ulong)(num.Aggregate((a, x) => a * x));
                    foreach (var d in num)
                    {
                        product *= (ulong)d;
                    }
                }

                if (product > largest)
                {
                    digits = (ulong)Numbers.ToNumber(num);
                    largest = product;

                    Console.WriteLine("Digits: {0}, Product: {1}", digits.ToString(), largest.ToString());
                }
            }

            return largest.ToString();
        }
    }
}
