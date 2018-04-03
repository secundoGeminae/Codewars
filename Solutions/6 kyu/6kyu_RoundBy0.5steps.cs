using System;
public class Kata
{
  public static double Solution(double n)
  {
     return Math.Round(2 * n, MidpointRounding.AwayFromZero) / 2;
  }
}
