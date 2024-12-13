using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop06 World!");

           GoalManager goalManager = new GoalManager();

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Display Goals"); // Show goals.
            Console.WriteLine("2. Create New Goal"); // Add new goal.
            Console.WriteLine("3. Record Event"); // Mark goal as completed.
            Console.WriteLine("4. Display Score"); // Display the current score.
            Console.WriteLine("5. Save Goals"); // Save goals before exit.
            Console.WriteLine("6. Load Goals");  // Load goals into file.
            Console.WriteLine("7. Quit");

            Console.Write("Please select a choice(1 - 7) from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.DisplayGoals();
                    break;

                case "2":
                    CreateNewGoal(goalManager);
                    break;

                case "3":
                    goalManager.RecordEvent();
                    break;

                case "4":
                    goalManager.DisplayScore();
                    break;

                case "5":
                    goalManager.SaveGoals();
                    break;

                case "6":
                    goalManager.LoadGoals();
                    break;

                case "7":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine("The type of goal are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                goalManager.CreateGoal("simple");
                break;

            case "2":
                goalManager.CreateGoal("eternal");
                break;

            case "3":
                goalManager.CreateGoal("checklist");
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    
}