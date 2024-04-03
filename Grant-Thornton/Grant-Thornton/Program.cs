// See https://aka.ms/new-console-template for more information

using Grant_Thornton.Quizzes;

namespace Grant_Thornton;

internal class Program
{
    public static async Task Main(string[] args)
    { 
        var fibonacci = new Fibonacci(); // OK
            
        var square = new Square(); // OK
            
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        var bubbleSort = new BubbleSort(); //OK
            
        var palindrome = new Palindrome();
        
        Console.WriteLine(fibonacci.GetValueOfFibonacciNumber(5));
    } 
}