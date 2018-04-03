using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public static string ToCamelCase(string str)
  {
  var temp = Regex.Replace(str, @"\-|_", " ").Split(' ');
            
            for (int i = 1; i < temp.Length; i++)
            {
                temp[i] = temp[i].Substring(0,1).ToUpper() + temp[i].Substring(1,temp[i].Length-1);
            }
            return String.Join("", temp);
  }
}
