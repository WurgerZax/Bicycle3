namespace Bicycles3.Tasks;

public class Task4
{
    public int[] EnemiesResult(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = arr1[i] - arr2[i] < 0 ? 0 : arr1[i] - arr2[i];
        }
        
        return result;
    }
}