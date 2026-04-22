public static class DataGenerator
{
    private static readonly string[] Names = { "Иван", "Мария", "Алексей", "Елена", "Петр" };

    public static Employee[] GenerateEmployees(int count)
    {
        var random = new Random();
        var result = new Employee[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = new Employee
            {
                Name = Names[random.Next(Names.Length)],
                Age = random.Next(18, 65),
                Salary = random.Next(30000, 150000)
            };
        }
        return result;
    }
}
