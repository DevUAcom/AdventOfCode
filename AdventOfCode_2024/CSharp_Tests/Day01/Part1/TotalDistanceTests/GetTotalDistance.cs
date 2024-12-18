using CSharp.Day01.Part1;
using FluentAssertions;

namespace TestProject1.Day01.Part1.TotalDistanceTests;

public class GetTotalDistance
{
    [Fact]
    public void Should_Return_Total_Distance()
    {
        List<int> left = [3, 4, 2, 1, 3, 3];
        List<int> right = [ 4, 3, 5, 3, 9, 3 ];
        
        int result = TotalDistance.GetTotalDistance(left, right);
        
        result.Should().Be(11);
    }
}