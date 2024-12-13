namespace Bicycles3.Tasks;

public class Task5
{
    public char[] EncryptMessage(char[] text, byte shift)
    {
        char[] letters = new Alphabet().Letters;
        char[] nums = new Alphabet().Nums;

        for (int i = 0; i < text.Length; i++)
        {
            if(text[i] == ' ') continue;
            if (char.IsPunctuation(text[i])) continue;

            ShiftChar(ref text[i], shift, char.IsDigit(text[i]) ? nums : letters);
        }
        
        return text;
    }

    private void ShiftChar(ref char ch, int shift, char[] array)
    {
        int indexOfChar = Array.IndexOf(array, ch);

        if (indexOfChar + shift >= array.Length)
        {
            int excess = indexOfChar + shift - array.Length;
            ch = array[excess];
        }
        else
        {
            ch = array[indexOfChar + shift];   
        }
    }
}