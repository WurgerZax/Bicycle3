namespace Bicycles3;

public class UsefulFunctions
{
    public void CopyValuesFromOneArrayToAnother(int[] from, int[] to)
    {
        for (int i = 0; i < from.Length; i++)
        {
            to[i] = from[i];
        }
    }
    
    public int[] AppendElementToArray(int[] array, int element)
    {
        int[] newArray = new int[array.Length + 1];
        
        //fill array
        CopyValuesFromOneArrayToAnother(array, newArray);
        
        newArray[array.Length] = element;

        return newArray;
    }

    public int[] AppendElementToTheStartOfArray(int[] array, int element)
    {
        int[] newArray = new int[array.Length + 1];
        
        newArray[0] = element;
        
        //fill array
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
        }

        return newArray;
    }

    public int[] SortArray(int[] array)
    {
        int[] newArray = new int[0];
        
        // ok, first of all we need to pass through all elements in array
        for (int i = 0; i < array.Length; i++)
        {
            bool biggestElementInserted = false;
            
            // ok, there I needed some help. So I entered in Интернеты, took that idea of realisation
            // so, our value can be lesser than the last value of new array
            // and greater than the first value of new array
            // that's why we need another cycle
            for (int j = 0; j < newArray.Length; j++)
            {
                if (array[i] < newArray[j])
                {
                    // write in array new array, where our element inserted on the correct position
                    newArray = InsertElementAtIndex(newArray, array[i], j);
                    biggestElementInserted = true; // set true, to prevent appending element in the end of array
                    break;
                }
            }

            if (!biggestElementInserted)
            {
                // if not found position to paste element - that means, that the element is the biggest
                // so we should append it to the end
                newArray = AppendElementToArray(newArray, array[i]);
            }
        }

        return newArray;
    }
    
    // idea of this code was communisted from Интернеты. Author of code: unknown
    private int[] InsertElementAtIndex(int[] array, int element, int index)
    {
        // idea of code is:
        // 1. create new array;
        // 2. rewrite all values until index
        // 3. on index paste our element
        // 4. rewrite all remaining values
        
        // 1.
        int[] newArray = new int[array.Length + 1];

        // 2.
        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        // 3.
        newArray[index] = element;

        // 4.
        for (int i = index; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
        }

        return newArray;
    }

    private int RandomNumberInRange(int min, int max)
    {
        Random random = new Random();
        
        return random.Next(min, max+1);
    }

    public int[] GenerateArrayOfRandomNumbers(int arrayLength, int min, int max, bool withoutDoubles = false)
    {
        int[] array = new int[arrayLength];

        int count = 0;
        
        for (; count != arrayLength;)
        {
            int randomNumber = RandomNumberInRange(min, max);

            if (withoutDoubles)
            {
                if(arrayLength >= max) throw new Exception("Array length must be lesser than max, if you want unique values");
                
                if(Array.IndexOf(array, randomNumber) != -1) continue;
            }
            
            array[count] = randomNumber;
            
            count++;
        }
        
        return array;
    }
}