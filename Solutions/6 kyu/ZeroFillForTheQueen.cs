using System;
using System.Linq;

public static class Kata
{
  public static string ZeroFill(int number, int size)
  {
    return size < number.ToString().Select(x => x).ToArray().Count() ? 
    Math.Abs(number).ToString() : 
    Math.Abs(number).ToString().PadLeft(size,'0');
  }
}
