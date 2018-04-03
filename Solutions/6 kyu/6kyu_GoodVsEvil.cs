using System;
using System.Linq;

public class Kata
{
  public static string GoodVsEvil(string good, string evil)
  {
    int goodSideScore = new int[] { 1, 2, 3, 3, 4, 10 }.Select((x, i) => x * int.Parse(good.Split(' ')[i])).Sum();
    int evilSideScore = new int[] { 1, 2, 2, 2, 3, 5, 10 }.Select((z, i) => z * int.Parse(evil.Split(' ')[i])).Sum();
    return goodSideScore > evilSideScore ? "Battle Result: Good triumphs over Evil" :
    goodSideScore < evilSideScore ? "Battle Result: Evil eradicates all trace of Good" :
    "Battle Result: No victor on this battle field";
  }
}
