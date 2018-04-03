using System.Linq;
using System.Collections.Generic;
public class Sudoku
{  
   public static int[] range = Enumerable.Range(1, 9).ToArray();
   
   public static bool ValidateSolution(int[][] data)
        {
            return SequenceValidator(data)&RowValidator(data)&ColumnValidator(data);
        }
        public static bool RowValidator(int[][] data)
        {             
            return data.Select(d => d.OrderBy(x => x).ToArray()).ToArray().Select((d,i) => d[i]==range[i]).All(c => c == true);
        }
        public static bool ColumnValidator(int[][] data)
        {
            List<bool> temp = new List<bool>();
            
            for (int j = 0; j < 9; j++)
            {
                temp.Add(data.Select(d => d.Where((x, i) => i == j)).SelectMany(x=>x).OrderBy(v=>v).Select((c,i)=>c==range[i]).All(c => c == true));
            }
            return temp.All(x=>x==true);
        }
        public static bool SequenceValidator(int[][] data)
        {
            var column = data.Where((x, i) => i == 0).SelectMany(x=>x).ToArray();
            var row = data.Select(d => d.Where((x, i) => i == 0)).SelectMany(x => x).ToArray();
            return column.Select((x,i)=>x==row[i]).All(x=>x==true) ? false: true; 
        }
}
