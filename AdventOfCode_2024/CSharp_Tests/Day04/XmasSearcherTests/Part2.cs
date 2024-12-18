using CSharp.Day04;
using FluentAssertions;

namespace TestProject1.Day04.XmasSearcherTests;

public class Part2
{
    [Fact]
    public void Should_Return_Expected_Result()
    {
        string[] lines =
        [
            "MMMSXXMASM",
            "MSAMXMSMSA",
            "AMXSXMAAMM",
            "MSAMASMSMX",
            "XMASAMXAMM",
            "XXAMMXXAMA",
            "SMSMSASXSS",
            "SAXAMASAAA",
            "MAMMMXMMMM",
            "MXMXAXMASX",
        ];
        
        var result = XmasSearcher.Part2(lines);

        result.Should().Be(9);
    }
}