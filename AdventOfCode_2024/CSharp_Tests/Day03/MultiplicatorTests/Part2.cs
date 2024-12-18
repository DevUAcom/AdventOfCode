using CSharp.Day03;
using FluentAssertions;

namespace TestProject1.Day03.MultiplicatorTests;

public class Part2
{
    [Fact]
    public void Should_Return_Expected_Result()
    {
        int result = Multiplicator.Part2("xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))");

        result.Should().Be(48);
    }
}