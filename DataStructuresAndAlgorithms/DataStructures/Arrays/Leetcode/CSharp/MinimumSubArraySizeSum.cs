/*
Given an array of positive integers nums and a positive integer target, return the minimal length of a 
contiguous subarray [numsl, numsl+1, ..., numsr-1, numsr] of which the sum is greater than or equal to target. 
If there is no such subarray, return 0 instead.

Input: target = 7, nums = [2,3,1,2,4,3]
Output: 2
Explanation: The subarray [4,3] has the minimal length under the problem constraint.

Input: target = 11, nums = [1,1,1,1,1,1,1,1]
Output: 0
*/
public class MinSubArrayLen
{
    public int MinSubArrayLenCal(int target, int[] nums) {
       // Array.Sort(nums);
        int winStart = 0,
            sum = 0,
            minLength = Int32.MaxValue;
        
        for(int winEnd = 0; winEnd < nums.Length; winEnd++) {
            sum += nums[winEnd];
            
            while(sum >= target) {
                minLength = Math.Min(minLength, winEnd + 1 - winStart);
                sum -= nums[winStart];
                winStart++;
            }
        }
        
        return minLength != Int32.MaxValue ? minLength : 0;
        
    }
}

