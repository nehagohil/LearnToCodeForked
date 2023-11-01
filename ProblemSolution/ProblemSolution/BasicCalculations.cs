using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    public class BasicCalculations
    {
        public void Addition(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition is  :"+ result);
        }

        public void Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Subtraction is :" + result);
        }

        public void Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Multiplication is :" + result);
        }

        public void Division(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine("Division is : "+ result);
        }
    }
}
