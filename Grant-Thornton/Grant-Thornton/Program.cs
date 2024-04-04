// See https://aka.ms/new-console-template for more information

using Grant_Thornton.Quizzes;

namespace Grant_Thornton;

internal abstract class Program
{
    public static async Task Main(string[] args)
    { 
        var fibonacci = new Fibonacci(); 
            
        var square = new Square(); 
            
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        var bubbleSort = new BubbleSort(); 
            
        var palindrome = new Palindrome(); 
        var respond = await palindrome.GetRespond("DRuQSdrjDG_syswkTpRhz2l0wt_tDoOmFTGLhCCni_MDAzFuYF6Bkg==");
        
        Console.WriteLine(fibonacci.GetValueOfFibonacciNumber(5));
    } 
}