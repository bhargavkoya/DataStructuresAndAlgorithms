/*
Given the root of a binary tree, return the inorder traversal of its nodes' values.

 

Example 1:


Input: root = [1,null,2,3]
Output: [1,3,2]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [1]
Output: [1]

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
    List<int> res=new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        inOrder(root);
        return res;
    }
    void inOrder(TreeNode root){
        if(root!=null){
            inOrder(root.left);
            res.Add(root.val);
            inOrder(root.right);
        }
    }

}