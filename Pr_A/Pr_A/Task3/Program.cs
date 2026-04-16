using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a (a > 0, a ≠ 2): ");
        double a = Convert.ToDouble(Console.ReadLine());

        if (a <= 0)
        {
            Console.WriteLine("Ошибка: a должно быть больше 0");
            return;
        }

        if (Math.Abs(a - 2) < 1e-9)
        {
            Console.WriteLine("Ошибка: a не может быть равно 2 (деление на ноль)");
            return;
        }

        double z1 = ((a + 2) / Math.Sqrt(2 * a)
                      - a / Math.Sqrt(2 * a + 2)
                      + 2 / (a - Math.Sqrt(2 * a)))
                    * (Math.Sqrt(a) - Math.Sqrt(2)) / (a + 2);

        double z2 = 1 / Math.Sqrt(a + Math.Sqrt(2));

        Console.WriteLine($"\nРезультаты:");
        Console.WriteLine($"z1 = {z1:F6}");
        Console.WriteLine($"z2 = {z2:F6}");
        Console.WriteLine($"Разность |z1 - z2| = {Math.Abs(z1 - z2):E10}");

        if (Math.Abs(z1 - z2) < 1e-9)
            Console.WriteLine("\nФормулы дают одинаковый результат (в пределах точности).");
        else
            Console.WriteLine("\nФормулы дают разные результаты (возможно, из-за погрешности или области определения).");
    }
}