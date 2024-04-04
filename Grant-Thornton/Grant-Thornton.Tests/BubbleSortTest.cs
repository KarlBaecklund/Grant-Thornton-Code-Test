using Grant_Thornton.Quizzes;
using JetBrains.Annotations;
using Xunit;

namespace Grant_Thornton.Tests;

[TestSubject(typeof(BubbleSort))]
public class BubbleSortTest(BubbleSort bubbleSort): IClassFixture<BubbleSort>
{

    [Fact]
    public void should_return_sorted_arr()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        int[] sortedArr = { 11,12,22,25,34,64,90 };
        Assert.Equal( sortedArr , bubbleSort.Sort(arr, arr.Length));
    }
}