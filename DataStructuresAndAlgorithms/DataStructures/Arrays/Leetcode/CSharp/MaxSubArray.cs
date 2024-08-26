/*
Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

A subarray is a contiguous part of an array.

 

Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
Example 2:

Input: nums = [1]
Output: 1
Example 3:

Input: nums = [5,4,-1,7,8]
Output: 23

*/
public class MaxSubArray
{
    public int MaxSubArrayCal(int[] nums) {
        int curMax=0,finalMax=int.MinValue;
        if(nums.Length==1)return nums[0];
        for(int i=0;i<nums.Length;i++){
            curMax=Math.Max(nums[i],curMax+nums[i]);
            finalMax=Math.Max(finalMax,curMax);
        }
        return finalMax;
    }
}