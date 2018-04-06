namespace Solution {
  using NUnit.Framework;
  using System;
  using System.Linq;

  

  [TestFixture]
  public class SolutionTest
  {
    private int check(int[] arr1,int[] arr2)
    {
      return arr1.Sum()+arr2.Sum();
    }
      
    [Test]
    public void BasicTest()
    {
      Assert.AreEqual(21, Kata.ArrayPlusArray(new int[]{1,2,3}, new int[]{4,5,6}));
      Assert.AreEqual(-21, Kata.ArrayPlusArray(new int[]{-1,-2,-3}, new int[]{-4,-5,-6}));
      Assert.AreEqual(15, Kata.ArrayPlusArray(new int[]{0,0,0}, new int[]{4,5,6}));
      Assert.AreEqual(2100, Kata.ArrayPlusArray(new int[]{100,200,300}, new int[]{400,500,600}));
      
    }
    [Test]
    public void RandomTest()
    {
      Random rnd = new Random();
            
      for (int i = 0; i < 100; ++i)
      {
        int[] xs = new int[rnd.Next(2, 21)].Select(_ => rnd.Next(-100, 100)).ToArray();
        int[] ss = new int[rnd.Next(2, 21)].Select(_ => rnd.Next(-100, 100)).ToArray();
        Console.WriteLine("test №"+(i+1)); 
        Console.WriteLine(string.Join(" ",xs)); 
        Console.WriteLine(string.Join(" ",ss)); 
        Assert.That(Kata.ArrayPlusArray(xs,ss), Is.EqualTo(check(xs,ss)));
      }
      }
  }
  }
