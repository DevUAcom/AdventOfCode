using CSharp.Day02.Part1;

namespace CSharp.Day02.Part2;

public static class RedNosedReportsWithTolerating
{
    public static int GetNumberOfSafeReports(int[][] reports)
    {
        return reports.Select(x => IsSafeReport(x) ? 1 : 0).Sum();
    }

    private static bool IsSafeReport(int[] levels)
    {
        var withoutSingleLevel = Enumerable.Range(0, levels.Length)
            .Select(i => levels.Where((_, index) => index != i).ToArray()).ToArray();
        return withoutSingleLevel.Any(RedNosedReports.IsSafeReport);
    }
   
}