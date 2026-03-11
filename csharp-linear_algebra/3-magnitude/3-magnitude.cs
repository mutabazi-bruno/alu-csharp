using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            double result = Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1]);
            return Math.Round(result, 2);
        }
        else if (vector.Length == 3)
        {
            double result = Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]);
            return Math.Round(result, 2);
        }
        else
        {
            return -1;
        }
    }

    static void Main(string[] args)
    {
        double[] v2D = { 3, 9 };
        double[] v3D = { 7, -3, -9 };

        Console.WriteLine(Magnitude(v2D));   // 9.49
        Console.WriteLine(Magnitude(v3D));   // 11.79
    }
}