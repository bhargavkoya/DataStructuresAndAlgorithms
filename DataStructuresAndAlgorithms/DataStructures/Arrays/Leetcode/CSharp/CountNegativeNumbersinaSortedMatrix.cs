/*
Given a m x n matrix grid which is sorted in non-increasing order both row-wise and column-wise, return the number of negative numbers in grid.

 

Example 1:

Input: grid = [[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]
Output: 8
Explanation: There are 8 negatives number in the matrix.
Example 2:

Input: grid = [[3,2],[1,0]]
Output: 0
*/
public class CountNegatives
{
    public int CountNegativesCal(int[][] grid) {
        int i=0,count=0;
        int j=grid[0].Length-1;
            while(i<grid.Length && j>=0){
               if(grid[i][j]<0){
                   count +=grid.Length - i;
                   j--;
               }else {
                    i++;
               }

            }

            return count;
        }
 
    
}