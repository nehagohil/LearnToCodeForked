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

        public bool checkforabsolute(int num1)
        {
            if (Math.Abs(num1 - 100) <= 20 || Math.Abs(num1 - 200) <= 20)
            {
                return true;
            }
            else
                return false;
        }
    }
}
