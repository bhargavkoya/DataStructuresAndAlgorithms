/*
Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.

We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

You must solve this problem without using the library's sort function.

 

Example 1:

Input: nums = [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]
Example 2:

Input: nums = [2,0,1]
Output: [0,1,2]

*/
public class Solution {
    public void SortColors(int[] nums) {
        int z = 0; int o = 0;int t = 0;
        foreach(var item in nums){
            if(item ==0) z++;
            else if(item == 1)o++;
            else if(item ==2)t++;
        }
       for(int i =0;i<nums.Length;i++){
           if(i <z) nums[i] =0;
           else if( i <o+z) nums[i] =1;
           else if(i <t+o+z) nums[i] =2;
       }

    }
}