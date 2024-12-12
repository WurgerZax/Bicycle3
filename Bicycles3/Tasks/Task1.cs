namespace Bicycles3.Tasks;

public class Task1
{
    private static readonly char[] letters = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
    private char NumberToLetter(byte number)
    {
        if (number < 1 || number > letters.Length)
        {
            throw new ArgumentException("Number must be in range [1-26]");
        }
        return letters[number - 1];
    }

    public string FormatArrayToString(byte[] array)
    {
        string str = string.Empty;
        
        for (int i = 0; i < array.Length; i++)
        {
            try
            {
                str += NumberToLetter(array[i]);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        return str;
    }
}