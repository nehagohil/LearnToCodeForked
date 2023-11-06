using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
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

            //FileInfo file = new FileInfo("C:\\GitDemo/songs.txt");
            //Console.WriteLine(file.Length.ToString());

            //30.	Write a C# program to convert a hexadecimal number to a decimal number.
            //Sample Output:
            //Hexadecimal number: 4B0
            //Convert to -
            //Decimal number: 1200

            //string hexnum = "4B0";
            //int decimalValue =int.Parse(hexnum, System.Globalization.NumberStyles.HexNumber);
            //Console.WriteLine("Conversion from HEX to Decimal is :" +decimalValue);

            //31.Program to Find Sum of N Numbers using Recursion.
            //AdditionUsingRecursion additionUsingRecursion = new AdditionUsingRecursion();
            //additionUsingRecursion.SumUsingRecursion();

            ////32.C# Program to Multiply two Floating Point Numbers
            //double multiplication;
            //float num1, num2;
            //Console.WriteLine("enter number 1 : ");
            //num1 = (float) Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter number 2 : ");
            //num2 = (float)Convert.ToDouble(Console.ReadLine());

            //multiplication = num1 * num2;
            //Console.WriteLine(multiplication);

            //33.Reverse Number using Recursion in C
            //AdditionUsingRecursion additionUsingRecursion1 = new AdditionUsingRecursion();
            //additionUsingRecursion1.ReverseMain();

            //35.Prime Number using Recursion in C


            //36.C# Program to find the Size of data types
            //Console.WriteLine("Size of Int is " +sizeof(int));
            //Console.WriteLine("Size of Float is " + sizeof(float));
            //Console.WriteLine("Size of Double is " + sizeof(double));
            //Console.WriteLine("Size of Character is " + sizeof(char));
            //Console.WriteLine("Size of Boolean is " + sizeof(bool));

            //38.C# Program to Print ASCII Value of character
            //char ch = 'A';
            //Console.WriteLine("ASCII value of a character is : "+ Convert.ToInt32(ch));

            //39.Write a C# Sharp program to find the length of a string without using a library function.
            //string str = "My name is Neha";
            //Console.WriteLine("Using function length is :"+str.Length);
            //int count = 0;
            //foreach (var item in str)
            //{
            //    count++;
            //}
            //Console.WriteLine("Length of the string is :"+count);

            //40.	C# Program to check whether an integer entered by the user is odd or even.
            //int num;
            //Console.WriteLine("Enter the number :");
            //num = Convert.ToInt32(Console.ReadLine());
            //if(num % 2 == 0)
            //{
            //    Console.WriteLine("This number is even");
            //}
            //else
            //{
            //    Console.WriteLine("This number is odd");
            //}

            //41.Write a C# Sharp program to separate individual characters from a string
            //string str = "Neha is a good girl";
            //char[] chararr = str.ToCharArray();
            //for(int i=0; i< chararr.Length; i++)
            //{
            //    Console.WriteLine(chararr[i]);
            //}

            //42.C# Program to Find the Largest Number using Conditional Operator
            //int num1, num2;
            //Console.WriteLine("Enter the number 1 :");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the number 2 :");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //if(num1 > num2)
            //{
            //    Console.WriteLine("Num1 is largest");
            //}
            //else
            //{
            //    Console.WriteLine("Num2 is largest");
            //}

            //43.Write a program in C# Sharp to print individual characters of the string in reverse order.
            //string str = "Shivam is a bad boy";
            //char[] chararr = str.ToCharArray();
            //for (int i = chararr.Length -1; i >=0; i--)
            //{
            //    Console.WriteLine(chararr[i]);
            //}

            //44.C# Program to Check whether an alphabet is a vowel or not
            //char ch;
            //Console.WriteLine("Enter the character : ");
            //ch = Convert.ToChar(Console.ReadLine().ToLower());
            //Console.WriteLine(ch);
            //switch(ch)
            //{
            //    case 'a':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    case 'e':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    case 'i':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    case 'o':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    case 'u':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    default:
            //        Console.WriteLine("This is not a vowel");
            //        break;
            //}

            //45.	Write a program in C# Sharp to count the total number of words in a string.

            //string str = "My name is Neha and Shivam is my husband";
            //int count = 0;
            //string[] strarray = str.Split(" ");
            //foreach (var item in strarray)
            //{
            //    count++;
            //}
            //Console.WriteLine("Total number of words in string are :" +count);

            //46.	C# program to check whether a triangle can be formed by the given value for the angles.
            //int angle1, angle2, angle3;
            //int triangleCanForm = 180;
            //Console.WriteLine("enter angle1 : ");
            //angle1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter angle2 : ");
            //angle2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter angle3 : ");
            //angle3 = Convert.ToInt32(Console.ReadLine());

            //if(angle1+angle2+angle3 ==triangleCanForm)
            //{
            //    Console.WriteLine("Yes, Traingle can be formed..");
            //}
            //else
            //{
            //    Console.WriteLine("No, Triangle can't be formed..");
            //}

            //47.	Write a program in C# Sharp to compare two strings without using a string library functions
            //string str1 = "Neha";
            //string str2 = "Shivam";
            //char[] str1chararr = str1.ToCharArray();
            //char[] str2chararr = str2.ToCharArray();
            //bool IsEqual = true;
            //if(str1chararr.Length == str2chararr.Length)
            //{
            //    for (int i=0; i<str1chararr.Length; i++)
            //    {

            //            if (str1chararr[i] == str2chararr[i])
            //            {
            //                continue;
            //            }
            //            else
            //            {
            //                IsEqual = false;
            //                Console.WriteLine("Strings are not equal...");
            //                break;
            //            }
            //    }
            //    if(IsEqual)
            //    {
            //        Console.WriteLine("Strings are equal..");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Strings are not equal");
            //}

            //48.C# program to count total number of notes in entered amount

            //int amount=0;
            //Console.WriteLine("Enter the amount : ");
            //amount = Convert.ToInt32(Console.ReadLine());
            //CountNumberOfNotes countNumberOfNotes = new CountNumberOfNotes();
            //countNumberOfNotes.countnotes(amount);


            //49.	Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string
            //string str = "I love Shivam > 3";
            //int countalphabets = 0, countdigits = 0, countspecialchar = 0;
            //char[] strchararr = str.ToCharArray();
            //foreach (var item in strchararr)
            //{
            //    if(item >= 'A' && item <='Z' || item >= 'a' && item <= 'z')
            //    {
            //        countalphabets += 1;
            //    }
            //    else if(item >= '0' && item <='9')
            //    {
            //        countdigits += 1;

            //    }
            //    else if(item == ' ')
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        countspecialchar += 1;
            //    }

            //}
            //Console.WriteLine(" Count of alphaets in the string is :"+ countalphabets);
            //Console.WriteLine(" Count of digits in the string is :" + countdigits);
            //Console.WriteLine(" Count of special characteres in the string is :" + countspecialchar);

            //50.Write C# program to print alphabets from a to z.
            //for (char i ='a'; i<='z';i++)
            //{
            //    Console.WriteLine(i);
            //}

            //51.Write a program in C# Sharp to copy one string to another string and print number of characters copied.
            //string str = "Neha is cutest";
            //string CopiedString = " ";
            //char[] strarr = str.ToCharArray();
            //char[] Copyarr = new char[strarr.Length];
            //for(int i=0; i<strarr.Length;i++)
            //{
            //    Copyarr[i] = strarr[i];
            //}

            //CopiedString = new string(Copyarr);
            //Console.WriteLine("Copied string is : " + CopiedString);

            //52.Write C# program to print all natural numbers in reverse order
            //int limit;
            //Console.WriteLine("Enter limit to print :");
            //limit = Convert.ToInt32(Console.ReadLine());

            //for (int i = limit; i>=1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //53.Write a C# Sharp program to count the number of vowels or consonants in a string.
            //string str = "Neha is a sweet girl";
            //int vowelcount = 0, consonantscount = 0;
            //char[] chararr = str.ToCharArray();

            //foreach (var item in chararr)
            //{
            //    switch(item)
            //    {
            //        case 'a':
            //            vowelcount += 1;
            //            break;
            //        case 'e':
            //            vowelcount += 1;
            //            break;
            //        case 'i':
            //            vowelcount += 1;
            //            break;
            //        case 'o':
            //            vowelcount += 1;
            //            break;
            //        case 'u':
            //            vowelcount += 1;
            //            break;
            //        case ' ':
            //            break;
            //        default:
            //            consonantscount += 1;
            //            break;
            //    }
            //}
            //Console.WriteLine("Number of vowels :"+vowelcount);
            //Console.WriteLine("Number of Consonants :"+consonantscount);

            //54.Write a C# Sharp program to find the maximum number of characters in a string


            //55.Write a C# Sharp program to sort a string array in ascending order.

            //string str = "Siraj Shivam";
            //string[] strarr = str.Split(" ");
            //string temp = "";

            //for(int i=0; i<strarr.Length;i++)
            //{
            //    for (int j=i+1; j<strarr.Length;j++)
            //    {
            //        if ((strarr[i])[i] > (strarr[j])[i])
            //        {
            //            temp = strarr[i];
            //            strarr[i] = strarr[j];
            //            strarr[j] = temp; 
            //        }
            //    }
            //}
            //for(int k=0; k<strarr.Length;k++)
            //{
            //    Console.WriteLine(strarr[k]);
            //}

            //56.Write a program in C# Sharp to extract a substring from a given string without using the library function.

            //string str = "Shivam is my husband";
            //char[] strarr = str.ToCharArray();
            //int startindex, endindex;
            //char[] newchararr = new char[strarr.Length];
            //Console.WriteLine("Given string is :" + str);
            //Console.WriteLine("enter the start index from which you want to get the substring");
            //startindex =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the end index from which you want to get the substring");
            //endindex = Convert.ToInt32(Console.ReadLine());
            //for (int i= startindex; i<=endindex; i++)
            //{
            //    newchararr[i] = strarr[i];
            //}

            //string newstr = new string(newchararr);
            //Console.WriteLine("Substring is :"+ newstr);

            //57.	Write a C# Sharp program to check whether a given substring is present in the given string

            //58.	Write a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.

            //A-Z is 65-90 a-z is 97-122
            //string str = "nEHA iS mY nAME ";
            //char[] chararr = str.ToCharArray();
            //for(int i=0; i<chararr.Length;i++)
            //{
            //    if (Convert.ToInt32(chararr[i]) >=65 && Convert.ToInt32(chararr[i]) <= 90)
            //    {
            //        chararr[i] = (char)(Convert.ToInt32(chararr[i]) + 32);
            //    }
            //    else if(Convert.ToInt32(chararr[i]) >= 97 && Convert.ToInt32(chararr[i]) <= 122)
            //    {
            //        chararr[i] = (char)(Convert.ToInt32(chararr[i]) - 32);
            //    }
            //}

            //string newstr = new string(chararr);
            //Console.WriteLine("String is : "+newstr);

            //59.	Write a program in C# Sharp to search for the position of a substring within a string.

            //60.	Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case(upper or lower).
            //char ch;
            //Console.WriteLine("Enter the character :");
            //ch = Convert.ToChar(Console.ReadLine());
            //if(ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z')
            //{
            //    Console.WriteLine("This character is an alphabet");
            //    if(Convert.ToInt32(ch) >=65 && Convert.ToInt32(ch) <= 90)
            //    {
            //        Console.WriteLine("This is a uppercase character");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This is a lowercase character");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("This character is not an alphabet");
            //}

            //61.Write a program in C# Sharp to find the number of times a substring appears in a given string.

            //string str = "India is my country. It is very nice.";
            //string substring;
            //Console.WriteLine("Enter substring to check occurances :");
            //substring = Console.ReadLine();
            //int subscount = 0;
            //bool IsEqual = true;
            //char[] charstrarr = str.ToCharArray();
            //char[] charsubsarr = substring.ToCharArray();
            //for(int i=0; i< charstrarr.Length;i++)
            //{
            //    for(int j=0; j< charsubsarr.Length;j++)
            //    {
            //        if (charsubsarr[j] == charstrarr[i])
            //        {
            //            i++;
            //            IsEqual = true;
            //            continue;
            //        }
            //        else
            //        {
            //            IsEqual = false;
            //            break;
            //        }
            //    }
            //    if(IsEqual)
            //    {
            //        subscount += 1;
            //    }
            //}

            //Console.WriteLine("Number of times substring occured is :"+subscount);

            //62.Write a C# Program to check whether an integer entered by the user is odd or even

            //int num;
            //Console.WriteLine("Enter number :");
            //num = Convert.ToInt32(Console.ReadLine());

            //if(num % 2 == 0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}

            //63.Write a C# program to check leap year using conditional Operator
            //int year;
            //Console.WriteLine("Enter year to check for leap :");
            //year = Convert.ToInt32(Console.ReadLine());
            //bool isLeap = true;

            //isLeap = year % 4 == 0 ? true : false;
            //if(isLeap)
            //{
            //    Console.WriteLine("This year is a leap year");
            //}
            //else
            //{
            //    Console.WriteLine("This year is not a leap year");
            //}

            //64.Write a C# program to check number is positive, negative or zero.
            //int num;
            //Console.WriteLine("Enter number :");
            //num = Convert.ToInt32(Console.ReadLine());
            //if(num < 0)
            //{
            //    Console.WriteLine("Number is negative");
            //}
            //else if(num > 0)
            //{
            //    Console.WriteLine("Number is positive");
            //}
            //else
            //{
            //    Console.WriteLine("Number is zero");
            //}

            //65.Write a C# program to print day name of week.

            //int day;
            //do
            //{
            //    Console.WriteLine("Enter day from 1-7 :");
            //    day = Convert.ToInt32(Console.ReadLine());

            //    switch (day)
            //    {
            //        case 1:
            //            Console.WriteLine("This day is Monday");
            //            break;
            //        case 2:
            //            Console.WriteLine("This day is Tuesday");
            //            break;
            //        case 3:
            //            Console.WriteLine("This day is wednesday");
            //            break;
            //        case 4:
            //            Console.WriteLine("This day is thursday");
            //            break;
            //        case 5:
            //            Console.WriteLine("This day is friday");
            //            break;
            //        case 6:
            //            Console.WriteLine("This day is saturday");
            //            break;
            //        case 7:
            //            Console.WriteLine("This day is sunday");
            //            break;

            //        default:
            //            Console.WriteLine("You have entered incorrect day...please enter between 1 - 7");
            //            break;
            //        //case 10:
            //        //    Environment.Exit(0);
            //        //    break;
            //    } 

            //} while (day != 10);

            //66.Write a C# program to accept two integers and check whether they are equal or not.
            //int num1, num2;
            //Console.WriteLine("Enter number 1: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number 2: ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //if(num1 == num2)
            //{
            //    Console.WriteLine("Numbers are equal");
            //}
            //else
            //{
            //    Console.WriteLine("Numbers are not equal");
            //}

            //67.Write a C# program to detrermine a candidate’s age is eligible for casting the vote or not.

            //int age;
            //Console.WriteLine("Enter age: ");
            //age = Convert.ToInt32(Console.ReadLine());
            //if(age >= 18)
            //{
            //    Console.WriteLine("This age is eligible for casting vote.");
            //}
            //else
            //{
            //    Console.WriteLine("This age is not eligible for casting vote.");
            //}

            //68.Write a C# program to find the eligibility of admission for an engineering course based on the criteria.
            //int physics, chemistry, maths;
            //Console.WriteLine("enter marks for Physics :");
            //physics = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter marks for chemistry :");
            //chemistry = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter marks for maths :");
            //maths = Convert.ToInt32(Console.ReadLine());

            //if(physics > 35 && chemistry >35 && maths>35)
            //{
            //    if (physics + chemistry + maths > 200)
            //    {
            //        Console.WriteLine("You are eligible for engineering admission");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are not eligible for engineering admission");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for engineering admission");
            //}

            //69.Write a C# program to calculate the total marks, percentage and division of student

            //int maths, science, english, socialscience, geography,totalmarks=0;
            //Console.WriteLine("enter marks for maths :");
            //maths = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter marks for science :");
            //science = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter marks for english :");
            //english = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter marks for socialscience :");
            //socialscience = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter marks for geography :");
            //geography = Convert.ToInt32(Console.ReadLine());

            //totalmarks= maths + science + english + socialscience + geography;
            //Console.WriteLine("Total marks is :"+totalmarks);

            //float percent = (totalmarks *100) /500;
            //Console.WriteLine("Percentage is :" +percent);

            //if (percent >= 80)
            //{
            //    Console.WriteLine("You are in distinction..");
            //}
            //else if(percent >=60 && percent <=79)
            //{
            //    Console.WriteLine("You are in first class..");
            //}
            //else
            //{
            //    Console.WriteLine("You passed the exam..");
            //}

            //70.Write a C# program to enter month number and print number of days in month using switch case
            //int month;
            //Console.WriteLine("enter months to get days :");
            //month = Convert.ToInt32(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Number of days are 31");
            //            break;

            //    case 2:
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Number of days are 30");
            //        break;
            //    default:
            //        Console.WriteLine("please enter correct month");
            //        break;
            //}

            // 71.Write a C# program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

            //int x, y;
            //Console.WriteLine("enter X coordinate :");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter Y coordinate :");
            //y = Convert.ToInt32(Console.ReadLine());

            //if( x >= 0 && y >=0)
            //{
            //    Console.WriteLine("It is a first quadrant");
            //}
            //else if(x < 0 && y >= 0)
            //{
            //    Console.WriteLine("It is a second quadrant");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("It is a third quadrant");
            //}
            //else
            //{
            //    Console.WriteLine("It is a forth quadrant");
            //}

            //72.	Write a C# program to determine eligibility for admission to a professional course based on the following criteria: 
            //Eligibility Criteria : 
            //Marks in Maths >= 65 and Marks in Phy >= 55 and Marks in Chem >= 50 and Total in all three subject >= 190 or Total in Maths and Physics >= 140

            //int maths, physics, chemistry, totalmarks=0, totalmathschemistry =0;
            //Console.WriteLine("enter marks for maths :");
            //maths = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter marks for physics :");
            //physics = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter marks for chemistry :");
            //chemistry = Convert.ToInt32(Console.ReadLine());
            //totalmarks = maths + physics + chemistry;
            //totalmathschemistry = maths + physics;

            //if(maths>=65 && physics>=55 && chemistry>=50)
            //{
            //    if(totalmarks >= 190 || totalmathschemistry>=140)
            //    {
            //        Console.WriteLine("You are eligible for an admission");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Not eligible for an admission");
            //}

            //74.Write a program in C# to read any digit (0-9) and display it in the word using switch case.

            //int num;
            //Console.WriteLine("enter number between 0-9:");
            //num = Convert.ToInt32(Console.ReadLine());

            //switch(num)
            //{
            //    case 0:
            //        Console.WriteLine("zero");
            //        break;
            //    case 1:
            //        Console.WriteLine("one");
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //    case 4:
            //        Console.WriteLine("Four");
            //        break;
            //    case 5:
            //        Console.WriteLine("Five");
            //        break;
            //    case 6:
            //        Console.WriteLine("Six");
            //        break;
            //    case 7:
            //        Console.WriteLine("Seven");
            //        break;
            //    case 8:
            //        Console.WriteLine("Eight");
            //        break;
            //    case 9:
            //        Console.WriteLine("Nine");
            //        break;
            //    default:
            //        Console.WriteLine("Please enter number between 0-9");
            //        break;
            //}

            //75.Write a C# program which computes the area of various geometrical shapes using a menu-driven approach
            //char ch;
            //do
            //{
            //    Console.WriteLine("*************** Welcome to area of various geometrical shapes **************");
            //    Console.WriteLine("1. square");
            //    Console.WriteLine("2. rectangle");
            //    Console.WriteLine("3. circle");
            //    Console.WriteLine("0.EXIT");
            //    Console.WriteLine("Please enter your choice");
            //    ch = Convert.ToChar(Console.ReadLine());
            //    switch (ch)
            //    {
            //        case '1':
            //            int squareside;
            //            Console.WriteLine("Enter side of the square to get the area");
            //            squareside = Convert.ToInt32(Console.ReadLine());
            //            AreaOfShapes areaOfShapes = new AreaOfShapes();
            //            int areaofsquare = areaOfShapes.getAreaOfSquare(squareside);
            //            Console.WriteLine("area of square is :"+areaofsquare);
            //            break;
            //        case '2':
            //            int length, width;
            //            Console.WriteLine("Enter length of the rectangle");
            //            length = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter width of the rectangle");
            //            width = Convert.ToInt32(Console.ReadLine());
            //            AreaOfShapes areaOfShapes1 = new AreaOfShapes();
            //            int areaofrectangle = areaOfShapes1.getAreaOfRectangle(length,width);
            //            Console.WriteLine("area of square is :" + areaofrectangle);
            //            break;
            //        case '3':
            //            int radius;
            //            Console.WriteLine("Enter radius of a circle");
            //            radius = Convert.ToInt32(Console.ReadLine());
            //            AreaOfShapes areaOfShapes2 = new AreaOfShapes();
            //            double areaofcircle = areaOfShapes2.getAreaOfCircle(radius);
            //            Console.WriteLine("area of circle is :"+ areaofcircle);
            //            break;
            //        case '0':
            //            Environment.Exit(0);
            //            break;
            //    }


            //} while (ch != 'y');

            //76.Write a C# Program to print Fibonacci Series

            //int num1 = 1, num2 = 1, sum = 0;
            //Console.WriteLine("Fibonnacci series is :");
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //while(sum <=20)
            //{
            //    sum = num1 + num2;
            //    Console.WriteLine(sum);
            //    num1 = num2;
            //    num2 = sum;
            //}

            //77.Write a C# Program to Find First N Fibonacci Numbers

            //int limit, count =0, num1=1,num2=1,sum=0;
            //Console.WriteLine("Enter how many numbers you want to see in the fibonacci series.");
            //limit = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //count = 2;
            //while(count < limit)
            //{
            //    sum = num1 + num2;
            //    Console.WriteLine(sum);
            //    count++;
            //    num1 = num2;
            //    num2 = sum;
            //}

            //78.Write a C# Program to Find Nth Fibonacci Number using Recursion

            //79.Write a C# Program to Find the Factorial of a Number
            //int num;
            //Console.WriteLine("enter the number to get the factoral :");
            //num = Convert.ToInt32(Console.ReadLine());
            //int fact = 1;
            //while(num >0)
            //{
            //    fact = fact * num;
            //    num--;
            //}

            //Console.WriteLine("the factorial of a number is :"+fact);

            //80.Write a C# Program to Find the Factorial of a Number using Recursion
            //int num;
            //Console.WriteLine("enter the number to get the factoral :");
            //num = Convert.ToInt32(Console.ReadLine());
            //FactorialUsingRecursion factorialUsingRecursion = new FactorialUsingRecursion();
            //int fact =factorialUsingRecursion.factorial(num);
            //Console.WriteLine("Factorail using recursion is :"+fact);

            //81.Write a C# Program to Check Whether a Given Number is Perfect Number
            //int num; int sum = 0;
            //Console.WriteLine("enter the number to check whether it is a perfect number or not :");
            //num = Convert.ToInt32(Console.ReadLine());
            //for (int i=1; i<= num/2;i++)
            //{
            //    if (num % i ==0)
            //    {
            //        sum += i;
            //    }
            //}
            //if (sum == num)
            //{
            //    Console.WriteLine("sum is :"+sum);
            //    Console.WriteLine("This is a perfect number");
            //}
            //else
            //{
            //    Console.WriteLine("This is not a perfect number");
            //}

            //82.Write a C# Program to Check Armstrong Number

            //int num,count =0 , sum=0, rem;
            //Console.WriteLine("Enter number to check whether it is a armstrong :");
            //num = Convert.ToInt32(Console.ReadLine());
            //int getnum= num;
            //int checknum = num;

            //while(getnum >0)
            //{
            //    int getnumrem = getnum % 10;
            //    count += 1;
            //    getnum = getnum / 10;
            //}
            //while(num >0)
            //{
            //    rem = num % 10;
            //    sum += (int)Math.Pow(rem, count);
            //    num = num / 10;
            //}

            //if (sum == checknum)
            //{
            //    Console.WriteLine("This is a armstrong number.");
            //}
            //else
            //{
            //    Console.WriteLine("This is not a armstrong number.");
            //}

            //83.Write a C# Program to Display Armstrong Number between Two Intervals

            int startlimit, endlimit, rem;
            Console.WriteLine("enter startlimit :");
            startlimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter startlimit :");
            endlimit = Convert.ToInt32(Console.ReadLine());
            for (int i = startlimit; i<=endlimit; i++)
            {
                int calc = i;
                int getnum = i;
                int checknum = i;
                int count = 0;
                int sum = 0;
                while (getnum > 0)
                {
                    int getnumrem = getnum % 10;
                    count += 1;
                    getnum = getnum / 10;
                }
                while (calc > 0)
                {
                    rem = calc % 10;
                    sum += (int)Math.Pow(rem, count);
                    calc = calc / 10;
                }
                if(sum == checknum)
                {
                    Console.WriteLine(checknum);
                }
            }
        }

    }
}