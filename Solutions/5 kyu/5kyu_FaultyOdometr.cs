namespace myjinxin
{
    using System;
    using System.Linq;
    
    public class Kata
    {
        public int FaultyOdometer(int n){
          
            var result=0;
            var digitArray = n.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            Array.Reverse(digitArray);
            for (int i = 0; i < digitArray.Length; i++)
            {
                result= digitArray[i] > 4 ? result += (int)((digitArray[i] - 1) * System.Math.Pow(9, i)) : result += (int)(digitArray[i] * System.Math.Pow(9, i));
              
            }
            return result;
          
        }
    }
}
