using System;

/// <summary>
/// Matrix class
/// </summary>
public class Matrix
{
    /// <summary>
    /// Computes the square value of all integers of a matrix
    /// </summary>
    /// <param name="myMatrix">The matrix to square</param>
    /// <returns>A new matrix containing squared values</returns>
    public static int[,] Square(int[,] myMatrix)
    {
        if (myMatrix == null)
            return null;

        int rows = myMatrix.GetLength(0);
        int cols = myMatrix.GetLength(1);

        int[,] squareMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                squareMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }

        return squareMatrix;
    }
}
