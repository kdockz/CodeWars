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
    }
}
