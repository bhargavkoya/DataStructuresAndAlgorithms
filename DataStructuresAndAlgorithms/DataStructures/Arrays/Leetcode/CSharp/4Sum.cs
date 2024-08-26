/*
Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:

0 <= a, b, c, d < n
a, b, c, and d are distinct.
nums[a] + nums[b] + nums[c] + nums[d] == target
You may return the answer in any order.

 

Example 1:

Input: nums = [1,0,-1,0,-2,2], target = 0
Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
Example 2:

Input: nums = [2,2,2,2,2], target = 8
Output: [[2,2,2,2]]

*/
public class FourSum
{
    public IList<IList<int>> FourSumCal(int[] nums, int target) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        
        for(int i=0; i<nums.Length-3; i++) {
            if(i > 0 && nums[i] == nums[i-1])
                continue;
            for(int j=i+1; j<nums.Length-2; j++) {
                if(j > i+1 && nums[j] == nums[j-1])
                    continue;
                int start = j+1;
                int end = nums.Length-1;
                long rem = (long)target-(nums[i]+nums[j]);
                
                while(start < end) {
                    if((nums[start]+nums[end]) == rem) {
                        List<int> list = new List<int>();
                        list.Add(nums[i]);
                        list.Add(nums[j]);
                        list.Add(nums[start]);
                        list.Add(nums[end]);
                        result.Add(list);
                        while(start < end && nums[start]==nums[start+1])
                            start++;
                        while(start < end && nums[end]==nums[end-1])
                            end--;
                        start++;
                        end--;
                    } else if((nums[start]+nums[end]) > rem) {
                        end--;
                    } else {
                        start++;
                    }
                }
            }
        }
        return result;

    }
}