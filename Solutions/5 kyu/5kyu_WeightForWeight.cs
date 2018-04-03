using System;
using System.Linq;

public class WeightSort {
	
	public static string orderWeight(string strng) {
		return String.Join(" ",strng.Split(' ').OrderBy(x => x.Select(c => int.Parse(c.ToString())).Sum()).ThenBy(x=>x));
	}
}
