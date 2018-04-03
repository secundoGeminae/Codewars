using System;
using System.Linq;

public class Kata
{
  public static bool ValidateString(string[] dictionary, string word)
  {
    dictionary = dictionary.OrderBy(x=>x).ToArray();
    for (int i = 0; i < dictionary.Length; i++)
     {
       if (word.Contains(dictionary[i]))
       {
         word = word.Replace(dictionary[i], "");
       }
     }   
    return word.Length==0;
  }
}
