/*
You are given an integer array nums and an array queries where queries[i] = [vali, indexi].

For each query i, first, apply nums[indexi] = nums[indexi] + vali, then print the sum of the even values of nums.

Return an integer array answer where answer[i] is the answer to the ith query.

 

Example 1:

Input: nums = [1,2,3,4], queries = [[1,0],[-3,1],[-4,0],[2,3]]
Output: [8,6,2,4]
Explanation: At the beginning, the array is [1,2,3,4].
After adding 1 to nums[0], the array is [2,2,3,4], and the sum of even values is 2 + 2 + 4 = 8.
After adding -3 to nums[1], the array is [2,-1,3,4], and the sum of even values is 2 + 4 = 6.
After adding -4 to nums[0], the array is [-2,-1,3,4], and the sum of even values is -2 + 4 = 2.
After adding 2 to nums[3], the array is [-2,-1,3,6], and the sum of even values is -2 + 6 = 4.
Example 2:

Input: nums = [1], queries = [[4,0]]
Output: [0]

*/
public class SumEvenAfterQueries
{
    public int[] SumEvenAfterQueriesCal(int[] nums, int[][] queries) {
        int sum = 0;
        for(int i = 0;i < nums.Length;i++){
            if(nums[i] % 2 == 0){
                sum += nums[i];
            }
        }
        List<int> ans=new List<int>();
        for(int i = 0;i < queries.Length;i++){
            int val = queries[i][0];
            int ind = queries[i][1];
            if(nums[ind] % 2 == 0){
                sum -= nums[ind];
            }
            nums[ind] += val;
            if(nums[ind] % 2 == 0){
                sum += nums[ind];
            }
            ans.Add(sum);
        }
        return ans.ToArray();

    }
    
   
}