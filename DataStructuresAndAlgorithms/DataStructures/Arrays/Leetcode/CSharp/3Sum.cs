/*
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

 

Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Example 2:

Input: nums = []
Output: []
Example 3:

Input: nums = [0]
Output: []

*/

public class ThreeSum {
    public IList<IList<int>> ThreeSumCal(int[] nums) {
        var res=new List<IList<int>>();
        Array.Sort(nums);
        
        for(int i=0;i<nums.Length;i++){
            int a = nums[i];
            if(i>0 && a==nums[i-1])
                continue;
            int left=i+1,right=nums.Length-1;
            while(left<right){
                int threesum=a+nums[left]+nums[right];
                if(threesum>0)
                    right--;
                else if(threesum<0)
                    left++;
                else
                {
                    res.Add(new List<int>(){a,nums[left],nums[right]});
                    left++;
                    while(nums[left]==nums[left-1] && left<right){
                        left++;
                        
                    }
                }
            }
        }
        
        return res;
    }
}