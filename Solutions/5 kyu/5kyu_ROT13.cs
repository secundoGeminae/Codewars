using System;
using System.Linq;
public class Kata
{
  public static string Rot13(string input)
  {
     var s1 = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
     var s2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
     return string.Join("", input.Select(x => char.IsLetter(x)?s1[s2.IndexOf(x)]:x));
  }
}
