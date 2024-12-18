namespace CSharp.Day01.Part1;

public static class TotalDistance
{
    public static int GetTotalDistance(List<int> left, List<int> right) 
    {
        if (left.Count != right.Count)
        {
            throw new ArgumentException();
        }

        return left.Order().Zip(right.Order(), (l, r) => Math.Abs(l - r)).Sum();
    }
}