using System;
public class Kata
{
  public static int[][] MatrixAddition(int[][] a, int[][] b)
  {
     for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = a[i][j] + b[i][j];
                }
            }
    return a;
  }
}
