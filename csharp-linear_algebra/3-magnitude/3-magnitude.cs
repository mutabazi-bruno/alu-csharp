using System;

public class VectorMath
{
    /// <summary>
    /// Calculates and returns the length of a given vector.
    /// The vector can be 2D or 3D. If not, returns -1.
    /// The return value is rounded to the nearest hundredth.
    /// </summary>
    /// <param name="vector">Array representing the vector.</param>
    /// <returns>Length of the vector or -1 if invalid.</returns>
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