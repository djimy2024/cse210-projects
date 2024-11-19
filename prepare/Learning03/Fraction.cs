using System;

public class Fraction
{
  private int numerator;
  private int denominator;

  public Fraction()  // No parameters.
  {
    numerator = 1;
    denominator = 1;
  }

  public Fraction(int top) // One parameters.
  {
    numerator = top;
    denominator = 1;
  }

  public Fraction(int top, int bottom) // With parameters.
  {
    numerator = top;
    denominator = bottom;
  }

  public int GetNumerator()  // Getter numerator.
  {
    return numerator;
  }

  public void SetNumerator(int value) // Setter Numerator.
  {
    numerator = value;
  }
  public int GetDenominator()  // Getter denominator.
  {
    return denominator;
  }


  public void SetDenominator(int value)  //Setter denominato
  {
    if (value != 0)  // Ensure denominator is not zero.
    {
        denominator = value;
    }

    else
    {
        Console.WriteLine("Denominator cannot be zero.");
    }
  }

  public string GetFractionString()
  {
    return numerator + "/" + denominator; //Return the fraction as a string.
  }

  public double GetDecimalValue()
  {
    return (double) numerator / denominator; // Return the decimal value of the fraction.
  }
  









}