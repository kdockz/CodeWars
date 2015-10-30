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
    }
}
