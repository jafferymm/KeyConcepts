using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyConcepts
{
    public static class Recursion
    {
        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;
            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        public static double FactorialWithRecursion(int number)
        {
            if (number == 0)
                return 1;

            return number * FactorialWithRecursion(number - 1);
        }

    }
}
