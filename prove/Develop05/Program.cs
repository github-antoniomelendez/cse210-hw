using System;
using goals;

namespace goals
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice < 6)
            {
                Console.WriteLine();
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("1. Create New Goal.");
                Console.WriteLine("2. List Goals.");
                Console.WriteLine("3. Save Goals.");
                Console.WriteLine("4. Load Goals.");
                Console.WriteLine("5. Record Event.");
                Console.WriteLine("6. Quit.");
                Console.Write("Select a choice from the menu: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    while(choice <5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("The types of goals are: ");
                        Console.WriteLine("1. Simple Goal.");
                        Console.WriteLine("2. Eternal Goal.");
                        Console.WriteLine("3. Checklist Goal.");
                        Console.WriteLine("4. Academic Goal.");
                        Console.Write("Which type of goal would you like to create? ");
                        choice = int.Parse(Console.ReadLine());

                        if (choice == 1)
                        {
                            Console.Write("What is the name of your goal? ");
                            string _shortName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string _description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            string _points = Console.ReadLine();
                        }

                        else if (choice == 2)
                        {
                            Console.Write("What is the name of your goal? ");
                            string _shortName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string _description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            string _points = Console.ReadLine();
                        }

                        else if (choice == 3)
                        {
                            Console.Write("What is the name of your goal? ");
                            string _shortName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string _description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            string _points = Console.ReadLine();
                        }

                        else if (choice == 4)
                        {
                            Console.Write("What is the name of your goal? ");
                            string _shortName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string _description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            string _points = Console.ReadLine();
                        }

                    }
                    

                }

                else if (choice == 2)
                {
                    //list goals
                }

                else if (choice == 3)
                {
                    //save goals
                }

                else if (choice == 4)
                {
                    //LoadGoals();
                }

                else if (choice == 5)
                {
                    //RecordEvent();
                }

                else if (choice == 6)
                {
                    //quit;
                }
            }

            /*ChecklistGoal cgoal = new ChecklistGoal();
            cgoal.SetAmountCompleted(1);
            cgoal.SetTarget(3);
            cgoal.SetBonus(100);
            Console.WriteLine("testing");

            Console.WriteLine($"{Start()}");
            List<Goal> goals = new List<Goal>();
            goals.Add(cgoal);*/


        }
    }
}