/*
Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any two different nodes in the tree.

 

Example 1:


Input: root = [4,2,6,1,3]
Output: 1
Example 2:


Input: root = [1,0,48,null,null,12,49]
Output: 1

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
    public int GetMinimumDifference(TreeNode root) {
        List<int> res=new List<int>();
        inOrder(root,res);
        res.Sort();

        int min=Int32.MaxValue;
        for(int i=0;i<res.Count-1;i++){
            min=Math.Min(min,res[i+1]-res[i]);
        }
        return min;
    }
    public void inOrder(TreeNode root,List<int> res){
        if(root!=null){
            inOrder(root.left,res);
            res.Add(root.val);
            inOrder(root.right,res);
        }
    }
}