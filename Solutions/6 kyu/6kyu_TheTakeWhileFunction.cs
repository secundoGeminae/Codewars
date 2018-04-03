using System.Linq;
using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] TakeWhile(int[] arr, Func<int,bool> pred)
  {
   return arr.TakeWhile(pred).ToArray();
  }
}
