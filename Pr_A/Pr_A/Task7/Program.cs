using System;

class Program
{
    static void Main()
    {
        double r = 5.5;   // радиус основания
        double h = 7;     // высота

        double V = Math.PI * r * r * h;
        double S = 2 * Math.PI * r * h;

        Console.WriteLine("Вычисление объема и площади цилиндра");
        Console.WriteLine($"Радиус основания: {r}");
        Console.WriteLine($"Высота: {h}");
        Console.WriteLine($"Объем V = {V:F2}");
        Console.WriteLine($"Площадь боковой поверхности S = {S:F2}");
    }
}