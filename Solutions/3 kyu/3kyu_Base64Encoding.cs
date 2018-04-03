using System;
using System.Collections.Generic;
using System.Linq;
public static class Base64Utils
{
  public static List<char> base64 = new List<char> {'A','B','C','D','E','F','G','H','I','J','K', 'L', 'M', 'N', 'O', 'P', 'Q','R','S','T','U', 'V', 'W', 'X', 'Y', 'Z',
                                                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                                                '0','1','2','3','4','5','6','7','8','9','+','/'};
  
  public static string ToBase64(string s)
  {
     int count_sym = 0;
     string result = "";
     s=String.Join("",s.Select(c => Convert.ToString((int)c, 2).PadLeft(8,'0')));
     while (s.Length % 6 != 0)
       {
          count_sym++;
          s = s.PadRight(s.Length + 8, '0');
       }
     for (int i= 0; i <s.Length; i += 6)
        {
          result += base64.ElementAt(Convert.ToInt32(s.Substring(i, 6), 2));
        }
     return count_sym==0? result: result.Remove(result.Length - count_sym) + new string('=',count_sym);
  }

  public static string FromBase64(string s)
  {
      string result = "";
      s = String.Join("", s.Where(x=> base64.Contains(x)).Select(c => Convert.ToString(base64.IndexOf(c), 2).PadLeft(6, '0')));
      if(s.Length%8!=0)s = s.Remove(s.Length - s.Length % 8);
    
       for (int i = 0; i < s.Length; i += 8)
          {
             result += (char)Convert.ToInt32(s.Substring(i, 8), 2);
          }
       return result;
  }
}
