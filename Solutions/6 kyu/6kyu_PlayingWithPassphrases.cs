using System;
using System.Linq;

public class PlayPass {
    
	public static string playPass(string s, int n) 
  {
	return String.Join("",s.Select(x => x).Select(x => char.IsLetter(x) ? x + n > 90 ? (char)(x + n - 26) : 
  (char)(x + n) : x).Select(x => char.IsDigit(x) ? (9 - int.Parse(x.ToString())).ToString() :
  x.ToString()).ToArray().Select((x, i) => i % 2 == 1 ? x.ToLower() : x.ToUpper()).Reverse());
	}
}
