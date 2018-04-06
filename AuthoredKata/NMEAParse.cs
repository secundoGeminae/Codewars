using System;
using System.Linq;
public static class Kata
{
  public static string GetCoord(string data)
        {
            var nav_data = data.Split('\n').Where(x => x.Contains("$GPGGA")).SingleOrDefault();
            if (nav_data != null)
            {
                var temp = nav_data.Split(',');
                string time = temp[1];
                decimal lat = Convert.ToDecimal(temp[2]);
                decimal longt = Convert.ToDecimal(temp[4]);
                Console.WriteLine($"{time.Substring(0, 2)}:{time.Substring(2, 2)}:{time.Substring(4, 2)} {ConvertCoord(lat)} {ConvertCoord(longt)}");
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
}
