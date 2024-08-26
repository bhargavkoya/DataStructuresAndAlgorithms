/*
Given a binary tree, find its minimum depth.

The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

Note: A leaf is a node with no children.

 

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 2
Example 2:

Input: root = [2,null,3,null,4,null,5,null,6]
Output: 5

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
    public int MinDepth(TreeNode root) {
    if(root == null){
        return 0;
    }
   int minimum =0;
   if(root.left == null && root.right != null){
      minimum = 1 + MinDepth(root.right);
   }
    
    else if(root.right == null && root.left != null){
     minimum = 1 + MinDepth(root.left);
   }
    else{
        int ls = MinDepth(root.left);
        int rs = MinDepth(root.right);
       minimum = 1 + Math.Min(ls ,rs);
    }
    
    return minimum;

    }
}