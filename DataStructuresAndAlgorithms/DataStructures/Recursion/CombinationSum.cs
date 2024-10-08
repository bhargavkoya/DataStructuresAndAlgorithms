/*
Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.

The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.

 

Example 1:

Input: candidates = [2,3,6,7], target = 7
Output: [[2,2,3],[7]]
Explanation:
2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
7 is a candidate, and 7 = 7.
These are the only two combinations.
Example 2:

Input: candidates = [2,3,5], target = 8
Output: [[2,2,2,2],[2,3,3],[3,5]]
Example 3:

Input: candidates = [2], target = 1
Output: []

*/
public class CombinationSum
{
    
    public void combination(int[] candidates, int target, List<int> currComb, int currSum, int currIndex, List<IList<int>> ans){
        if(currSum>target) return; //backtrack
        if(currSum==target){
            ans.Add(new List<int>(currComb)); //store the solution and backtrack
            return;
        }
        
        for(int i=currIndex; i<candidates.Length; i++){ //try all possible options for the next level
            currComb.Add(candidates[i]); //put 1 option into the combination
            currSum+=candidates[i];
            combination(candidates, target, currComb, currSum, i, ans); //try with this combination, whether it gives a solution or not.
            currComb.RemoveAt(currComb.Count-1); //when this option backtrack to here, remove this and go on to the next option.
            currSum-=candidates[i];
        }
        
    }

    public IList<IList<int>> CombinationSumCal(int[] candidates, int target) {
        List<IList<int>> ans=new List<IList<int>>();
        combination(candidates,target,new List<int>(),0,0,ans);
        return ans;
    }
}