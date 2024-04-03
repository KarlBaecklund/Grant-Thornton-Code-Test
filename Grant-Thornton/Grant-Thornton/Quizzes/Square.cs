

namespace Grant_Thornton.Quizzes;

public class Square
{
    public string GetSquareFromValue(int n)
    {
        var opposite = 0;
        var amount = 0;
        var result = "";
        
        for (var i = 0; i < n; i++)
        {
            var currentRow = "";
            if (n/2 >= i)
            {
                var amountOfSpaces = (n/2) - i;
                if (i > 0)
                    amount += 2;
                currentRow += CurrentRow(amountOfSpaces, i == n ? 1 : 1 + amount);
            }
            else
            {
                amount -= 2;
                opposite += 1;
                
                currentRow += CurrentRow(opposite, i == n ? 1 : 1 + amount);
            }
            result += currentRow + "\n";
        }
        
        return result;
    }

    public string CurrentRow(int amountOfSpaces, int amountOfSigns)
    {
        var result = "";
        result += new string(' ', amountOfSpaces);
        result += new string('*', amountOfSigns);
        return result;
    }
}