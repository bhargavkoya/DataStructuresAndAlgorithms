/*
Given a collection of numbers, nums, that might contain duplicates, return all possible unique permutations in any order.

 

Example 1:

Input: nums = [1,1,2]
Output:
[[1,1,2],
 [1,2,1],
 [2,1,1]]
Example 2:

Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]

*/
public class PermuteUnique
{
    public IList<IList<int>> PermuteUniqueCal(int[] nums) {
         List<IList<int>> res=new List<IList<int>>();
        Array.Sort(nums);
        helper(nums,new List<int>(),new List<int>(),res);
        return res;
    }
    
    public void helper(int[] nums,List<int> curr,List<int> consumed,List<IList<int>> res){
        if(curr.Count == nums.Length){
            res.Add(new List<int>(curr));
        }
        
        for(int i=0;i<nums.Length;i++){
            if(!consumed.Contains(i)){
                curr.Add(nums[i]);
                consumed.Add(i);
                helper(nums,curr,consumed,res);
                curr.RemoveAt(curr.Count-1);
                consumed.RemoveAt(consumed.Count-1);
                while(i<nums.Length-1 && nums[i] == nums[i+1]){
                        i++;
                }
            }
        }
    }

}