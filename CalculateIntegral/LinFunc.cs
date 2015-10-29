using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateIntegral
{
    public class LinFunc
    {
        private double m_pi = 3.14;
 
        public double pi {
            get {
                return m_pi;
            }

            private set {
                m_pi = value;
            }
        }
        public double M { get; set; }
        public double B { get; set; }

        public double GetY(double x)
        {
            return M * x + B;
        }

        public double CalcIntegral(int x)
        {
            return (M * (x * x)) / 2 + (B * x);
        }

        public double CalcIntegral(int from, int to)
        {
            return CalcIntegral(to) - CalcIntegral(from);
        }

    }
}
