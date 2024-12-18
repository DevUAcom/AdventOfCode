namespace CSharp.Day02.Part1;

public static class RedNosedReports
{
    public static int GetNumberOfSafeReports(int[][] reports)
    {
        return reports.Select(x => IsSafeReport(x) ? 1 : 0).Sum();
    }

    public static bool IsSafeReport(int[] levels)
    {
        if (levels.Length == 0)
        {
            throw new ArgumentException();
        }
        bool isIncreasing = false;
        bool isDecreasing = false;
        for (int i = 1; i < levels.Length; i++)
        {
            if (levels[i - 1] < levels[i])
            {
                isIncreasing = true;
            }

            if (levels[i - 1] > levels[i])
            {
                isDecreasing = true;
            }

            if (isIncreasing && isDecreasing)
            {
                return false;
            }

            if (Math.Abs(levels[i] - levels[i - 1]) is < 1 or > 3)
            {
                return false;
            }
            
        }
        return true;
    }
}