namespace Task_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число: ");
            int chislo = int.Parse(Console.ReadLine());
            int first = chislo / 1000;
            int second = (chislo / 100)%10;
            int third = (chislo / 10)%10;
            int cuadro = chislo % 10;
            Console.WriteLine($"Ваше число: {first}{cuadro}{third}{second}");
        }
    }
}
