using System;

namespace Task3
{
    public static class ExtentionClass
    {
        public static void SortExtMethod(this int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public static void ShowArray(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 21, 6, 4, 7, 99, 50 };
            array.ShowArray();

            array.SortExtMethod();
            array.ShowArray();
        }
    }
}
