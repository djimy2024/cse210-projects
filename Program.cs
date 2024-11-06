using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output a welcome message to the console
            Console.WriteLine("Hello, World!");

            // Prompt the user for their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Greet the user by their name
            Console.WriteLine($"Hello, {name}!");

            // Wait for the user to press a key before closing
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
