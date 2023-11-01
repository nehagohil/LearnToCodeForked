using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    public class ComputeSum
    {
        public int SumOrTripleofsum(int num1, int num2)
        {
            if (num1 == num2)
            {
                return (num1 + num2) * 3;
            }
            else
            {
                return num1 + num2;
            }
        }
    }
}
