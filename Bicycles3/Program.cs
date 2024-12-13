using Bicycles3.Tasks;

namespace Bicycles3;

class Program
{
    static void Main(string[] args)
    {
        // task1
        Task1 task1 = new Task1();

        Console.WriteLine(task1.FormatArrayToString([9, 8, 15, 18]));
        
        //task2
        Task2 task2 = new Task2();

        string task2Result = string.Join(",", task2.TransformArray([3,5,2,7,9]));

        Console.WriteLine(task2Result);
        
        //task3
        Task3 task3 = new Task3();

        string task3Result = $"[{string.Join(",", task3.FindMinimalGap([10, 2, 5, 12, 7]))}]";

        Console.WriteLine(task3Result);
        
        //task4
        Task4 task4 = new Task4();

        string task4Result = $"[{string.Join(",", task4.EnemiesResult([10, 20, 130], [20, 10, 50]))}]";

        Console.WriteLine(task4Result);
        
        //task5
        Task5 task5 = new Task5();

        string messageForCaesar = "ALL IS READY TO ATTACK ROME AT 01.09.52";
        
        char[] encryptedMessage = task5.EncryptMessage(messageForCaesar.ToCharArray(), 3);
        
        string task5Result = $"[{string.Join(",", encryptedMessage)}]";

        Console.WriteLine("--task5--");
        Console.WriteLine(task5Result);
        Console.WriteLine(encryptedMessage);
        Console.WriteLine("--task5--");
        
        //task6
        Task6 task6 = new Task6();
        
        int[] peaks = task6.FindPeaks([10, 2, 5, 12, 7]);

        Console.WriteLine($"[{string.Join(",", peaks)}]");
        
        //task7
        Task7 task7 = new Task7();
        
        int[] arrayWithExcessElement = [1, 3, 2, 4, 1, 5];
        try
        {
            int[] splicedArray = task7.RemoveElementByIndex(arrayWithExcessElement, 2);
            Console.WriteLine($"[{string.Join(",", splicedArray)}]");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        //task8
        Task8 task8 = new Task8();

        int[] indexesOfSum = task8.FindSumOfTwoInSortedArray([1, 2, 3, 5, 7, 8, 9, 15], 22);

        Console.WriteLine($"[{string.Join(",", indexesOfSum)}]");
        
        //task9
        Task9 task9 = new Task9();
        
        int[] task9Result = task9.GenerateArrayOfRandomSortedNumbers(10, 0, 20);
        
        Console.WriteLine($"[{string.Join(",", task9Result)}]");
        
        //task10
        Task10 task10 = new Task10();
        
        int[] task10Result = task10.GenerateArrayOfRandomUniqueNumbers(15, 0, 30);
        
        Console.WriteLine($"[{string.Join(",", task10Result)}]");
        
        //task11
        Task11 task11 = new Task11();

        int[] task11Result = task11.FibonacciGenerator(10);
        
        Console.WriteLine($"[{string.Join(",", task11Result)}]");
    }
}