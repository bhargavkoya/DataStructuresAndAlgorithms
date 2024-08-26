/*
Given an integer array nums and an integer k, return true if nums has a continuous subarray of size at least two whose elements sum up to a multiple of k, or false otherwise.

An integer x is a multiple of k if there exists an integer n such that x = n * k. 0 is always a multiple of k.

 

Example 1:

Input: nums = [23,2,4,6,7], k = 6
Output: true
Explanation: [2, 4] is a continuous subarray of size 2 whose elements sum up to 6.
Example 2:

Input: nums = [23,2,6,4,7], k = 6
Output: true
Explanation: [23, 2, 6, 4, 7] is an continuous subarray of size 5 whose elements sum up to 42.
42 is a multiple of 6 because 42 = 7 * 6 and 7 is an integer.
Example 3:

Input: nums = [23,2,6,4,7], k = 13
Output: false

*/
public class CheckSubarraySum
{
    public bool CheckSubarraySumCal(int[] nums, int k) {
        //so question says that if it has subaaray sum that is always a multiple of k
        //otherwise false
        //so we take hashmap to store value of sum at ith position
        //so we add sum to the and check if is multipleof k by dividing by k 
        //if sum ==0 and check i>0 then it is true 
        //another condition is if we contains sum in map and ig i-mp.get(sum)->value >1(checking the length is greater          than 1 as it is said atleast size should be two) so it is true
        Dictionary<int,int> mp=new Dictionary<int,int>();
        int sum=0;
        for(int i=0;i<nums.Length;i++){
            sum=sum+nums[i];
            sum=sum%k;
            if(sum==0 && i>0){
                return true;
            }
            //here we are checking that sum contains sum and length is greter than one 
            if(mp.ContainsKey(sum) && (i-mp[sum])>1){
                return true;
            }
            
            if(!mp.ContainsKey(sum)){
                mp.Add(sum,i);
            }
        }
        return false;

    }
}