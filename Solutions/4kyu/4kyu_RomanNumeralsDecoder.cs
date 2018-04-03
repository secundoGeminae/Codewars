using System;
using System.Linq;
using System.Collections.Generic;

public class RomanDecode
{
	public static int Solution(string n)
	{
	   Dictionary<int, string> seq = new Dictionary<int, string>
        { { 1000, "M" },  { 900, "CM" },  { 500, "D" },  { 400, "CD" },  { 100, "C" },
                          { 90 , "XC" },  { 50 , "L" },  { 40 , "XL" },  { 10 , "X" },
                          { 9  , "IX" },  { 5  , "V" },  { 4  , "IV" },  { 1  , "I" } };
     return n.Length == 0 ? 0 : seq.Where(x => n.StartsWith(x.Value)).Select(x => x.Key + Solution(n.Substring(x.Value.Length))).FirstOrDefault();
	}
}
