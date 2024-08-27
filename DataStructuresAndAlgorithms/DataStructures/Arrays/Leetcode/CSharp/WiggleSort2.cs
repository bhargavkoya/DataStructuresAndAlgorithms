/*Given an integer array nums, reorder it such that nums[0] < nums[1] > nums[2] < nums[3]....

You may assume the input array always has a valid answer.

 

Example 1:

Input: nums = [1,5,1,1,6,4]
Output: [1,6,1,5,1,4]
Explanation: [1,4,1,5,1,6] is also accepted.
Example 2:

Input: nums = [1,3,2,2,3,1]
Output: [2,3,1,3,1,2]
*/

public class WiggleSort
{
    public void WiggleSortCal(int[] nums) {
        Array.Sort(nums);
        int[] res=new int[nums.Length];
        int j=nums.Length-1;
        for(int i=1;i<nums.Length;i+=2){
            res[i]=nums[j];
            j=j-1;
        }
        int k=0;
        while(j>=0 && k<nums.Length){
            res[k]=nums[j];
            j--;
            k=k+2;
        }
       Array.Copy(res,nums,nums.Length);
    }
}