using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    public class AdditionUsingRecursion
    {
       
        public void SumUsingRecursion()
        {
            int num = 5;
            int sum = 0;
            while (num > 0)
            {
                sum = add(num);
            }

            Console.WriteLine("sum is :" + sum);
        }
        public int add(int num)
        {
            return num + add(num--);    
        }

        public void ReverseNumberUsingRecusrion(int num)
        {
            while(num > 0)
            {

            }
        }
        public int reverse()
        {
            return Newnum;
        }
    }
}
