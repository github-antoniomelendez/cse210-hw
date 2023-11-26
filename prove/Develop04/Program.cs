using System;
namespace Activities
{

class Program
{
    static void Main(string[] args)
    {
        
        int choice = 0;

        while (choice < 4)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity.");
            Console.WriteLine("2. Start Reflecting Activity.");
            Console.WriteLine("3. Start Listing Activity.");
            Console.WriteLine("4. Quit.");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                var BreathingObj = new BreathingActivity();
                BreathingObj.DisplayStartingMessage();
                BreathingObj.Breathing();
                BreathingObj.DisplayEndingMessage();
            }

            else if (choice == 2)
            {
                //start reflecting activity;
            }

            else if (choice == 3)
            {
                //start listing activity;
            }

            else if (choice == 4)
            {
                //quit;
            }


        }
    }
}
}