using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "test";

            test[0].ToString().ToUpp


        }

    }

    public static string Swap(string str)
    {

        string newstr = "";

        foreach (var letter in str)
        {
            if (((int)letter >= (int)'a') & ((int)letter <= (int)'z'))
            {
                newstr += letter.ToString().ToUpper();
            }
            else if (((int)letter >= (int)'A') & ((int)letter <= (int)'Z'))
            {
                newstr += letter.ToString().ToLower();
            }
            else
            {
                newstr += letter;
            }
        }
        return newstr; //your code here
    }
}
