/*
Given an integer array nums and an integer k, return the kth largest element in the array.

Note that it is the kth largest element in the sorted order, not the kth distinct element.

You must solve it in O(n) time complexity.

 

Example 1:

Input: nums = [3,2,1,5,6,4], k = 2
Output: 5
Example 2:

Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
Output: 4

*/
public class FindKthLargest
{
    public int FindKthLargestCal(int[] nums, int k) {
        return QuickSelect(nums,0,nums.Length-1,k);
    }
    public int QuickSelect(int[] nums,int l,int r,int k){
        int pivot=nums[r];
        int p=l;
        for(int i=l;i<r;i++){
            if(nums[i]<=pivot){
                int temp=nums[i];
                nums[i]=nums[p];
                nums[p]=temp;
                p+=1;
            }
        }
        int temp1=nums[p];
        nums[p]=nums[r];
        nums[r]=temp1;
        
        if(p>nums.Length-k)
            return QuickSelect(nums,l,p-1,k);
        else if(p<nums.Length-k)
            return QuickSelect(nums,p+1,r,k);
        else 
            return nums[p];
    }
}