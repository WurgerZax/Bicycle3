namespace Bicycles3.Tasks;

public class Task3
{
    public int[] FindMinimalGap(int[] arr)
    {
        // first two
        int minGap = Math.Abs(arr[1] - arr[0]);
        int[] minGapIndexes = [Array.IndexOf(arr, arr[0]), Array.IndexOf(arr, arr[1])];

        // skip first two
        for (int i = 2; i < arr.Length; i++)
        {
            int currentNumber = arr[i];
            int previousNumber = arr[i - 1];
            int currMinGap = Math.Abs(currentNumber - previousNumber);
            
            if (currMinGap <= minGap)
            {
                minGapIndexes = [Array.IndexOf(arr, previousNumber), Array.IndexOf(arr, currentNumber)];
            }
            minGap = Math.Min(minGap, currMinGap);
        }
        
        return minGapIndexes;
    }
}