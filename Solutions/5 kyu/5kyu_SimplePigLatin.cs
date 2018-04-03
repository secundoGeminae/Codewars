using System;
using System.Linq;

public class Kata
{
  public static string PigIt(string str)
  {
    return String.Join(" ",str.Split(' ').Select(c=>c.Substring(1)+c[0]+"ay"));
  }
}
