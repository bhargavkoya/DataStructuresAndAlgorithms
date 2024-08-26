/*
Given an array of integers nums and an integer k. A continuous subarray is called nice if there are k odd numbers on it.

Return the number of nice sub-arrays.

 

Example 1:

Input: nums = [1,1,2,1,1], k = 3
Output: 2
Explanation: The only sub-arrays with 3 odd numbers are [1,1,2,1] and [1,2,1,1].
Example 2:

Input: nums = [2,4,6], k = 1
Output: 0
Explanation: There is no odd numbers in the array.
Example 3:

Input: nums = [2,2,2,1,2,2,1,2,2,2], k = 2
Output: 16

*/
public class NumberOfSubarrays
{
    public int NumberOfSubarraysCal(int[] nums, int k) {
      int ans = 0;
      int n = nums.Length;
      int oddCount = 0;
      int slidingEnd = 0, slidingStart = 0;
      Queue<int> q=new Queue<int>();
      while (slidingEnd < n) {
        if (nums[slidingEnd] % 2 != 0) {
          ++oddCount;
          q.Enqueue(slidingEnd);
        }
        if (oddCount > k) {
          while (oddCount != k) {
            if (nums[slidingStart] % 2 != 0) --oddCount;
            ++slidingStart;
          }
          q.Dequeue();
        }
        if (oddCount == k) ans += (q.Peek() - slidingStart + 1);
        ++slidingEnd;
      }
      return ans;

    }
    
}