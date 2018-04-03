using System;
using System.Linq;
using System.Text.RegularExpressions;

class Rainfall 
{
    public static double Mean(string town, string strng) 
    {
      string t = String.Concat(strng.Split('\n').Where(x => Regex.IsMatch(x, $"{town}:")));
      return t!=String.Empty? t.Split(',').Select(s => Convert.ToDouble(Regex.Match(s, @"\d+\.\d").Value)).ToArray().Average():-1;
    }
    
    public static double Variance(string town, string strng) 
    {
     string t = String.Concat(strng.Split('\n').Where(x => Regex.IsMatch(x, $"{town}:")));
     return t!=String.Empty?t.Split(',').Select(s => Convert.ToDouble(Regex.Match(s, @"\d+\.\d").Value)).Select(d=>Math.Pow(d-Mean(town,strng),2)).Average():-1;
    }
}
