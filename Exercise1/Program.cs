using System;

namespace Exercise1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string firstName; //declares firstName variable
            string lastName; //declares lastName variable
            int age; //declares age variable
            int favoriteNumber; //declares favoriteNumber variable

            Console.Write("What is your first name? "); //prompts the user for input
            firstName = Console.ReadLine(); //initializes firstName variable with user input

            Console.Write("What is your last name? "); //prompts the user for input
            lastName = Console.ReadLine(); //initializes lastName variable with user input

            Console.Write("What is your age? "); //prompts the user for input
            age = Convert.ToInt32(Console.ReadLine()); //converts and initializes user input into age variable

            Console.Write("What is your favorite number? "); //prompts the user for input
            favoriteNumber = Convert.ToInt32(Console.ReadLine()); //converts and initializes user input into favoriteNumber variable

            Console.WriteLine("Hello, " + firstName + " " + lastName +
                "! You are " + age + " years old and your favorite number is " + favoriteNumber + "."); //outputs combined variables into statement
        }
    }
}