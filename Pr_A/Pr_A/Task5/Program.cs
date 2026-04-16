using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырёхзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int digit1 = number / 1000;           // тысячи
        int digit2 = (number / 100) % 10;     // сотни
        int digit3 = (number / 10) % 10;      // десятки
        int digit4 = number % 10;             // единицы

        int reversed = digit4 * 1000 + digit3 * 100 + digit2 * 10 + digit1;

        Console.WriteLine($"Исходное число: {number}");
        Console.WriteLine($"Число справа налево: {reversed}");
    }
}