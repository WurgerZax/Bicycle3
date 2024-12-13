namespace Bicycles3.Tasks;

public class Task10
{

    public int[] GenerateArrayOfRandomUniqueNumbers(int arrayLength, int min, int max)
    {
        UsefulFunctions usefulFunctions = new UsefulFunctions();
    
        return usefulFunctions.GenerateArrayOfRandomNumbers(arrayLength, min, max, true);
    }
}