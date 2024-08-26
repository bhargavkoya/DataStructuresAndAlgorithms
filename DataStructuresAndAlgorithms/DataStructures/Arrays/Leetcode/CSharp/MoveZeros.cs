/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]

*/


public class MoveZeroes
{
    public int[] MoveZeroesCal(int[] nums) {
        int start=0;
        if(nums.Length==0){
            Console.WriteLine(new int[]{0});
        }
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0){
                int temp=nums[start];
                nums[start]=nums[i];
                nums[i]=temp;
                start++;
            
            }
        }
        return nums;
        

    }
} 