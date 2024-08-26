/*
Given the root of a binary tree, return the sum of all left leaves.

A leaf is a node with no children. A left leaf is a leaf that is the left child of another node.

 

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 24
Explanation: There are two left leaves in the binary tree, with values 9 and 15 respectively.
Example 2:

Input: root = [1]
Output: 0

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
    public int SumOfLeftLeaves(TreeNode root) {
        return SumLeft(root,false);
    }
    
    int SumLeft(TreeNode root, bool isLeftSubtree) 
    { 
        if(root==null) 
            return 0; 

        if(root.left==null && root.right==null) 
        { 
                if(isLeftSubtree) 
                    return root.val; 

               return 0; 
        } 

        return SumLeft(root.left,true)+SumLeft(root.right,false); 

    } 
}