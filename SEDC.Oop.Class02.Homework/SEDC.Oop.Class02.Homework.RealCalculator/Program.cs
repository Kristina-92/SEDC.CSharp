using System;

namespace SEDC.Oop.Class02.Homework.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the Operation: +
            //Expected Output:
            //The result is: 25


            Console.WriteLine("Enter first number: ");
            string inputOne = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            string inputTwo = Console.ReadLine();

            Console.WriteLine("Enter operator: ");
            string inputOperator = Console.ReadLine();

            bool isInputOneValid = int.TryParse(inputOne, out int inputOneToNumber);
            bool isInputTwoValid = int.TryParse(inputTwo, out int inputTwoToNumber);
            bool isInputOperatorValid = char.TryParse(inputOperator, out char inputOperatorToChar);

            if (isInputOneValid && isInputTwoValid && isInputOperatorValid)
            {

                if (inputOperatorToChar == '+')
                {
                    Console.WriteLine("The result is: " + (inputOneToNumber + inputTwoToNumber));
                }
                else if (inputOperatorToChar == '-')
                {
                    Console.WriteLine("The result is: " + (inputOneToNumber - inputTwoToNumber));
                }
                else if (inputOperatorToChar == '*')
                {
                    Console.WriteLine("The result is: " + (inputOneToNumber * inputTwoToNumber));

                }
                else if (inputOperatorToChar == '/')
                {
                    Console.WriteLine("The result is: " + (inputOneToNumber / inputTwoToNumber));

                }
                else
                {
                    Console.WriteLine("Please enter valid operator");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid input");
            }
            Console.ReadLine();
        }
    }
}
