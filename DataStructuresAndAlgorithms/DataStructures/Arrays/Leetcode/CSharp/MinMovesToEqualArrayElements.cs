/*
Given an integer array nums of size n, return the minimum number of moves required to make all array elements equal.

In one move, you can increment n - 1 elements of the array by 1.

 

Example 1:

Input: nums = [1,2,3]
Output: 3
Explanation: Only three moves are needed (remember each move increments two elements):
[1,2,3]  =>  [2,3,3]  =>  [3,4,3]  =>  [4,4,4]
Example 2:

Input: nums = [1,1,1]
Output: 0

*/
public class MinMoves
{
    public int MinMovesCal(int[] nums) {
        int sum=0,n,minval=nums[0];
        n=nums.Length;
        for(int i=0;i<n;i++)
        {
            sum+=nums[i];
            minval=Math.Min(nums[i],minval);
        }
        sum=sum-(n*minval);
        return sum;

    }
}