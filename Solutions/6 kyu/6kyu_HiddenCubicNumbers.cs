using System;
using System.Linq;
using System.Text.RegularExpressions; 
public class Cubes
{
  public static String isSumOfCubes(String s)
  {
    var myReg = Regex.Matches(s, @"\d{1,3}").Cast<Match>().Select(m => m.Value).ToArray();
    var t = myReg.Where(m => m.Select(x => (int)Math.Pow(int.Parse(x.ToString()), 3)).Sum() == int.Parse(m)).Select(c=>int.Parse(c)).ToArray();
    return t.Count()==0?"Unlucky":String.Join(" ",t) + " "+t.Sum()+" "+ "Lucky";
    }
}
