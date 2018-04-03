using System.Linq;
using System;
using System.Collections.Generic;
public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    if(s==string.Empty) return string.Empty;
    var result = new Dictionary<char, int>();
    foreach (char c in s)
      {
       if (!result.ContainsKey(c))
        {
          result.Add(c, s.Where(x => x == char.ToLower(c) || x == char.ToUpper(c)).Count());
        }
      }
    foreach (char c in s)
      {
        if (result[c]==1)
          {
            return c.ToString();
          }
      }
    return s.Length==1? s:string.Empty;
   }
}
