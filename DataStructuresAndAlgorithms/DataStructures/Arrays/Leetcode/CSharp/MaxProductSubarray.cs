/*
Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.

The test cases are generated so that the answer will fit in a 32-bit integer.

A subarray is a contiguous subsequence of the array.

 

Example 1:

Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.
Example 2:

Input: nums = [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.

*/
public class MaxProduct
{
    public int MaxProductCal(int[] nums) {
         
        if(nums.Length==0)return -1;
        int maxprod=1,minprod=1,res=nums.Max();
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==0){
                maxprod=1;
                minprod=1;
                continue;
            }
            int temp=maxprod*nums[i];
            
            maxprod=Math.Max(nums[i],Math.Max(nums[i]*minprod,nums[i]*maxprod));
            minprod=Math.Min(nums[i],Math.Min(nums[i]*minprod,temp));
            res=Math.Max(res,maxprod);
        }
        return res;

    }
}