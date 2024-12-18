using CSharp.Day02.Part2;
using FluentAssertions;

namespace TestProject1.Day02.Part2.RedNosedReportsWithToleratingTests;

public static class GetNumberOfSafeReports
{
    [Fact]
    public static void Should_Return_Number_Of_Safe_Reports()
    {
        int[][] reports = new int[][]
        {
            [7, 6, 4, 2, 1],
            [1, 2, 7, 8, 9],
            [9, 7, 6, 2, 1],
            [1, 3, 2, 4, 5],
            [8, 6, 4, 4, 1],
            [1, 3, 6, 7, 9],
        };
        
        int result = RedNosedReportsWithTolerating.GetNumberOfSafeReports(reports);
        
        result.Should().Be(4);
    }

}