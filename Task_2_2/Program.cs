namespace Task_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task2_2
            Console.WriteLine("Введите значение в дюймах:");
            int degrees = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            // Перевод в десятичные градусы
            double decimalDegrees = degrees + (minutes / 60.0) + (seconds / 3600.0);

            // Перевод в радианы
            double radians = decimalDegrees * (Math.PI / 180);

            // Вывод результата
            Console.WriteLine($"Угол в радианах: {radians}");
        }
    }
}
