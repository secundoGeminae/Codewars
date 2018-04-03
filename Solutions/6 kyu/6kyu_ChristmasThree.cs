  public static string ChristmasTree(int height)
    {
     return string.Join("\n", Enumerable.Range(1, height).Select(i => new string('*', 2 * i - 1)
     .PadLeft(height + i - 1).PadRight(2 * height - 1)));
    }
