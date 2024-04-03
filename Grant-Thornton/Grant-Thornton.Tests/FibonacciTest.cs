using Grant_Thornton.Quizzes;
using JetBrains.Annotations;
using Xunit;

namespace Grant_Thornton.Tests;

[TestSubject(typeof(Fibonacci))]
public class FibonacciTest : IClassFixture<Fibonacci>
{
    private readonly Fibonacci _fibonacci;

    public FibonacciTest(Fibonacci fibonacci)
    {
        _fibonacci = fibonacci;
    }
    
    [Fact]
    public void IfEqual()
    {
        var result = _fibonacci.GetValueOfFibonacciNumber(5);
        Assert.Equal(3, result);
    }
}