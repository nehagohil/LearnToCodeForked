using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    public class MultiplicationTable
    {
        public void PrintMultiplicationTable(int num)
        {
            Console.WriteLine("Multiplication table of " +num+ " is : ");
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine(num * i);
            }
        }
    }
}
