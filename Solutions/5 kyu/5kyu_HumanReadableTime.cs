using System;
public static class TimeFormat
{
    public static string GetReadableTime(int sec)
    {
        
            TimeSpan s = new TimeSpan(0, 0, sec);
            string hours=s.Hours.ToString(), minutes=s.Minutes.ToString(), seconds = s.Seconds.ToString();
            if (s.Hours < 10){hours = "0" + s.Hours;}
            if (s.Minutes < 10) {  minutes = "0" + s.Minutes; }
            if (s.Seconds < 10) {  seconds = "0" + s.Seconds; }
            if (s.Days > 0) { return $"{s.Days * 24 + (int)s.Hours}:{minutes}:{seconds}"; }
            return $"{hours}:{minutes}:{seconds}";
    }
}
