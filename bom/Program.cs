using System;

class Program
{
    
    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(minValue, maxValue);
        }

        return array;
    }

    
    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }

    static void Main(string[] args)
    {
        
        int[] randomArray = GenerateRandomArray(10, 0, 100);

        
        PrintArray(randomArray);
    }
}
