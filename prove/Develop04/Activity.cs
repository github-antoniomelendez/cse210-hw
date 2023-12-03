using System;
namespace Activities
{

public class Activity
{

    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public void DisplayStartingMessage()
    {
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Get Ready...");
        

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
            
    }

    public void ShowCountDown(int second)
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    /*public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life" + 
                        "when you have shown strength and resilience." + 
                        "This will help you recognize the power you have and how you can use" + 
                        "it in other aspects of your life.";
        _duration = 50;

        // Set other values here that are unique to the Reflecting Activity
    }*/



    
}
}