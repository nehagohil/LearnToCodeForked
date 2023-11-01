using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    public class CheckForNegative
    {
        public bool checkPairOfInteger(int num1, int num2)
        {
            if (num1 < 0 && num2 > 0 || num1 > 0 && num2 < 0)
            {
                return true;
            }
            else
            return false;
        }
    }
}
