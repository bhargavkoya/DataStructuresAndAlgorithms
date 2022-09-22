/*
Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.

Each number in candidates may only be used once in the combination.

Note: The solution set must not contain duplicate combinations.

 

Example 1:

Input: candidates = [10,1,2,7,6,1,5], target = 8
Output: 
[
[1,1,6],
[1,2,5],
[1,7],
[2,6]
]
Example 2:

Input: candidates = [2,5,2,1,2], target = 5
Output: 
[
[1,2,2],
[5]
]

*/
public class Solution {
    public  void solve(int idx, int target, int[] nums, List<int> path, List<IList<int>> res){
        if(target == 0){
            res.Add(new List<int>(path));
            return;
        }
        if(idx ==nums.Length) return;
        
        for(int i = idx; i < nums.Length; i++){
            if(i > idx && nums[i] == nums[i-1]) continue;
            if(nums[i] > target) break;
            path.Add(nums[i]);
            solve(i+1, target-nums[i], nums, path, res);
            path.RemoveAt(path.Count-1);
        }
        return ;
    }

    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        List<IList<int>> res=new List<IList<int>>();
        Array.Sort(candidates);
        solve(0,target,candidates,new List<int>(),res);
        return res;
    }
}