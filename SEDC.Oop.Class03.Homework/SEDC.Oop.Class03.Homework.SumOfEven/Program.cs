using System;

namespace SEDC.Oop.Class03.Homework.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:

            //Test Data:
            //Enter integer no.1:
            //4
            //Enter integer no.1:
            //3
            //Enter integer no.1:
            //7
            //Enter integer no.1:
            //3
            //Enter integer no.1:
            //2
            //Enter integer no.1:
            //8
            //Expected Output:
            //The result is: 14


            string[] arrayOfNumbers = new string[6];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.WriteLine("Enter Number " + (i + 1));
                arrayOfNumbers[i] = Console.ReadLine();
            }

            int sum = 0;

            foreach (string element in arrayOfNumbers)
            {
                bool isInputValid = int.TryParse(element, out int numberParsed);

                if (numberParsed % 2 == 0)
                {
                    sum += numberParsed;
                }
            }
            Console.WriteLine("\nThe sum of even numbers in array is: " + sum);

            Console.ReadLine();
        }
    }
}
