using System;

namespace SEDC.Oop.Class02.Homework.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

            //Test Data:
            //Input the First Number: 5
            //Input the Second Number: 8
            //Expected Output:
            //After Swapping:
            //First Number: 8
            //Second Number: 5

            Console.WriteLine("Input the first number:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Input the second number:");
            string secondNumber = Console.ReadLine();

            bool isValidFirstNumber = int.TryParse(firstNumber, out int parsedFirstNumber);
            bool isValidSecondNumber = int.TryParse(secondNumber, out int parsedSecondNumber);

            if (isValidFirstNumber && isValidSecondNumber)
            {
                Console.WriteLine("\nThe first number input is: " + parsedFirstNumber + "\nThe second number input is: " + parsedSecondNumber);

                int temp = parsedFirstNumber;
                parsedFirstNumber = parsedSecondNumber;
                parsedSecondNumber = temp;

                Console.WriteLine("\nAfter swapping:");
                Console.WriteLine("\nFirst number is: " + parsedFirstNumber);
                Console.WriteLine("Second number is: " + parsedSecondNumber);
            }
            else
            {
                Console.WriteLine("Please enter valid input");
            }

            Console.ReadLine();
        }
    }
}
