using System;

namespace ConsoleApp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите значение температуры в градусах Цельсия");
            string tc = Console.ReadLine();
            int number;
            bool success = Int32.TryParse(tc, out number);
            if (success)
            {
                double TC = double.Parse(tc);
                double TF = TC * 9 / 5 + 32;
                Console.WriteLine($"Температура по Фаренгейту {TF}");
            }
            else
            {
                Console.WriteLine("Ввод неверный");
            }
        }
    }
}