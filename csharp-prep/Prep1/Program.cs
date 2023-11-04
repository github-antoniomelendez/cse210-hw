using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for their first name.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask user for their last name.
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Print name like in James Bond movies.
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}