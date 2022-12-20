public static class Kata
{

    public static double calculate(string s)
    {
        string? noSpaceString = s.Where(c=>!Char.IsWhiteSpace(c)).ToString();
        if (noSpaceString == null)
        return 0;
        var chisla = new List<double>();
        var ops = new List<char>();
        for (int i = 0; i < noSpaceString.Length; i++)
        {
            var beginPos = i;
            var endPos = i;
            for (int j = i+1; j < noSpaceString.Length; j++)
            {
                if (Char.IsDigit(noSpaceString[j]) || noSpaceString[j]=='.')
                {
                    endPos = j;
                    continue;
                }
                double figure = double.Parse(noSpaceString.Substring(i, j - i));
                chisla.Add(figure);
            }
            
        }
    }
}
