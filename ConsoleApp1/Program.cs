using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                //Нахождение максимального элемента и его индекса
                int[] array = { 8, -1, 4, 16, -5, 3 };
                int max = array[0]; int indexMax = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i]; indexMax = i;
                    }
                    Console.WriteLine($"max={max}\t{indexMax}");
                }
                Console.Read();
            }
    }
}
