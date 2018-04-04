using System;
using System.Linq;
using System.Collections;
using System.Text;
public class Kata
{
  public static string Encrypt(string text, int n)
  {
   if(text==null) return null;
   return n<=0? text:Encrypt(String.Concat(text.Where((x,i)=>i%2!=0).Concat(text.Where((x,i)=>i%2==0))),n-1);
  }
  
  public static string Decrypt(string text, int n)
  {    
     if(text==null) return null;
     while (n > 0)
     {
      string s1 = text.Substring(0, text.Length / 2);
      string s2 = text.Substring(s1.Length, text.Length - s1.Length);
      text = "";
        for (int i = 0; i < s2.Length; i++)
        {
          if (s1.Length > i)
           text+=$"{s2[i]}{s1[i]}";
          else
           text+=s2[i];
        }
        n --;
     }
     return text;
  }

}
