using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    internal class CountNumberOfNotes
    {
        public void countnotes(int amount)
        {
            int note2000 = 0, note1000 = 0, note500 = 0, note200 = 0, note100 = 0, note50 = 0, note20 = 0, note10 = 0, note5 = 0, note2 = 0, note1 = 0;
            while (amount > 0)
            {
                if (amount >= 2000)
                {
                    note2000 = amount / 2000;
                    amount = amount - note2000 * 2000;

                }
                else if (amount >= 1000)
                {
                    note1000 = amount / 1000;
                    amount = amount - note1000 * 1000;
                }
                else if (amount >= 500)
                {
                    note500 = amount / 500;
                    amount = amount - note500 * 500;
                }
                else if (amount >= 200)
                {
                    note200 = amount / 200;
                    amount = amount - note200 * 200;
                }
                else if (amount >= 100)
                {
                    note100 = amount / 100;
                    amount = amount - note100 * 100;
                }
                else if (amount >= 50)
                {
                    note50 = amount / 50;
                    amount = amount - note50 * 50;
                }
                else if (amount >= 20)
                {
                    note20 = amount / 20;
                    amount = amount - note20 * 20;
                }
                else if (amount >= 10)
                {
                    note10 = amount / 10;
                    amount = amount - note10 * 10;
                }
                else if (amount >= 5)
                {
                    note5 = amount / 5;
                    amount = amount - note5 * 5;
                }
                else if (amount >= 2)
                {
                    note2 = amount / 2;
                    amount = amount - note2 * 2;
                }
                else
                {
                    note1 = amount / 1;
                    amount = amount - note1 * 1;
                }

            }

            Console.WriteLine("Number of notes for the amount is below : ");
            Console.WriteLine(" Notes of 2000 : " + note2000);
            Console.WriteLine(" Notes of 1000 : " + note1000);
            Console.WriteLine(" Notes of 500 : " + note500);
            Console.WriteLine(" Notes of 200 : " + note200);
            Console.WriteLine(" Notes of 100 : " + note100);
            Console.WriteLine(" Notes of 50 : " + note50);
            Console.WriteLine(" Notes of 20 : " + note20);
            Console.WriteLine(" Notes of 10 : " + note10);
            Console.WriteLine(" Notes of 5 : " + note5);
            Console.WriteLine(" Notes of 2 : " + note2);
            Console.WriteLine(" Notes of 1 : " + note1);
        }
    }
}
