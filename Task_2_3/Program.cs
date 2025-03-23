namespace Task_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task2_3
            Console.WriteLine("Введите значение в дюймах:");
            int inch = int.Parse(Console.ReadLine());


            // Перевод в миллиметры , метры, сантиметры
            double millimeters = inch * 25.4;
            int meters = (int)(millimeters / 1000);
            int sm = (int)(millimeters / 10);
            double ostatok = Math.Round(millimeters % 10, 2);
            // Перевод в вывод
            Console.WriteLine($"{meters} м {sm} см {ostatok} мм");
        }
    }
}
