using System;
using Grant_Thornton.Quizzes;
using JetBrains.Annotations;
using Xunit;

namespace Grant_Thornton.Tests;

[TestSubject(typeof(Fibonacci))]
public class FibonacciTest(Fibonacci fibonacci) : IClassFixture<Fibonacci>
{
    [Fact]
    public void should_return_zero_if_input_zero()
    {
        var result = fibonacci.GetValueOfFibonacciNumber(0);
        Assert.Equal(0, result);
    }
}