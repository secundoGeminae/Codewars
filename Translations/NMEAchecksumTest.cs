namespace Solution {
  using NUnit.Framework;
  using System;
  using System.Linq;
  using System.Text.RegularExpressions;

[TestFixture]
  public class SolutionTest
  {
    Random rnd = new Random();
    string[] words = new string[]{"GGA","GLL","GSA","GSV","RMC","VTG"};
    public string GenData()
    {
      return $"$GP{words[rnd.Next(0,5)]},"+$"{rnd.Next(0,23)}".PadLeft(2,'0')+$"{rnd.Next(00,59)}".PadLeft(2,'0')+$"{rnd.Next(00,59)}".PadLeft(2,'0')+$".001,{rnd.Next(-84,84)}.{rnd.Next(000001,999999)},N,{rnd.Next(-179,+179)}.{rnd.Next(00001,999999)},E,{rnd.Next(1,2)},{rnd.Next(1,9)},1.0,0{rnd.Next(100,1999)}.1,M,{rnd.Next(-30,40)},M,,";
    }
     public string GenCorrect()
    {
      var s = GenData();
      return $"{s}*{XoR(s)}\r\n";
    }
    public string GenRandom()
    {
      var s = GenData();
      return $"{s}*{Convert.ToString(rnd.Next(1,128),16).ToUpper()}\r\n";
    }
    
    public static string XoR(string s)
  {
      var str = s.Replace("$", "");
      int c=0;
      for (int i = 0; i < str.Length; i++)
       {
         c ^= str[i];
       }
     return Convert.ToString(c, 16).ToUpper();
  }
  
  public static bool Check(string s)
  {
      return Convert.ToString(Regex.Match(s, @"\$(.+)\*").Value.Trim(new char[] { '$', '*' }).Select(x => x).Aggregate(0, (acc, x) => acc ^ x), 16).ToUpper() == Regex.Match(s, @"\*[a-z0-9]+", RegexOptions.IgnoreCase).Value.TrimStart('*').ToString().ToUpper();
  }
    [Test]
    [Description("Some valid strings")]
    public void Test1()
    {
      Assert.AreEqual(true, Kata.CheckSum("$GPAAM,A,A,0.10,N,WPTNME*32\r\n"));
      Assert.AreEqual(true, Kata.CheckSum("$GPRMC,152226.580,A,37.659,N,54.216,E,0.57,0.17,140924,,*3A\r\n"));
      Assert.AreEqual(true, Kata.CheckSum("$GPGSV,3,2,12,04,31,054,00,06,29,220,29,01,28,302,25,17,26,133,00*74\r\n"));
    }
    
    [Test]
    [Description("Some invalid strings")]
    public void Test2()
    {
      Assert.AreEqual(false, Kata.CheckSum("$GPRMC,104427.591,A,5920.7009,N,01803.2938,E,0.146345,320.93,141204,,*93\r\n"));
      Assert.AreEqual(false, Kata.CheckSum("$GPGSA,A,3,05,24,17,30,02,,,,,,,,5.6,3.3,4.5*T4\r\n"));
      Assert.AreEqual(false, Kata.CheckSum("$GPRMC,104427.591,A,5920.7009,N,01803.2938,E,0.146345,320.93,141204,,*0808\r\n"));
      
    }
    [Test]
    [Description("Random tests")]
    public void TestRandom()
    {
   for(int i=0;i<100;i++)
      {
      string s = rnd.Next(0,9)<5?GenCorrect():GenRandom();
      Console.WriteLine($"Testing for: {s}");
      Assert.AreEqual(Check(s), Kata.CheckSum(s));
      
      }
    }
  }
}
