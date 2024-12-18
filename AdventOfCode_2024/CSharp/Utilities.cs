namespace CSharp;

public static class Utilities
{
    public static (List<int>, List<int>) GetLeftAndRightLists(string filePath)
    {
        const string numbersDelimiter = "   ";
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        ReadInput(filePath, ln =>
        {
            var numbers = ln.Split(numbersDelimiter);
            left.Add(int.Parse(numbers[0]));
            right.Add(int.Parse(numbers[1]));
        });
        return (left, right);
    }

    public static int[][] GetArrayOfArrays(string filePath)
    {
        const string numbersDelimiter = " ";
        List<int[]> list = new List<int[]>();
        ReadInput(filePath, ln =>
        {
            var numbers = ln.Split(numbersDelimiter).Select(int.Parse).ToArray();
            list.Add(numbers);
        });
        return list.ToArray();
    }

    private static void ReadInput(string filePath, Action<string> action)
    {
        using StreamReader streamReader = new StreamReader(filePath);
        while (streamReader.ReadLine() is { } ln)
        {
            action(ln);
        }
    }
}