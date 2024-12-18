namespace CSharp.Day01.Part2;

public static class SimilarityScore
{
    public static int GetSimilarityScore(List<int> left, List<int> right)
    {
        if (left.Count != right.Count)
        {
            throw new ArgumentException();
        }
        
        var rightAppears =
            (from r in right
                group r by r
                into g
                select g)
            .ToDictionary(x => x.Key, x => x.Count());

        return left
            .Select(x => x * rightAppears.GetValueOrDefault(x, 0))
            .Sum();
    }
}