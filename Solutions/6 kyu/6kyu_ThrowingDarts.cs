using System;
using System.Linq;

public class Darts
{
  public static int ScoreThrows(double[] s)
  {
    int result = 0;
    result += s.All(x => x > 0 && x < 5) ? 100 : 0;
    result += s.Select(d => d > 10 ? 0 : d >= 5 && d <= 10 ? 5 : 10).Sum();
    return s.Length!=0?result:0;
  }
}
