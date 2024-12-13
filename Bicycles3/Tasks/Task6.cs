namespace Bicycles3.Tasks;

public class Task6
{
    public int[] FindPeaks(int[] heights)
    {
        int[] peaks = new int[0];
        
        for (int i = 0; i < heights.Length; i++)
        {
            int peak = heights[i];
            int prevNeighbour = i - 1 < 0 ? 0 : heights[i - 1];
            int nextNeighbour = i + 1 == heights.Length ? 0 : heights[i + 1];

            if (peak > prevNeighbour && peak > nextNeighbour)
            {
                peaks = AppendElementToArray(peaks, peak);
            }
        }
        
        return peaks;
    }

    private int[] AppendElementToArray(int[] array, int element)
    {
        int[] newArray = new int[array.Length + 1];
        
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        
        newArray[array.Length] = element;

        return newArray;
    }
}