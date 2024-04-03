
namespace Grant_Thornton.Quizzes;

public class BubbleSort
{
    public string BubbleRespond(int[] arr)
    {
        var n = arr.Length;
        Sort(arr, n);
        return printArray(arr, n);
    }
    
    // Function to print an array
    static string printArray(int[] arr, int size)
    {
        var result = "";
        for (var i = 0; i < size; i++)
            result += arr[i] + " ";
        
        return result;
    }
    
    // An optimized version of Bubble Sort
    static void Sort(int[] arr, int n)
    {
        int temp;
        bool swapped;
        for (var i = 0; i < n - 1; i++) {
            swapped = false;
            for (var j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                     
                    // Swap arr[j] and arr[j+1]
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            // If no two elements were
            // swapped by inner loop, then break
            if (swapped == false)
                break;
        }
    }
}