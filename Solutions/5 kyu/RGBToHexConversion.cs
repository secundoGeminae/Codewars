using System;
using System.Linq;
public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
   int[] rgb = new int[] { r, g, b };
   return String.Join("",rgb.Select(x=>x<0?"00":x>255?"FF": 
   Convert.ToString(x, 16).ToUpper().Select(c=>c).Count()>1?
   Convert.ToString(x, 16).ToUpper(): "0"+Convert.ToString(x, 16).ToUpper()).ToArray());
  }
}
