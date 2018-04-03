using System;
using System.Linq;

public static class Kata
{
  public static string Encrypt(string text, int rule)
  {  
    return String.Join("", text.Select(c => c + rule>255?(char)((c + rule)%256): (char)(c + rule)));
  }
}
