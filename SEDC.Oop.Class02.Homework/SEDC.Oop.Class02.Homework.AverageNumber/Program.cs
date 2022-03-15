using System;

namespace SEDC.Oop.Class02.Homework.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30
            //Expected Output:
            //The average of 10, 15, 20 and 30 is: 18

            Console.WriteLine("Enter the first number:");
            string firstInput = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string secondInput = Console.ReadLine();

            Console.WriteLine("Enter the third number:");
            string thirdInput = Console.ReadLine();

            Console.WriteLine("Enter the fourth number:");
            string fourthInput = Console.ReadLine();

            bool isFirstInputValid = int.TryParse(firstInput, out int firstInputToNumber);
            bool isSecondInputValid = int.TryParse(secondInput, out int secondInputToNumber);
            bool isThirdInputValid = int.TryParse(thirdInput, out int thirdInputToNumber);
            bool isFourthInputValid = int.TryParse(fourthInput, out int fourthInputToNumber);

            if (isFirstInputValid && isSecondInputValid && isThirdInputValid && isFourthInputValid)
            {
                int averageNumber = (firstInputToNumber + secondInputToNumber + thirdInputToNumber + fourthInputToNumber) / 4;

                Console.WriteLine("The average of " + firstInputToNumber + ", " + secondInputToNumber + ", " + thirdInputToNumber + " and " + fourthInputToNumber + " is: " + averageNumber);
            }
            else
            {
                Console.WriteLine("Please enter number as input");
            }

            Console.ReadLine();
        }
    }
}
