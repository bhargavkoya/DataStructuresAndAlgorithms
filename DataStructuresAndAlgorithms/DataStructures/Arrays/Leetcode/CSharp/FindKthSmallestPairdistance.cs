/*
The distance of a pair of integers a and b is defined as the absolute difference between a and b.

Given an integer array nums and an integer k, return the kth smallest distance among all the pairs nums[i] and nums[j] where 0 <= i < j < nums.length.

 

Example 1:

Input: nums = [1,3,1], k = 1
Output: 0
Explanation: Here are all the pairs:
(1,3) -> 2
(1,1) -> 0
(3,1) -> 2
Then the 1st smallest distance pair is (1,1), and its distance is 0.
Example 2:

Input: nums = [1,1,1], k = 2
Output: 0
Example 3:

Input: nums = [1,6,1], k = 3
Output: 5

*/
public class SmallestDistancePair
{
    public int check(int[] nums,int diff){
        int res=0;
        for(int i=1,j=0;i<nums.Length;i++){
            while(nums[i]-nums[j]>diff) j++;
            res+=i-j;
        }
        return res;
    }
    public int SmallestDistancePairCal(int[] nums, int k) {
         int n = nums.Length;
        Array.Sort(nums);
        
        int l = 0, r = nums[n-1] - nums[0];
        while (l < r) {
            int mid = (l + r) / 2;
            if (check(nums, mid) >= k) {
                r = mid;
            } else {
                l = mid + 1;
            }
        }
        
        return l;

    }
}