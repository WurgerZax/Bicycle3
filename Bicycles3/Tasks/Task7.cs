namespace Bicycles3.Tasks;

public class Task7
{
    public int[] RemoveElementByIndex(int[] array, int index)
    {
        var appendElementToArray = new UsefulFunctions().AppendElementToArray;
        
        if (index < 0 || index >= array.Length)
        {
            throw new Exception($"Index is out of range, enter a number between 0 and {array.Length}");
        }

        int[] splicedArray = new int[0];

        for (int i = 0; i < array.Length; i++)
        {
            if(i == index) continue;
            splicedArray = appendElementToArray(splicedArray, array[i]);   
        }

        return splicedArray;
    }
}