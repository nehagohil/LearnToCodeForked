using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace ProblemSolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1. Write a C# Sharp program to print Hello and your name in a separate line.
            //HelloWorld helloWorld = new HelloWorld();
            //helloWorld.Print();

            //2. Write a C# Sharp program to print the sum of two numbers.
            //int num1, num2, result;
            //Console.WriteLine("Please enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //SumOfTwoNumbers sumOfTwoNumbers = new SumOfTwoNumbers();
            //result = sumOfTwoNumbers.sum(num1 , num2);
            //Console.WriteLine("Sum of two numbers is : " +result);

            //3. Write a C# Sharp program to print the result of dividing two numbers
            //int num1, num2, result;
            //Console.WriteLine("Please enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //DivisionOfTwoNumbers divisionOfTwoNumbers = new DivisionOfTwoNumbers();
            //result = divisionOfTwoNumbers.Division(num1 , num2);
            //Console.WriteLine("Division of two numbers is : " + result);

            //4. Write a C# Sharp program to print the results of the specified operations.
            //Test data:
            //-1 + 4 * 6
            //(35 + 5) % 7
            //14 + -4 * 6 / 11
            //2 + 15 / 6 * 1 - 7 % 2
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 5) % 7);
            //Console.WriteLine(14 + -4 * 6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            //5. Write a C# Sharp program to swap two numbers using third variable
            //int num1, num2;
            //Console.WriteLine("Let's swap using third variable....");
            //Console.WriteLine("enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //SwapUsingThirdVariable swapUsingThirdVariable = new SwapUsingThirdVariable();
            //swapUsingThirdVariable.swap(num1, num2);

            //6. Write a C# Sharp program to swap two numbers without using third variable
            //int num1, num2;
            //Console.WriteLine("Let's swap using third variable....");
            //Console.WriteLine("enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //SwapUsingThirdVariable swapUsingThirdVariable1 = new SwapUsingThirdVariable();
            //swapUsingThirdVariable1.swapWithoutusingThirdVariable(num1 , num2);

            //7. Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.

            //int num1, num2, num3;
            //Console.WriteLine("enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 3 : ");
            //num3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Multiplication is : " +num1 * num2 * num3);

            //8. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user

            //int num1, num2;
            //Console.WriteLine("enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //BasicCalculations basicCalculations = new BasicCalculations();
            //basicCalculations.Addition(num1,num2);
            //basicCalculations.Subtraction(num1, num2);
            //basicCalculations.Multiplication(num1,num2);
            //basicCalculations.Division(num1,num2);

            //9. Write a C# Sharp program that prints the multiplication table of a number as input
            //int num;
            //Console.WriteLine("Enter the number for Printing the multiplication table : ");
            //num = Convert.ToInt32(Console.ReadLine());
            //MultiplicationTable multiplicationTable = new MultiplicationTable();
            //multiplicationTable.PrintMultiplicationTable(num);

            // 10.	Write a C# Sharp program that takes four numbers as input to calculate and print the average
            //int num1, num2, num3, num4, average = 4, averageResult;
            //Console.WriteLine("enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 3 : ");
            //num3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 4 : ");
            //num4 = Convert.ToInt32(Console.ReadLine());
            //averageResult = (num1 + num2 + num3 + num4) / average;
            //Console.WriteLine("Average of the four input numbers are : " + averageResult);

            //11. Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
            //int x, y, z;
            //Console.WriteLine("enter X : ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter Y : ");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter Z : ");
            //z = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((x+y)*z);
            //Console.WriteLine(x*y + y*z);

            //12. Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
            //Test Data:
            //Enter a digit: 25
            //Expected Output:
            //25 25 25 25
            //25252525
            //25 25 25 25
            //25252525

            //int num;
            //Console.WriteLine("Enter number");
            //num = Convert.ToInt32(Console.ReadLine());
            //string numwithspace = num + " " + num + " " + num + " " + num;
            //string numwithnospace = num + "" + num + "" + num + "" + num;
            //Console.WriteLine("{0}", numwithspace);
            //Console.WriteLine("{0}", numwithnospace);
            //Console.WriteLine("{0}", numwithspace);
            //Console.WriteLine("{0}", numwithnospace);

            // 13. Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
            //int num;
            //Console.WriteLine("Enter number");
            //num = Convert.ToInt32(Console.ReadLine());
            //for(int i=0; i<5;i++)
            //{
            //    for(int j=0; j<3; j++)
            //    {
            //        Console.Write(num);
            //    }
            //    Console.WriteLine();
            //}

            //14. Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit. Kelvin = Celsius + 273.15

            //int celcius;
            //double add = 273.15;
            //double kelvin, Fahrenheit;
            //Console.WriteLine("Please enter celcius degrees to convert : ");
            //celcius = Convert.ToInt32(Console.ReadLine());
            //kelvin = celcius + add;
            //Console.WriteLine("Kelvin conversion is  :" + kelvin);
            //Fahrenheit = (celcius * 9 / 5) + 32;
            //Console.WriteLine("Fahrenheit conversion is  :" + Fahrenheit);

            //15.	Write a C# program that removes a specified character from a non-empty string using the index of a character.
            //Test Data:
            //w3resource
            //Sample Output:
            //wresource
            //w3resourc
            //3resource

                string str = "w3resource";
                char remove = '3';
                int pos=0;
                Console.WriteLine("String is : "+str);
                for(int i=0; i< str.Length;i++)
                {
                    if (str[i] == remove)
                    {
                        pos = i;
                    }

                }
                string newstr = str.Remove(pos,1);
                Console.Write("After removing the character " +remove + " New string is : "+newstr);
        }
    }
}