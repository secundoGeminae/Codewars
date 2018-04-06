using System;
using System.Linq;
using System.Text.RegularExpressions;
public static class Kata
{
  public static bool CheckSum(string s)
  {
    var  input_value = Regex.Match(s, @"\*[a-zA-Z0-9]+").Value.TrimStart('*').ToString().ToUpper();
    var  calc_value  = Convert.ToString(Regex.Match(s, @"\$(.+)\*").Value.Trim(new char[] { '$', '*' })
    .Select(x => x).Aggregate(0, (acc, x) => acc ^ x), 16).ToUpper();
    return calc_value == input_value;
  }
}
