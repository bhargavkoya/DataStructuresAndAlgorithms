/*
Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

 

Example 1:

Input: nums = [3,2,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2.
The third distinct maximum is 1.
Example 2:

Input: nums = [1,2]
Output: 2
Explanation:
The first distinct maximum is 2.
The second distinct maximum is 1.
The third distinct maximum does not exist, so the maximum (2) is returned instead.
Example 3:

Input: nums = [2,2,3,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2 (both 2's are counted together since they have the same value).
The third distinct maximum is 1.


*/

public class ThirdMax
{
    public int ThirdMaxCal(int[] nums) {
        long max=long.MinValue;
        long secondmax=max;
        long thirdmax=secondmax;
     for(int i = 0 ;i<nums.Length;i++){
            if(nums[i]>max){
                thirdmax = secondmax;
                secondmax = max;
                max = nums[i];
            }
            else if(nums[i]<max && nums[i]>secondmax){
                thirdmax = secondmax;
                secondmax = nums[i];
            }
            else if(nums[i]<secondmax && nums[i]>thirdmax){
                thirdmax = nums[i];
            }
        }
        return  thirdmax==long.MinValue ? (int) max : (int) thirdmax;



    }
}