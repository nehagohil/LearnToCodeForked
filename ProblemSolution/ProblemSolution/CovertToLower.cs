using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    internal class CovertToLower
    {
        public void ConvertStringToLower(string str)
        {
            //string str = "My Name Is Neha"
            //65 -90 Uppercase and 97-122 Lowercase
            char[] chararray = str.ToCharArray();
            for (int i=0; i< chararray.Length; i++)
            {
                if (Convert.ToInt32(chararray[i]) >= 65 && Convert.ToInt32(chararray[i]) <=90 )
                {
                    chararray[i] = Convert.ToChar(Convert.ToInt32(chararray[i]) + 32);
                }
            }

            string newstr = new string(chararray);
            Console.WriteLine("New string is : "+newstr);

        }
    }
}
