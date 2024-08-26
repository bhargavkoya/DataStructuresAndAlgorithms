/*
You are given the root of a binary search tree (BST), where the values of exactly two nodes of the tree were swapped by mistake. Recover the tree without changing its structure.

 

Example 1:


Input: root = [1,3,null,null,2]
Output: [3,1,null,null,2]
Explanation: 3 cannot be a left child of 1 because 3 > 1. Swapping 1 and 3 makes the BST valid.
Example 2:


Input: root = [3,1,4,null,null,2]
Output: [2,1,4,null,null,3]
Explanation: 2 cannot be in the right subtree of 3 because 2 < 3. Swapping 2 and 3 makes the BST valid.

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
    public TreeNode prev=null;
    public TreeNode first=null;
    public TreeNode middle=null;
    public TreeNode last=null;
    
    public void RecoverTree(TreeNode root) {
        inorder(root);
        if(first!=null && last!=null)
            swap(first,last);
        else if(first!=null && middle!=null)
            swap(first,middle);
    }
    public void inorder(TreeNode root){
        if(root == null) return;
        
        inorder(root.left);
        
        if(prev!=null && prev.val > root.val){
            
            
            if(first == null){
                
                first = prev;
                middle = root;
            }
            else{
                last = root;
            }
        }
        
        prev = root;
        inorder(root.right);
    }

    public void swap(TreeNode n1, TreeNode n2){
        int temp = n1.val;
        n1.val = n2.val;
        n2.val = temp;
    }

}