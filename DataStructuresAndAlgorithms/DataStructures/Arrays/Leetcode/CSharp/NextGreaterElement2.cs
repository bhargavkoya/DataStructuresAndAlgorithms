/*
Given a circular integer array nums (i.e., the next element of nums[nums.length - 1] is nums[0]), return the next greater number for every element in nums.

The next greater number of a number x is the first greater number to its traversing-order next in the array, which means you could search circularly to find its next greater number. If it doesn't exist, return -1 for this number.

 

Example 1:

Input: nums = [1,2,1]
Output: [2,-1,2]
Explanation: The first 1's next greater number is 2; 
The number 2 can't find next greater number. 
The second 1's next greater number needs to search circularly, which is also 2.
Example 2:

Input: nums = [1,2,3,4,3]
Output: [2,3,4,-1,4]

*/
public class NextGreaterElements
{
    public int[] NextGreaterElementsCal(int[] nums) {
        int n = nums.Length;
        int[] ans=new int[n];
        for(int k=0;k<n;k++){
            ans[k]=-1;
        }
        Stack<int> s=new Stack<int>();
        for(int j = n-1; j >= 0; j--)  s.Push(nums[j]);
        int i = n-1;
        while(i >= 0){
            while(!(s.Count==0) && s.Peek() <= nums[i])   s.Pop();
            
            if(!(s.Count==0))  ans[i] = s.Peek();
            s.Push(nums[i]);
            i--;
        }
        return ans;


    }
}