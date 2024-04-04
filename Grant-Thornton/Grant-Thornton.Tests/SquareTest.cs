using Grant_Thornton.Quizzes;
using JetBrains.Annotations;
using Xunit;

namespace Grant_Thornton.Tests;

[TestSubject(typeof(Square))]
public class SquareTest(Square square): IClassFixture<Square>
{

    [Fact]
    public void should_return_a_string_with_spaces_and_star_signs()
    {
        Assert.Equal("  **", square.CurrentRow(2, 2));
    }

    [Fact]
    public void true_if_number_is_odd()
    {
        Assert.Equal(true, square.IsOdd(3));
    }
    
    [Fact]
    public void false_if_number_is_not_odd()
    {
        Assert.Equal(false, square.IsOdd(2));
    }
}