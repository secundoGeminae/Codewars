using System;
using System.Collections.Generic;
using System.Linq;

public class Kata 
{
  public static int GetNumber(string str) 
  {
    List<int> temp = new List<int>();
    for (int i=0;i<str.Length-4;i++)
       {
          temp.Add(Convert.ToInt32(str.Substring(i,5)));
       }
            
       return temp.Max();
  }
}
