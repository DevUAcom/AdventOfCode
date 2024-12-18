using System.Text.RegularExpressions;

namespace CSharp.Day03;

// https://adventofcode.com/2024/day/3
public static class Multiplicator
{
    public static int Part1(string mulProgram)
    {
        var mulRegex = new Regex(@"mul\((\d+)\,(\d+)\)", RegexOptions.Compiled | RegexOptions.Multiline);
        var matches = mulRegex.Matches(mulProgram);
        
        return matches
            .Select(m => int.Parse(m.Groups[1].Value) * int.Parse(m.Groups[2].Value))
            .Sum();
    }
    
    public static int Part2(string mulProgram)
    {
        var mulRegex = new Regex(@"mul\((\d+)\,(\d+)\)|do\(\)|don't\(\)", RegexOptions.Compiled | RegexOptions.Multiline);
        var matches = mulRegex.Matches(mulProgram);

        return matches
            .Aggregate((isEnabled: true, sum: 0), (acc, m) =>
            {
                if (m.Value == "do()")
                {
                    return (true, acc.sum);
                }

                if (m.Value == "don't()")
                {
                    return (false, acc.sum);
                }

                if (acc.isEnabled)
                {
                    acc.sum += int.Parse(m.Groups[1].Value) * int.Parse(m.Groups[2].Value);
                }

                return acc;
            }).sum;
    }
}