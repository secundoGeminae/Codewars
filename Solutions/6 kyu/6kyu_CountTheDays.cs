namespace DayCount {
  using System;
  
  public class Day
  {
    public string countDays(DateTime d)
    {
    return DateTime.Today > d? "The day is in the past!":
    DateTime.Now.DayOfYear==d.DayOfYear? "Today is the day!":
    Math.Round((d- DateTime.Now).TotalDays,0).ToString()+" days" ;
    }
  }
  
}
