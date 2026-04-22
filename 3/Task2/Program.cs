using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Employee[] staff = DataGenerator.GenerateEmployees(5);
        Console.WriteLine("Список сотрудников:");
        Array.ForEach(staff, Console.WriteLine);

        Employee oldest = EmployeeAnalytics.FindOldestEmployee(staff);
        Console.WriteLine($"\nСамый старший: {oldest}");

        decimal avgSalary = EmployeeAnalytics.GetAverageSalary(staff);
        Console.WriteLine($"Средняя зарплата: {avgSalary:C}");

        Console.WriteLine("\nСотрудники старше 40 лет:");
        var experienced = EmployeeAnalytics.FilterByMinAge(staff, 40);
        Array.ForEach(experienced, Console.WriteLine);
    }
}
