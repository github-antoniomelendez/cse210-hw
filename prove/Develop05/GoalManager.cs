using System;
using System.IO;

namespace goals
{
    public abstract class GoalManager : Goal
    {
        protected int _score = 0;
        protected List<Goal> _goals = new List<Goal>();

        public int GetScore()
        {
            return _score;
        }

        public void SetScore(int score)
        {
            _score = score;
        }

        public void Start()
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
                    //create goal
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
                    LoadGoals();
                }

                else if (choice == 5)
                {
                    RecordEvent();
                }

                else if (choice == 6)
                {
                    //quit;
                }
            }
        }
        public void DisplayPlayerInfo()
        {
            
        }
        public void ListGoalNames()
        {
            
        }
        public void ListGoalDetails()
        {
            
        }
        public void CreateGoal()
        {
            
        }
        public override int RecordEvent()
        {
            string filename = "goals.txt";
            using(StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine("");
                int goal = 1;
                return goal;
            }
        }
        public void SaveGoals()
        {
            
        }
        public void LoadGoals()
        {
            string filename = "goals.txt";
            string [] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string goal = parts[0];
                string score = parts[1];
                
            }
        }
        
    }

}