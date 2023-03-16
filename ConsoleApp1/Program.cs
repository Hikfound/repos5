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
            int min = array[0]; int indexMin = 0;
            for (int i = 1; i < 6; i++)
            {
            if (array[i] > max)
            {
                max = array[i]; indexMax = i;
            }
            if (array[i] < min)
            {
                min = array[i]; indexMin = i;
            }
            }
            Console.WriteLine($"min={min}\tindex={indexMin}");
            Console.WriteLine($"max={max}\tindex={indexMax}");
            Console.Read();
        }
    }
}
