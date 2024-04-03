namespace Grant_Thornton.Quizzes;
public class Fibonacci
{
    public int GetValueOfFibonacciNumber(int n)
    {
        int a = 0, b = 1, c = 0;
        
        if (n == 0)
            return a;
        
        for (var i = 2; i < n; i++) {
            c = a + b;
            a = b;
            b = c;
        }
        
        return b;
    }
}