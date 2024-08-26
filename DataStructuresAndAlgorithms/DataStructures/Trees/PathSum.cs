/*
Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.

A leaf is a node with no children.

 

Example 1:


Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
Output: true
Explanation: The root-to-leaf path with the target sum is shown.
Example 2:


Input: root = [1,2,3], targetSum = 5
Output: false
Explanation: There two root-to-leaf paths in the tree:
(1 --> 2): The sum is 3.
(1 --> 3): The sum is 4.
There is no root-to-leaf path with sum = 5.
Example 3:

Input: root = [], targetSum = 0
Output: false
Explanation: Since the tree is empty, there are no root-to-leaf paths.

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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root==null)
            return false;
        else if(root.left==null && root.right==null && targetSum-root.val==0)
            return true;
        else
            return HasPathSum(root.left,targetSum-root.val) || HasPathSum(root.right,targetSum-root.val);
    }
}

//or---------------------------------------------------------------------------------------------------------------------

public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root==null)
            return false;
        Stack<TreeNode> nodestack=new Stack<TreeNode>();
        Stack<int> sumstack=new Stack<int>();
        
        nodestack.Push(root);
        sumstack.Push(targetSum-root.val);
        
        while(nodestack.Count>0){
            var currentnode=nodestack.Pop();
            var currentsum=sumstack.Pop();
            
            if(currentnode.left==null && currentnode.right==null && currentsum==0)
                return true;
            
            if(currentnode.left!=null){
                nodestack.Push(currentnode.left);
                sumstack.Push(currentsum-currentnode.left.val);
            }
            if(currentnode.right!=null){
                nodestack.Push(currentnode.right);
                sumstack.Push(currentsum-currentnode.right.val);
            }
        }
        return false;
    }
}