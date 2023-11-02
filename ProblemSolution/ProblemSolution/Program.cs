using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
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

            //string str = "w3resource";
            //char remove = '3';
            //int pos=0;
            //Console.WriteLine("String is : "+str);
            //for(int i=0; i< str.Length;i++)
            //{
            //    if (str[i] == remove)
            //    {
            //        pos = i;
            //    }

            //}
            //string newstr = str.Remove(pos,1);
            //Console.Write("After removing the character " +remove + " New string is : "+newstr);

            //16. Write a C# program to create a new string from a given string where the first and last characters change their positions.
            //Test Data:
            //w3resource
            //Python
            //Sample Output:
            //e3resourcw
            //nythoP

            //string str = "Neha";
            //char[] chararray = str.ToCharArray();
            //char temp = chararray[0];
            //chararray[0] = chararray[str.Length - 1];
            //chararray[str.Length - 1] = temp;    
            //string newstr = new string(chararray);
            //Console.WriteLine(newstr);

            //17.	Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
            //Sample Output:
            //Input a string : The quick brown fox jumps over the lazy dog.
            //TThe quick brown fox jumps over the lazy dog.T

            //string str = "The quick brown fox jumps over the lazy dog.";
            //char add = str[0];
            //string newstr = add + str + add;
            //Console.WriteLine(newstr);

            //18.	Write a C# program to check a pair of integers and return true if one is negative and one is positive.
            //Sample Output:
            //Input first integer:
            //            -5
            //Input second integer:
            //            25
            //Check if one is negative and one is positive:
            //True

            //int num1, num2;
            //Console.WriteLine("enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //CheckForNegative checkForNegative = new CheckForNegative();
            //bool valid = checkForNegative.checkPairOfInteger(num1, num2);
            //if (valid)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}


            //19.	Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum
            //int num1, num2;
            //Console.WriteLine("enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //ComputeSum computeSum = new ComputeSum();
            //int result = computeSum.SumOrTripleofsum(num1, num2);
            //Console.WriteLine(result);

            //20.	Write a C# program to get the absolute value of the difference between two given numbers.
            //Return double the absolute value of the difference if the first number is greater than the second number
            //int num1, num2;
            //Console.WriteLine("enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //AbsoluteDifference absoluteDifference = new AbsoluteDifference();
            //int absolutediff = absoluteDifference.CheckAbsoluteDifference(num1, num2);
            //Console.WriteLine("The difference is : "+absolutediff);

            // 21.Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.

            //int num1, num2;
            //Console.WriteLine("enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //CheckIntOrSum checkIntOrSum = new CheckIntOrSum();
            //bool valid = checkIntOrSum.checkforadd(num1, num2);
            //Console.WriteLine(valid);

            //22.	Write a C# program to check if the given integer is within 20 of 100 or 200.
            //Sample Output:
            //Input an integer:
            //25
            //False

            //int num1;
            //Console.WriteLine("enter number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //CheckIntOrSum checkIntOrSum1 = new CheckIntOrSum();
            //bool valid = checkIntOrSum1.checkforabsolute(num1);
            //Console.WriteLine(valid);

            //23.	Write a C# program to convert a given string into lowercase.
            //Sample Output:
            //write a c# sharp program to display the following pattern using the alphabet

            //string str = "My Name Is Neha";
            //CovertToLower covertToLower = new CovertToLower();
            //covertToLower.ConvertStringToLower(str);

            //24.	Write a C# program to find the longest word in a string.
            //Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
            //Sample Output:
            //following

            //string str = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            //int max = 0;
            //string[] strarr = str.Split(" ");
            //string longest ="";
            //for (int i=0; i<strarr.Length; i++)
            //{
            //    if (strarr[i].Length > max)
            //    {
            //        max = strarr[i].Length;
            //        longest = strarr[i];
            //    }
            //}

            //Console.WriteLine("The longest string is  :"+longest);

            //25.	Write a C# program to print odd numbers from 1 to 99. Prints one number per line.

            //for (int i=1; i<=99; i++)
            //{
            //    if(i % 2 !=0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //26.	Write a C# program to compute the sum of the first 500 prime numbers


            //for(int i=2; i<=10;i++)
            //{
            //    bool isPrime = true;
            //    for (int j=2; j<i;j++)
            //    {
            //        if(i % j == 0 && i != j)
            //        {
            //            isPrime = false;
            //        }
            //    }
            //    if(isPrime)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //logic 2

            //int num = 3;
            //bool isPrime = true;
            //for (int j = 2; j < num; j++)
            //{
            //    if (num % j == 0)
            //    {
            //        isPrime = false;
            //    }
            //}
            //if (isPrime)
            //{
            //    Console.WriteLine("This number is prime");
            //}
            //else
            //{
            //    Console.WriteLine("Not a prime");
            //}

            //int sum = 0;
            //int count = 0;
            //int num = 2;
            //do
            //{
            //    bool isPrime = true;
            //    for (int i=2; i< num; i++)
            //    {
            //        if(num % i ==0)
            //        {
            //            isPrime = false;
            //            break;
            //        }

            //    }
            //    if(isPrime)
            //    {
            //        sum = sum + num;
            //        Console.WriteLine(num);
            //        count++;
            //    }
            //    num++;

            //} while (count != 500);
            //Console.WriteLine("Sum of prime numbers are : "+sum);

            //27.Write a C# program and compute the sum of an integer's digits.
            //Sample Output:
            //Input a number(integer): 12
            //Sum of the digits of the said integer: 3

            //int num; 
            //int sum = 0;
            //Console.WriteLine("Enter number to add integers : ");
            //num = Convert.ToInt32(Console.ReadLine());
            //while(num >0)
            //{
            //   int rem = num % 10; 
            //    num = num / 10; 
            //    sum += rem;
            //}
            //Console.WriteLine("sum is :"+sum);

            //28.	Write a C# program to reverse the words of a sentence.
            //Sample Output:
            //Original String: Display the pattern like pyramid using the alphabet.
            //Reverse String: alphabet.the using pyramid like pattern the Display

            //string str = "Display the pattern like pyramid using the alphabet.";
            //string[] strarray = str.Split(" ");
            //string newstr = "";

            //for (int i = strarray.Length-1; i>=0; i--)
            //{
            //    newstr += strarray[i] +" ";

            //}

            //Console.Write(newstr);

            //29.	Write a C# program to find the size of a specified file in bytes.
            //Sample Output:
            //Size of a file: 31

            FileInfo file = new FileInfo("C:\\GitDemo/songs.txt");
            Console.WriteLine(file.Length.ToString());


        }
    }
}