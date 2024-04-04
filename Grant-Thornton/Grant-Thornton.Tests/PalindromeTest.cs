using JetBrains.Annotations;
using Xunit;

namespace Grant_Thornton.Tests;

[TestSubject(typeof(Palindrome))]
public class PalindromeTest(Palindrome palindrome): IClassFixture<Palindrome>
{

    [Fact]
    public void should_return_true_palindrome()
    {
        Assert.Equal(true, palindrome.GetStatus("Kayak"));
    }
    
    [Fact]
    public void should_return_false_palindrome()
    {
        Assert.Equal(false, palindrome.GetStatus("Latte"));
    }
}