using System;
using System.Linq;
using System.Collections.Generic;
public class Deadfish
{
  public static int[] Parse(string data)
  {   
    int result = 0;
    List < int > seq = new List<int>();
    var commands = data.Select(x => x).ToArray();
    foreach (char c in commands)
      {
        switch (c)
        {
          case 'i': result++; break;
          case 'd': result--; break;
          case 's': result*=result; break;
          case 'o': seq.Add(result); break;
        }
      }
    return seq.ToArray();
  }
}
