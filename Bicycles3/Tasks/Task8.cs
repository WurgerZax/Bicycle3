namespace Bicycles3.Tasks;

public class Task8
{
    // condition says that the array is sorted. So we can use algorithm of two pointers
    public int[] FindSumOfTwoInSortedArray(int[] arr, int valueToFind)
    {
        int leftPointer = 0; // pointer on the start of array
        int rightPointer = arr.Length - 1; // pointer on the end of array

        while (leftPointer < rightPointer)
        {
            int sum = arr[leftPointer] + arr[rightPointer];

            if (sum == valueToFind)
            {
                return [leftPointer, rightPointer];
            } 
            else if (sum > valueToFind)
            {
                rightPointer--;
            }
            else
            {
                leftPointer++;
            }
        }
        return [];
    }
}