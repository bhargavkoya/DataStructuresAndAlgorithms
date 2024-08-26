/*
Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

 

Example 1:

Input: nums = [4,3,2,7,8,2,3,1]
Output: [5,6]
Example 2:

Input: nums = [1,1]
Output: [2]

*/
public class FindDisappearedNumbers
{
    public IList<int> FindDisappearedNumbersCal(int[] nums) {
        foreach(var i in nums){
            int a=Math.Abs(i)-1;
            nums[a]=-1*Math.Abs(nums[a]);
        }
        List<int> res=new List<int>();
        for(int i = 0; i < nums.Length; i++){
            if(nums[i]>0){
                res.Add(i+1);
            }
        }
        return res;

    }
}