using System;

namespace AdditionalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(4, 5.07));
            Console.WriteLine(Calculator.Substract(4, 5));
            Console.WriteLine(Calculator.Multiply(4, 5));
            Console.WriteLine(Calculator.Divide(4, 5));
        }
    }
}
