using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        // Create a reference for the scripture (example, John 3:16)
        Reference reference = new Reference("John", 3,16);

        // Create a scripture with the reference and the text
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only Son.");

        // Show the original scripture
        Console.WriteLine("Original Scripture:");
        Console.WriteLine(scripture.GetDisplayText());
       

        // Start the loop to allow the user to progressively hide words
        while (true)
        {
            Console.WriteLine("\nPress Enter to hide a few words or type 'quit' to exit.");

            string input = Console.ReadLine().Trim().ToLower();

            // Exit the loop if the user types 'quit'
            if (input == "quit")
            {
                break;
            }

            // Hide 3 random words each time the user presses Enter
            scripture.HideRandomWords(3);
            // Clear the console and display the updated scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
           
        }
    }
}

    
