using System;

/// <summary>
/// Class containing vector math methods
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the magnitude of a 2D or 3D vector
    /// </summary>
    /// <param name="vector">The vector as a double array</param>
    /// <returns>Magnitude rounded to nearest hundredth, or -1 if invalid</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
            return -1;

        double sumSquares = 0;
        foreach (double component in vector)
        {
            sumSquares += component * component;
        }

        double length = Math.Sqrt(sumSquares);
        return Math.Round(length, 2);
    }
}