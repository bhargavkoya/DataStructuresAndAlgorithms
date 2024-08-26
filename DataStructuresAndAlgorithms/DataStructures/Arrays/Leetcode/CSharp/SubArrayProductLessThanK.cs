/*Given an array of integers nums and an integer k, return the number of contiguous subarrays where the product of all the elements in the subarray is strictly less than k.

 

Example 1:

Input: nums = [10,5,2,6], k = 100
Output: 8
Explanation: The 8 subarrays that have product less than 100 are:
[10], [5], [2], [6], [10, 5], [5, 2], [2, 6], [5, 2, 6]
Note that [10, 5, 2] is not included as the product of 100 is not strictly less than k.
Example 2:

Input: nums = [1,2,3], k = 0
Output: 0
*/
public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
            int start=0,end=0;
            int count=0;
            int product=nums[0];
            while(start < nums.Length && end < nums.Length){

                if(product < k) {
                    end++;

                    if(end>=start){
                        count+=(end-start);
                    }

                    if(end < nums.Length){
                        product = product * nums[end];
                    }


                }
                else{

                    product=(product/nums[start++]);

                }
            }
            return count;

    }
}