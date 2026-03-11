using System;

class Program
{
    static void Main(string[] args)
    {
        double[] v1 = { 3, -7 };
        double[] v2 = { -9, 1, -4 };
        double[] v3 = { 0, 0 };
        double[] v4 = { 1, 2, 3, 4 };
        double[] v5 = { 6 };
        double[] v6 = { };

        Console.WriteLine(VectorMath.Magnitude(v1));
        Console.WriteLine(VectorMath.Magnitude(v2));
        Console.WriteLine(VectorMath.Magnitude(v3));
        Console.WriteLine(VectorMath.Magnitude(v4));
        Console.WriteLine(VectorMath.Magnitude(v5));
        Console.WriteLine(VectorMath.Magnitude(v6));
    }
}