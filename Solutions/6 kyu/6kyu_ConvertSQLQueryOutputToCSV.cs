using System;
using System.Linq;
namespace Kata
{
  public class SqlQueryOutputToCsvConverter
  {
    public string Convert(string[] lines)
    {
    return lines.Length==0?"":string.Concat(lines.Select(x=> String.Join(",",x.Split(',')
    .Select(c=>c.Trim()))+"\r\n").Select((x,i)=>i==0?x:char.IsDigit(x[0])?x:"")
    .Where(c=>c!="")).Replace("NULL","");
    }
  }
}
