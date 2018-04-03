using System;
public class Kata
{
  public static double CalculateHypotenuse(double a, double b)
  {
    if (a < 0 && b < 0)
    throw new ArgumentException();
    return Math.Round(Math.Sqrt(a * a + b * b),3);
  }
}
