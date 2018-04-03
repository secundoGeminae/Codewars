using System;
using System.Collections.Generic;
using System.Linq;
public class Dinglemouse
{
  public static string WhatTimeIsIt(double angle)
  {
  if(angle==0) return "12:00";
    var someTime = new DateTime(Convert.ToInt64(angle*1200000000));
            if (someTime.Hour == 0)

            { someTime = someTime.AddHours(12); }
            return someTime.TimeOfDay.ToString().Substring(0,5);
  }
}
