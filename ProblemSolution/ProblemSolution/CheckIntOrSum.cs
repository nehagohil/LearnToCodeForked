using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    internal class CheckIntOrSum
    {
        public bool checkforadd(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Sum is : "+ result);

            if (num1 == 20 || num2 == 20 || result == 20)
            {
                return true;
            }
            else
                return false;
        }
    }
}
