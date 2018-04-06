using System;
public static class Kata
{
  public static int СenturyFromYear(int year)
  {  
    return year%100==0? year/100: year/100+1;
  }
}
