using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вычисление объема цилиндра.");
        Console.WriteLine("Введите исходные данные:");

        Console.Write("Радиус основания (см) -> ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Высота цилиндра (см) -> ");
        double height = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * radius * radius * height;

        Console.WriteLine($"Объем цилиндра: {volume:F2} куб. см.");
    }
}