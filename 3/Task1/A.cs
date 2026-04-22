class A
{
    public int a;
    public int b;

    public A(int valA, int valB)
    {
        a = valA;
        b = valB;
    }
    public double CalculateExpression()
    {
        return a * Math.Sqrt(b) - Math.Sin(a);
    }

    public double CubeOfProduct()
    {
        return Math.Pow(a * b, 3);
    }
}
