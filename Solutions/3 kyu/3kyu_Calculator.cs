using System;

public class Evaluator
{
    public double Evaluate(string expression)
    {    
       return Math.Round(Convert.ToDouble(new System.Data.DataTable().Compute(expression, null)),7);
    }
}
