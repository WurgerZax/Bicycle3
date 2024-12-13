namespace Bicycles3;

public class UsefulFunctions
{
    public int[] AppendElementToArray(int[] array, int element)
    {
        int[] newArray = new int[array.Length + 1];
        
        //fill array
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        
        newArray[array.Length] = element;

        return newArray;
    }
}