using System;
using System.Linq;
public class Kata
{
  public static double Solution(int[] firstArray, int[] secondArray)
  {
     int[] t = new int[firstArray.Count()];
     for (int i=0;i<firstArray.Length;i++)
            {
                t[i] =(int)Math.Pow(firstArray[i] - secondArray[i],2);
            }
            return t.Average(); 
  }
}
