using System;

namespace Exercise1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            int favoriteNumber;

            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();

            Console.Write("What is your age? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your favorite number? ");
            favoriteNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, " + firstName + " " + lastName +
                "! You are " + age + " years old and your favorite number is " + favoriteNumber + ".");
        }
    }
}