using System;
using System.Linq;
public class Kata
{
  public static bool Alphanumeric(string str)
  {
  return str==string.Empty? false:str.Where(x=> !char.IsLetterOrDigit(x)||x=='\n').Count()==0;
  }
}
