using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateIntegral
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new LinFunc();
            test.M = 2;
            test.B = 0;

            Console.WriteLine(test.CalcIntegral(2, 4));
            //throw new Exception();

        }

    }
}
