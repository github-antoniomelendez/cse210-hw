using System;
namespace Activities
{

public class BreathingActivity : Activity
{

    
    
    protected string _name = "Breathing Activity";
    protected string _description = "This activity will help you relax by " + 
                                    "walking you through breathing in and out slowly. " +
                                    "Clear your mind and focus on your breathing.";
    protected int _duration = 0;

    public void DisplayStartingMessage()
    {
        Console.WriteLine( $"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Get Ready...");
    }
    
    public void Breathing()
    {
        
        int BreathingTime = _duration ;
        if (BreathingTime < 1)
        {
            Console.WriteLine("Not enough time for the activity.");
        }
        else
        {
            for (int i = 0; i < BreathingTime; i++)
            {
                Console.WriteLine();
                Console.Write("Breath in...");

                for (int j = 4; j >= -1; j--)
                {
                    Console.Write(j + 1);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    
                }

                Console.WriteLine();
                Console.Write("Breath out...");
                
                for (int w = 4; w >= 0; w--)
                {
                    Console.Write(w + 1);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    
                }
            }
        }
    }
}
}