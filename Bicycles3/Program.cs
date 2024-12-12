using Bicycles3.Tasks;

namespace Bicycles3;

class Program
{
    static void Main(string[] args)
    {
        // task1
        Task1 task1 = new Task1();

        Console.WriteLine(task1.formatArrayToString([9, 8, 15, 18]));
        
        //task2
        Task2 task2 = new Task2();

        string task2Result = string.Join(",", task2.TransformArray([3,5,2,7,9]));

        Console.WriteLine(task2Result);
    }
}