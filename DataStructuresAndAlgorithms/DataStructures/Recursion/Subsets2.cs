/*
Given an integer array nums that may contain duplicates, return all possible subsets (the power set).

The solution set must not contain duplicate subsets. Return the solution in any order.

 

Example 1:

Input: nums = [1,2,2]
Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]
Example 2:

Input: nums = [0]
Output: [[],[0]]

*/
public class SubsetsWithDup
{
   public  void findSubsets(int ind, int[] nums, List<int> ds, List<IList<int>> ansList) {
        ansList.Add(new List<int>(ds)); 
        for(int i = ind;i<nums.Length;i++) {
            if(i!=ind && nums[i] == nums[i-1]) continue; 
            ds.Add(nums[i]); 
            findSubsets(i+1, nums, ds, ansList); 
            ds.RemoveAt(ds.Count - 1);
        }
        
    }

    public IList<IList<int>> SubsetsWithDupCal(int[] nums) {
        List<IList<int>> ansList=new List<IList<int>>();
        Array.Sort(nums);
        findSubsets(0,nums,new List<int>(),ansList);
        return ansList;
    }
}