using System.Text;

namespace CSharp.Day04;

public static class XmasSearcher
{
    private const string Xmas = "XMAS";
    private const string Samx = "SAMX";
    
    public static int Part1(string[] lines)
    {
        return GetAllStrings(lines)
            .Select(CountOccurrences)
            .Sum();
    }

    public static int Part2(string[] lines)
    {
        var (primaryDiagonals, secondaryDiagonals) = GetDiagonals(lines);
        int count = 0;
        foreach (var primaryDiagonal in primaryDiagonals)
        {
            for (var index = 0; index < primaryDiagonal.Value.Count - 2; index++)
            {
                var (i, j) = primaryDiagonal.Value[index];
                if (
                    (GetChar(primaryDiagonal, index) == 'M' && GetChar(primaryDiagonal, index + 2) == 'S' 
                     || GetChar(primaryDiagonal, index) == 'S' && GetChar(primaryDiagonal, index + 2) == 'M') 
                    && GetChar(primaryDiagonal, index + 1) == 'A'
                    && (lines[i + 2][j] == 'M' && lines[i][j + 2] == 'S' 
                        || lines[i + 2][j] == 'S' && lines[i][j + 2] == 'M')
                )
                {
                    count++;                    
                }
            }
        }

        return count;

        char GetChar(KeyValuePair<int, List<(int, int)>> diagonal, int itemIndex)
        {
            var (i, j) = diagonal.Value[itemIndex];
            return lines[i][j];
        }
    }

    private static int CountOccurrences(string text)
    {
        return Count(Xmas) + Count(Samx);

        int Count(string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(substring, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += substring.Length; 
            }

            return count;
        }
    }

    private static IEnumerable<string> GetAllStrings(string[] lines) => 
        lines
            .Concat(GetVerticalLines(lines))
            .Concat(GetDiagonalLines(lines))
        ;

    private static IEnumerable<string> GetVerticalLines(string[] lines)
    {
        for (int i = 0; i < lines[0].Length; i++)
        {
            var verticalLine = new StringBuilder(lines.Length);
            foreach (var line in lines)
            {
                verticalLine.Append(line[i]);
            }
            yield return verticalLine.ToString();
        }
    }

    private static IEnumerable<string> GetDiagonalLines(string[] lines)
    {
        var (primaryDiagonals, secondaryDiagonals) = GetDiagonals(lines);
        return primaryDiagonals
            .Concat(secondaryDiagonals)
            .Select(x => string.Join("", x.Value.Select(ij => lines[ij.i][ij.j])));
    }
    
    private static (Dictionary<int, List<(int i, int j)>> primary, Dictionary<int, List<(int i, int j)>> secondary) GetDiagonals(string[] lines)
    {
        var primaryDiagonals = new Dictionary<int, List<(int i, int j)>>();
        var secondaryDiagonals = new Dictionary<int, List<(int i, int j)>>();

        int rows = lines.Length;
        int cols = lines[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int diff = i - j;
                int sum = i + j;
                
                if (!primaryDiagonals.ContainsKey(diff))
                {
                    primaryDiagonals[diff] = new List<(int i, int j)>();
                }
                primaryDiagonals[diff].Add((i, j));
                
                if (!secondaryDiagonals.ContainsKey(sum))
                {
                    secondaryDiagonals[sum] = new List<(int i, int j)>();
                }
                secondaryDiagonals[sum].Add((i, j));
            }
        }

        return (primaryDiagonals, secondaryDiagonals);
    }
}
