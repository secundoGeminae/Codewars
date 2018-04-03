using System.Net;
using System.Text.RegularExpressions;
namespace Solution
  {
  class Kata
    {
      public static bool is_valid_IP(string IpAddres)
      {
           IPAddress ipAdr;
           return IPAddress.TryParse(IpAddres, out ipAdr)&&
           Regex.IsMatch(IpAddres, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
             
      }
    }
  }
