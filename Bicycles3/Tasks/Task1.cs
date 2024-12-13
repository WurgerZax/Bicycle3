namespace Bicycles3.Tasks;

public class Task1
{
    private readonly char[] _letters = new Alphabet().Letters;
    private char NumberToLetter(byte number)
    {
        if (number < 1 || number > _letters.Length)
        {
            throw new ArgumentException("Number must be in range [1-26]");
        }
        return _letters[number - 1];
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