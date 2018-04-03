using System;
using System.Linq;
public static class Kata
{
  public static string FormatWords(string[] words)
  {
  if (words==null||words.Length==0) return "";
  words = words.Where(x=>x!="").ToArray();
  return String.Join(" ",words.Select((x,i)=>i==words.Length-2?x+" and":i==words.Length-1?x:x+","));
  }
}
