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
            int num = 10;
            int result = sum(num);
            Console.WriteLine("addition using recusrsion is : "+result);
        }
        public int sum(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            else
            {
                return num + sum(num-1);
            }
        }

        public void ReverseMain()
        {
            int num = 123;
            int newnum = reversenum(num);
            Console.WriteLine("reverse Number using recursion is : "+newnum);

        }
        int sumadd = 0;


        public int reversenum(int num)
        {
            int rem = 0;
            if (num > 0)
            {
                rem = num % 10;
                sumadd = sumadd * 10 + rem;
                reversenum(num / 10);
                
            }
            return sumadd;





        }
    }
}
