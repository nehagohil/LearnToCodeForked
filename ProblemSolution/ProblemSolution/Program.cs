namespace ProblemSolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.Write a C# Sharp program to print Hello and your name in a separate line.
            //HelloWorld helloWorld = new HelloWorld();
            //helloWorld.Print();

            //2.Write a C# Sharp program to print the sum of two numbers.
            int num1, num2, result;
            Console.WriteLine("Please enter number 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            SumOfTwoNumbers sumOfTwoNumbers = new SumOfTwoNumbers();
            result = sumOfTwoNumbers.sum(num1 , num2);
            Console.WriteLine("Sum of two numbers is : " +result);

        }
    }
}