public class Sequence 
{
  public static long GetScore(long n) 
  {
    long[] mass = new long [n];
    for(int i=0;i<n;i++)
      {
        if (i == 0){ 
        mass[i] = (i+1) * 50; }
        else mass[i] = (i + 1) * 50 + mass[i - 1];
      }
    return mass[n-1];
  }
}
