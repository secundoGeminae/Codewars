using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
     return arr.OrderBy(x => x==0).ToArray();
  }
}
