namespace Bicycles3.Tasks;

public class Task2
{
    private bool IsPrime(int number)
    {
        // every even number will not be prime
        if (number % 2 == 0)
        {
            return false;
        } 
        if (number == 2)
        {
            return true; // 2 is 
        } 
        
        // pass array, but skip even numbers;
        for (int i = 3; i <= Math.Floor(Math.Sqrt(number)); i+=2)
        {
            if (number % i == 0)
            {
                return false; // exit when number divisions on i - that means the number is not prime
            }
        }

        return true;
    }

    public int[] TransformArray(int[] array)
    {
        int[] transformedArray = (int[])array.Clone();
        
        for (int i = 0; i < transformedArray.Length; i++)
        {
            int index = Array.IndexOf(array, transformedArray[i]);
            
            transformedArray[i] = IsPrime(index) ? transformedArray[i] * 2: transformedArray[i] * index;
        }
        
        return transformedArray;
    }
}