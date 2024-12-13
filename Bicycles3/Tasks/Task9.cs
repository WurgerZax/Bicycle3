namespace Bicycles3.Tasks;

public class Task9
{
    public int[] GenerateArrayOfRandomSortedNumbers(int arrayLength, int min, int max)
    {
        UsefulFunctions usefulFunctions = new UsefulFunctions();
        
        int[] array = usefulFunctions.GenerateArrayOfRandomNumbers(arrayLength, min, max);
        
        return usefulFunctions.SortArray(array);
    }
}