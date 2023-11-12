using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        //make loop for the menu
        int choice = 0;

        while (choice < 5)
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write.");
            Console.WriteLine("2. Display.");
            Console.WriteLine("3. Load.");
            Console.WriteLine("4. Save.");
            Console.WriteLine("5. Quit.");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                /*PromptGenerator prompt1 = new PromptGenerator();
                prompt1._prompts = "How was your day today?";

                PromptGenerator prompt2 = new PromptGenerator();
                prompt2._prompts = "What valuable lesson did you learn today?";

                PromptGenerator prompt3 = new PromptGenerator();
                prompt3._prompts = "Describe you best experience today.";

                PromptGenerator prompt4 = new PromptGenerator();
                prompt4._prompts = "What feelings did you have today?";

                PromptGenerator prompt5 = new PromptGenerator();
                prompt5._prompts = "Did you meet anyone interesting today?";

                PromptGenerator prompt6 = new PromptGenerator();
                prompt6._prompts = "What would you like to write in your journal?";

                List<PromptGenerator> prompts = new List<PromptGenerator>();
                prompts.Add(prompt1);
                prompts.Add(prompt2);
                prompts.Add(prompt3);
                prompts.Add(prompt4);
                prompts.Add(prompt5);
                prompts.Add(prompt6);

                foreach (PromptGenerator item in prompts)
                
                {
                    Console.WriteLine(item._prompts);
                }*/
                

            }
            else if (choice == 2)
            {
                Console.WriteLine("Testing");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Testing");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Testing");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Come back soon!");
            }
            
        }
        

        
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();
    }
}
