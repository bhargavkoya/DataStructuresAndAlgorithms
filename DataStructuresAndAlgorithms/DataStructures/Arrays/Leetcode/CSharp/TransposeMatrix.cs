/*
Given a 2D integer array matrix, return the transpose of matrix.

The transpose of a matrix is the matrix flipped over its main diagonal, switching the matrix's row and column indices.


*/


public class Transpose
{
    public int[][] TransposeCal(int[][] matrix) {
      if (matrix.Length != matrix[0].Length)
        {
            var result = new int[matrix[0].Length][];

            for (int i = 0; i < matrix[0].Length; i++)
            {
                result[i] = new int[matrix.Length];

                for (int j = 0; j < matrix.Length; j++)
                {
                    result[i][j] = matrix[j][i]; 
                }
            }

            return result;
        }
        else
        {
            // if matrix is square

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i; j < matrix.Length; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }

            return matrix;
        }

    }
}