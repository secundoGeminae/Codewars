using System;
public class Kata
{
  public static string UInt32ToIP(uint ip)
  {
    string Bin = Convert.ToString(ip, 2);
            string result = "";
            if (Bin.Length % 8 != 0)Bin= Bin.PadLeft(32,'0');
            for (int i = 0; i < Bin.Length; i += 8)
            {
                result += Convert.ToInt32(Bin.Substring(i, 8), 2)+".";
            }
            return result.TrimEnd('.');
  }
}
