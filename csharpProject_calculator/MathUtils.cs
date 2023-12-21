using System;

/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace csharpProject_calculator
{
    internal class MyMath
    {
        public double DegToRad(double DegAngle)
        {
            return 0.0;
        }

        public double RadToDeg(double RadAngle)
        {
            return 0.0;
        }

        public int factoriel(int value)
        {
            int factoriel = 1;
            for (int i = value; i >=1; i--)
            {
                factoriel *= i;
            }

            return factoriel;
        }
    }
}
