using CSharp.Day01.Part2;
using FluentAssertions;

namespace TestProject1.Day01.Part2.SimilarityScoreTests;

public class GetSimilarityScore
{
    [Fact]
    public void Should_Return_Similarity_Score()
    {
        List<int> left = [3, 4, 2, 1, 3, 3];
        List<int> right = [ 4, 3, 5, 3, 9, 3 ];
        
        int result = SimilarityScore.GetSimilarityScore(left, right);
        
        result.Should().Be(31);
    }
}