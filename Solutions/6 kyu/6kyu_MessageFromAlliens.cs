using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class Kata {
  public static string Decode(string m) 
  {
    Dictionary<char, string> aliensABC = new Dictionary<char, string>();
    aliensABC.Add('w', @"\/\/");aliensABC.Add('a',"/\\");aliensABC.Add('b', "]3");
    aliensABC.Add('z', "~/_");aliensABC.Add('d', "|)");aliensABC.Add('e', "[-");
    aliensABC.Add('f', "/=");aliensABC.Add('h', "|-|");aliensABC.Add('x', "><");
    aliensABC.Add('k', "/<");aliensABC.Add('q', "()_");aliensABC.Add('m', @"|\/|");
    aliensABC.Add('g', @"(_,");aliensABC.Add('v', @"\/");aliensABC.Add('j', "_T");
    aliensABC.Add('n', "|\\|");aliensABC.Add('o', "()");aliensABC.Add('p', "|^");
    aliensABC.Add('r', "/?");aliensABC.Add('s', "_\\~");aliensABC.Add('t', "~|~");
    aliensABC.Add('u', "|_|");aliensABC.Add('y', "`/");aliensABC.Add(' ', "__");            
    aliensABC.Add('l', "|_");aliensABC.Add('i', "|");aliensABC.Add('c', "(");
            
      foreach (KeyValuePair<char,string> p in aliensABC)
      {
        m= Regex.Replace(m, Regex.Escape(p.Value), p.Key.ToString());
      }

    return String.Concat(m.Where(x => char.IsLetter(x)|x==' ').Reverse());
    
  }
}
