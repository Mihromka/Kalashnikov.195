using System;

namespace Delenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тип Intager занимет(в байтах):" + " " + sizeof(int));
            Console.WriteLine("Тип Float занимет(в байтах):" + " " + sizeof(float));
            float a, b;
            try
            {
                Console.WriteLine("Введите первое число: ");
                a = float.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число: ");
                b = float.Parse(Console.ReadLine());

                if (b == 0)
                    Console.WriteLine("на ноль делить нельзя");
                else
                    Console.WriteLine("Ответ:" + " " + a / b);

            }
            catch
            {
                Console.WriteLine("Ошибка");
            }

        }
    }

}
