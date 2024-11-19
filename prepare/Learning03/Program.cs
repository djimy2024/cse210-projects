using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction (); // Using default constructor.
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");


        // Using the constructor with one parameters.
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");

        // Using the constructor with two parameters.
        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        // Using different values.
        fraction3.SetNumerator(3);
        fraction3.SetDenominator(4);
        Console.WriteLine($"Modified Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        // Example of setting an invalid denominator (0)
        fraction3.SetDenominator(0); // Should give an error message
    }
}