using System;

class Program
{
    static void Main()
    {
        A obj = new A(2, 9);

        Console.WriteLine($"Поля класса: a = {obj.a}, b = {obj.b}");
        Console.WriteLine($"Результат выражения a*sqrt(b) - sin(a): {obj.CalculateExpression():F4}");
        Console.WriteLine($"Куб произведения a и b: {obj.CubeOfProduct()}");
    }
}
