using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    internal class FactorialUsingRecursion
    {
        public int factorial(int num)
        {
            int fact = 1;
            
            if(num ==1)
            {
                return 1;
            }

            return num * factorial(num - 1);
        }
    }
}
