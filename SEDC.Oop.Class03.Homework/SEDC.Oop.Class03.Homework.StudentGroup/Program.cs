using System;

namespace SEDC.Oop.Class03.Homework.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            //Make a new console application called StudentGroup
            //Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
            //Get a number from the console between 1 and 2 and print the students from that group in the console.
            //Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
            //Test Data:
            //Enter student group: (there are 1 and 2 )
            //1
            //Expected Output:
            //The Students in G1 are:
            //Zdravko
            //Petko
            //Stanko
            //Branko
            //Trajko

            string[] studentsG1 = new[] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
            string[] studentsG2 = new[] { "Miki", "Marko", "Filip", "Andrej", "Martin" };

            Console.WriteLine("Choose a number 1 or 2");
            string groupNumber = Console.ReadLine();
            bool isInputNumber = int.TryParse(groupNumber, out int number); 

            if(isInputNumber)
            {
                if(number == 1)
                {
                    foreach (string name in studentsG1) {
                        Console.WriteLine(name);
                    }
                }
                else if(number == 2)
                {
                    foreach(string name in studentsG2)
                    {
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    Console.WriteLine("You can enter only 1 or 2");
                }
            }
            else
            {
                Console.WriteLine("Please enter number input");
            }

            Console.ReadLine();
        }
    }
}
