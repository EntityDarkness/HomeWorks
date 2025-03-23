using System.Collections.Generic;

namespace Task_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы: ");
            float chislo = float.Parse(Console.ReadLine());
            Console.WriteLine($"Ваше число: {Math.Round(chislo)}");
        }
    }
}
