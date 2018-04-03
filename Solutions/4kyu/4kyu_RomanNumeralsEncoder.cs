using System;

public class RomanConvert
{
	public static string Solution(int n)
	{
   int[] seqD = {1000, 900, 500,400,100,90,50,40,10,9,5,4,1};
   string[] seqC = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
   int i = 0;  
   string s = "";
      while (n > 0)              
        {
         if (seqD[i] <= n)
           {
             n = n - seqD[i];   
             s = s + seqC[i]; 
           }
          else i++;
         }
        return s;
	}
}
