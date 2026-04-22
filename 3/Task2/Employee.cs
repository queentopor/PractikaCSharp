public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    public override string ToString() => $"{Name} ({Age} лет) - Зарплата: {Salary:C}";
}
