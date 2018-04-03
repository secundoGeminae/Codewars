using System;
using System.Linq;
public class ParseAndCount
{       
  public int PaC(string str)
  {
    return (int)(new System.Data.DataTable().Compute(str.Split(':').Last(),""));
  }
}
