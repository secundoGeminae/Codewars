using System;
using System.Linq;
public static class Kata
{
  public static int GetNum(long n)
  {
   return n.ToString().Select(x => int.Parse(x.ToString())).Select(c=> new int[] { 0, 6, 9 }.Contains(c) ? 1 : c == 8 ? 2 : 0).Sum();
  }
}
