using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    public class SwapUsingThirdVariable
    {
        public void swap(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping....");
            Console.WriteLine("Number 1 is : " + num1);
            Console.WriteLine("Number 2 is : " + num2);
        }
    }
}
