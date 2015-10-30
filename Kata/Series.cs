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

            decimal sum = 0;     

            for (int i = 0; i < n; i++)
            {
                sum += (1.00m / ((i * 3) + 1));
            
            }

            return Math.Round(sum, 2).ToString();
            //return sum.ToString("0.00");
        }
    }
}
