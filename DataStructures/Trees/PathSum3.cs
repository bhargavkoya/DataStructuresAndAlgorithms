/*
Given the root of a binary tree and an integer targetSum, return the number of paths where the sum of the values along the path equals targetSum.

The path does not need to start or end at the root or a leaf, but it must go downwards (i.e., traveling only from parent nodes to child nodes).

 

Example 1:


Input: root = [10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8
Output: 3
Explanation: The paths that sum to 8 are shown.
Example 2:

Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
Output: 3

*/
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int count=0;
    public int PathSum(TreeNode root, int targetSum) {
         if(root==null)
            return 0;
       return PathSum(root.left,targetSum)+PathSum(root.right,targetSum)+PathSum_a(root,targetSum);
    }
    public int PathSum_a(TreeNode root,long targetSum){
        if(root==null)
            return 0;
        long res=0;
        if(root.val==targetSum) res++;
        res+=PathSum_a(root.left,targetSum-root.val);
        res+=PathSum_a(root.right,targetSum-root.val);
        return (int)res;
    }
}