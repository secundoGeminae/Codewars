namespace Solution {
  using NUnit.Framework;
  using System;

  

  [TestFixture]
  public class SolutionTest
  {
  
  private  int check(int year)
  {  
    return year%100==0? year/100: year/100+1;
  }
    [Test]
    public void BasicTest()
    {    
     Assert.AreEqual(21, Kata.СenturyFromYear(2018));
     Assert.AreEqual(15, Kata.СenturyFromYear(1455));
     Assert.AreEqual(18, Kata.СenturyFromYear(1703));
     Assert.AreEqual(18, Kata.СenturyFromYear(1800));
    }
    
    [Test]
    public void RandomTest()
    {
      Random rnd = new Random();
      for(int i=0;i<100;i++)
      {
        int n = rnd.Next(100,3000);
        Assert.That(check(n),Is.EqualTo(Kata.СenturyFromYear(n)));
      }
     
    }
     
  }
}
