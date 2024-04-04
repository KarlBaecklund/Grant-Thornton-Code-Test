using System;
using System.Net;
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
    public async void should_return_true_401()
    {
        var respond = await palindrome.GetRespond("not_the_correct_query");
        Assert.Equal(HttpStatusCode.Unauthorized, respond.StatusCode);
    }
    
    [Fact]
    public async void should_return_true_200()
    {
        var respond = await palindrome.GetRespond("DRuQSdrjDG_syswkTpRhz2l0wt_tDoOmFTGLhCCni_MDAzFuYF6Bkg==");
        Assert.Equal(HttpStatusCode.OK  , respond.StatusCode);
    }
    
    [Fact]
    public async void should_return_thrown()
    {
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => palindrome.GetPalindrome("not_the_correct_query"));
        Assert.Equal("got response code: Unauthorized", exception.Message.ToString());
    }
    
    [Fact]
    public void should_return_false_palindrome()
    {
        Assert.Equal(false, palindrome.GetStatus("Latte"));
    }
}