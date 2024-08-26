/*
Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

Example 1:

Input: rowIndex = 3
Output: [1,3,3,1]
Example 2:

Input: rowIndex = 0
Output: [1]
Example 3:

Input: rowIndex = 1
Output: [1,1]

*/

public class GetRow
{
    public IList<int> GetRowCal(int rowIndex) {
        List<int> result = new List<int>();
        long prev = 1;
        result.Add((int)prev);
        for (int j = 1; j <= rowIndex; j++) {
            long current = (long) (prev * (rowIndex - j + 1)) / j; // nCr = (nCr-1 * (n - r + 1))/r
            prev = current;
            result.Add((int)current);
        }
        return result;
    }
}