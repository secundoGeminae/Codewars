using System;
using System.Linq;

public class Kata
{
  public static string StringLetterCount(string str)
  {
    return String.Join("",str.ToLower().Where(a => char.IsLetter(a)).OrderBy(x => x)
    .Select(ch =>str.ToLower().Count(x=>ch==x)+ ch.ToString()).Distinct().ToArray());
  }
}
