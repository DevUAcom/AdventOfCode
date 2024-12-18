﻿using CSharp.Day03;
using FluentAssertions;

namespace TestProject1.Day03.MultiplicatorTests;

public class Part1
{
    [Fact]
    public void Should_Return_Expected_Result()
    {
        int result = Multiplicator.Part1("xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))");

        result.Should().Be(161);
    }
}