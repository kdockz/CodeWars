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
    }
}
