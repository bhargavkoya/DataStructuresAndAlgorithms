/*Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.

Return the sum of the three integers.

You may assume that each input would have exactly one solution.

 

Example 1:

Input: nums = [-1,2,1,-4], target = 1
Output: 2
Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
Example 2:

Input: nums = [0,0,0], target = 1
Output: 0
*/
public class ThreeSumClosest
{
    public int ThreeSumClosestCal(int[] nums, int target) {
        Array.Sort(nums);
        int n=nums.Length;
        int res=nums[0]+nums[1]+nums[n-1];
        for(int i=0;i<n;i++){
            int left=i+1;
            int right=n-1;
            
            while(left<right){
                int sum=nums[i]+nums[left]+nums[right];
                if(sum<target){
                   left++;
                }else{
                   right--;
                }
                
                if(Math.Abs(sum-target)<Math.Abs(res-target))  
                    res=sum;
            }
        }
        return res;

    }
}