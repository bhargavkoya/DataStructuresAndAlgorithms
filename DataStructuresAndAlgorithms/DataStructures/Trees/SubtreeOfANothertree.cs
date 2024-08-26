/*
Given the roots of two binary trees root and subRoot, return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.

A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. The tree tree could also be considered as a subtree of itself.

 

Example 1:


Input: root = [3,4,5,1,2], subRoot = [4,1,2]
Output: true
Example 2:


Input: root = [3,4,5,1,2,null,null,null,null,0], subRoot = [4,1,2]
Output: false

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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(subRoot==null)
           return true;
        if(root==null)
            return false;
        if(root.val==subRoot.val && isSameTree(root,subRoot))
            return true;
        return isSameTree(root.left,subRoot) || isSameTree(root.right,subRoot);
    }
    public bool isSameTree(TreeNode p,TreeNode q){
       if(p==null && q==null)
           return true;
        if(p==null || q==null)
            return false;
        if(p.val==q.val && isSameTree(p.left,q.left) && isSameTree(p.right,q.right))
            return true;
        return false;

    }
}