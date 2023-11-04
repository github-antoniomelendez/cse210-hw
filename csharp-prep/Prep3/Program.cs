using System;

class Program
{
    static void Main(string[] args)
    {
        // This is for when you chose the magic number

        /*Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }*/

        // This is for the program to chose a random number
        string keepPlaying = "yes";
        while (keepPlaying == "yes")
        { 
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int guessCount = 0;
            int guess = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount = guessCount + 1;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"It took you {guessCount} guesses to get the magic number!");
            Console.Write("Would you like to play again (yes/no)? ");
            keepPlaying = Console.ReadLine();
        }
        
        Console.Write("Thank you for playing ");
    }
}