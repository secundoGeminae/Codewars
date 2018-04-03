using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> PascalsTriangle(int n) 
  {
     List<int> result = new List<int>();
     for (int i = 0; i < n; i++)
       {
          for (int c = 0; c <= i; c++)
            {
              result.Add((int)Math.Round((factorial(i) / (factorial(c) * factorial(i - c))),MidpointRounding.AwayFromZero));
            }
       }
       return result;
  }
  
   public static double factorial(int n)
        {
            double a = 1;
            for (int i = 1; i <= n; i++)
            {
                a *= i;
            }
            return a;

        }
} 
