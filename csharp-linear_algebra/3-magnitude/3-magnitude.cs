using System;

/// <summary>
/// Class containing vector math methods
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the magnitude of a 2D or 3D vector
    /// </summary>
    /// <param name="vector">The vector as a double array</param>
    /// <returns>The magnitude rounded to nearest hundredth, or -1 if invalid</returns>
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
        double[] v1 = { 3, -7 };
        double[] v2 = { -9, 1, -4 };
        double[] v3 = { 0, 0 };
        double[] v4 = { 1, 2, 3, 4 };
        double[] v5 = { 6 };
        double[] v6 = { };

        Console.WriteLine(Magnitude(v1));
        Console.WriteLine(Magnitude(v2));
        Console.WriteLine(Magnitude(v3));
        Console.WriteLine(Magnitude(v4));
        Console.WriteLine(Magnitude(v5));
        Console.WriteLine(Magnitude(v6));
    }
}