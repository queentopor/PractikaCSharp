public static class EmployeeAnalytics
{
    public static Employee FindOldestEmployee(Employee[] employees)
    {
        if (employees == null || employees.Length == 0) return null;

        Employee oldest = employees[0];
        foreach (var emp in employees)
        {
            if (emp.Age > oldest.Age) oldest = emp;
        }
        return oldest;
    }

    public static Employee[] SortBySalary(Employee[] employees)
    {
        return employees.OrderByDescending(e => e.Salary).ToArray();
    }

    public static Employee[] FilterByMinAge(Employee[] employees, int minAge)
    {
        return employees.Where(e => e.Age >= minAge).ToArray();
    }

    public static decimal GetAverageSalary(Employee[] employees)
    {
        return employees.Length == 0 ? 0 : employees.Average(e => e.Salary);
    }
}
