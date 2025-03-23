namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task2_1
            int a, b, c, d;
            Console.WriteLine("Введите три целых числа(с помощью enter):");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = a;
            a = c;
            c = b;
            b = d;

            Console.WriteLine($"После обмена: a = {a}, b = {b}, c = {c}");

            
        }
    }
}
