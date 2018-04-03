using System;
using System.Linq;
public class Kata
{
  public static string FormatTime(int hour)
  {
    int count = hour.ToString().Select(x => x).Count();
            if (count < 3 || count > 4)
            {
                throw new ArgumentException();
            }
            var time = hour.ToString().Select(x => x).ToArray();
            return count==3?String.Format("{0}:{1}{2}",time[0],time[1],time[2])
            : String.Format("{0}{1}:{2}{3}", time[0], time[1], time[2],time[3]);
}
}
