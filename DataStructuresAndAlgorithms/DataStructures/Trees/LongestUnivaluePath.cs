/*
Given the root of a binary tree, return the length of the longest path, where each node in the path has the same value. This path may or may not pass through the root.

The length of the path between two nodes is represented by the number of edges between them.

 

Example 1:


Input: root = [5,4,5,1,1,null,5]
Output: 2
Explanation: The shown image shows that the longest path of the same value (i.e. 5).
Example 2:


Input: root = [1,4,5,4,4,null,5]
Output: 2
Explanation: The shown image shows that the longest path of the same value (i.e. 4).

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
    
    int pathLen = 0;
    public int LongestUnivaluePath(TreeNode root) {
        
        
        Dfs(root, int.MaxValue);
        
        return pathLen;
    }
    
    public int Dfs(TreeNode node, int parentVal) 
    {
        if(node == null) return 0;

        var left = Dfs(node.left,  node.val);
        var right = Dfs(node.right, node.val);

        pathLen = Math.Max(pathLen, left + right);

        return node.val != parentVal ? 0 : 1 + Math.Max(left, right);
    }

    
    
}