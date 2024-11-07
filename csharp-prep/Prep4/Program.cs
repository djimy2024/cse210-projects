using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        // Empty list to stoke the numbers.
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;

        do 
        {
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
       
        if (number != 0)
        {
            numbers.Add(number);
        }
      } while (number != 0);

      if (numbers.Count > 0)
      {
        int sum = 0;
        foreach (int N in numbers)
        {
            // Find the sum.
            sum += N;
        }
        // Find the average.
        double average = (double) sum / numbers.Count;
        int max = numbers[0];
        foreach (int N in numbers)
        {
            if (N > max)
            { 
                // Find the max.
                max = N;
            }
        }
        // Display the sum, average and the max.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        
      }
      else
      {
        // Display an error mesage in case user enter only 0.
        Console.WriteLine("The list has no number.");
      }
    }
}