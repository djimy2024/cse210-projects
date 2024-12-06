using System;

class Program
{
    static void Main(string[] args)
    {
   
        bool running = true;
        
        // Activity menu
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing Activity");
            Console.WriteLine(" 2. Start reflecting Activity");
            Console.WriteLine(" 3. Start listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            
            Activity activity = null;
            
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
                if (activity is BreathingActivity breathingActivity)
            {
                breathingActivity.Run();
            }

                else if (activity is ReflectingActivity reflectionActivity)
            {
                reflectionActivity.Run();
            }
                else if (activity is ListingActivity listingActivity)
            {
                listingActivity.Run();
            }
        }
        
        Console.WriteLine("Goodbye!");
    }
}

    
