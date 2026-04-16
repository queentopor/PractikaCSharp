using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = b / a;

        Console.WriteLine($"{b:F2} / {a:F2} = {result:F2}");
        Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
        Console.ReadKey();
    }
}