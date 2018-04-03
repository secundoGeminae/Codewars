using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    return words.Where(s => String.Join("",s.OrderBy(c => c))== String.Join("",word.OrderBy(c=>c))).ToList();
  }
}
