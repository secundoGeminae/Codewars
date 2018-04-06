namespace Solution {
  using NUnit.Framework;
  using NUnit.Core;
  using System;
  using System.Linq;
  
  [TestFixture]
  public class SolutionTest
  {
    public static string Check(string data)
        {
            var t = data.Split('\n').Where(x => x.Contains("$GPGGA")).SingleOrDefault();
            if (t != null)
            {
                var et = t.Split(',');
                string time = et[1];
                decimal lat = Convert.ToDecimal(et[2]);
                decimal longt = Convert.ToDecimal(et[4]);
                return $"{time.Substring(0, 2)}:{time.Substring(2, 2)}:{time.Substring(4, 2)} {ConvertCoord(lat)} {ConvertCoord(longt)}";
            }
            return "";
        }

        public static string ConvertCoord(decimal x)
        {
            int degrees = (int)(x);
            decimal minutes = Math.Abs((x - degrees) * 60);
            string seconds = String.Format(Math.Abs(Math.Floor((minutes - (int)(minutes)) * 60)).ToString(), "0");
            
            return $"{degrees}°{(int)minutes}′{seconds}″";
        }
    [Test]
    public void Test1()
    {
      Assert.AreEqual("17:03:12 38°50′57″ -77°2′29″", Kata.GetCoord(
      "$GPGGA,170312.000,38.849361,N,-77.041429,W,1,13,0.8,0136.6,M,-26.5,M,,*56\n"+
      "$GPGLL,3700.14598,N,12159.35025,W,170312.000,A,A*47\n"+
      "$GPRMC,170313.000,A,3700.13145,N,12159.34546,W,53.9,166.1,030113,,,A*4C"));
    }
           
    [Test]
    public void Test2()
    {
      Assert.AreEqual("17:01:54 33°56′36″ -118°24′16″", Kata.GetCoord(
      "$GPGLL,3700.32611,N,12200.53884,W,170152.000,A,A*4B\n"+
      "$GPZDA,170152.00,03,01,2013,00,00*64\n"+
      "$GPRMC,170154.020,A,3700.35010,N,12200.51473,W,54.1,40.6,030113,,,A*7C\n"+
      "$GPGGA,170154.020,33.943600,N,-118.404557,W,1,09,1.0,0137.1,M,-26.5,M,,*5C" ));
    }
    [Test]
    public void Test4()
        {
            
            string input = "GPGGA,170312.000,3700.14598,N,12159.35025,W,1,13,0.8,0136.6,M,-26.5,M,,*56\n"+
            "$GPGLL,3700.14598,N,12159.35025,W,170312.000,A,A*47";
            string expected = String.Empty;
            string actual = Kata.GetCoord(input);

            //asert
            Assert.AreEqual(expected, actual);
        }
    [Test]
    public void Test3()
    {
      Assert.AreEqual("01:01:01 35°40′52″ 139°45′55″", Kata.GetCoord(    
      "$GPGGA,010101.001,35.681239,N,139.765293,E,1,09,1.0,0137.1,M,-26.5,M,,*5C" ));
    }
    
    [Test]    
    public void TestRandom()
    {
    Random rnd = new Random();
      for(int i=0;i<100;i++)
      {
      Console.WriteLine("test"+(i+1));
      string s = "$GPGGA,"+$"{rnd.Next(0,23)}".PadLeft(2,'0')+$"{rnd.Next(00,59)}".PadLeft(2,'0')+$"{rnd.Next(00,59)}".PadLeft(2,'0')+$".001,{rnd.Next(-84,84)}.{rnd.Next(000001,999999)},N,{rnd.Next(-179,+179)}.{rnd.Next(00001,999999)},E,{rnd.Next(1,2)},{rnd.Next(1,9)},1.0,0{rnd.Next(100,1999)}.1,M,{rnd.Next(-30,40)},M";
      Console.WriteLine(s);
      Assert.AreEqual(Check(s), Kata.GetCoord(s));
      }
      
    }
    
    
  }
  
 
  
}
