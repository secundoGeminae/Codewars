namespace MinuteCount {
  using System;
  
  public class Minute
  {
    public string countMinutes(DateTime d)
    {
       var min = Math.Round(DateTime.Today.AddHours(24).Subtract(d).TotalMinutes,0);
       return min>9? min.ToString()+" minutes":min.ToString()+" minute";
    }
  }
  
}
