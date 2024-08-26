/*
Given the root of a binary tree, return the postorder traversal of its nodes' values.

 

Example 1:


Input: root = [1,null,2,3]
Output: [3,2,1]
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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> sol=new List<int>();
        PostOrder(root,sol);
        return sol;
    }
    
    public void PostOrder(TreeNode root,List<int> sol){
        if(root==null) 
            return; 

 

     PostOrder(root.left,sol); 

     PostOrder(root.right,sol); 
    
 

      sol.Add(root.val);
    }
}