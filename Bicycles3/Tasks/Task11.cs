namespace Bicycles3.Tasks;

public class Task11
{
    /*
        Чи́сла Фибона́ччи — элементы числовой последовательности:
        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, …,
        в которой первые два числа равны 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел
     */
    public int[] FibonacciGenerator(int n)
    {
        int[] array = new int[n];
        int prev = 0;
        int next = 1;
        
        array[0] = prev;
        array[1] = next;

        for (int i = 2; i < n; i++)
        {
            int newNext = prev + next;
            array[i] = newNext;
            prev = next;
            next = newNext;
        }
        
        return array;
    }
}