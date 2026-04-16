using System;

class Program
{
    static void Main()
    {
        double x = 1;

        // sin^2(x)
        double sinX = Math.Sin(x);
        double sinSquared = sinX * sinX;

        // sqrt(1 - sin^2(x)) = sqrt(cos^2(x)) = |cos(x)|
        double sqrtValue = Math.Sqrt(1 - sinSquared);  // то же самое, что Math.Abs(Math.Cos(x))

        // cos(2π/3)
        double cosValue = Math.Cos(2 * Math.PI / 3);

        // e^(4√x)
        double expValue = Math.Exp(4 * Math.Sqrt(x));

        // y = x^2 - (sqrt(1 - sin^2 x) / cos(2π/3)) * e^(4√x)
        double y = (x * x) - (sqrtValue / cosValue) * expValue;

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y:F6}");
    }
}