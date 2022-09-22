/*
Given a binary tree root, return the maximum sum of all keys of any sub-tree which is also a Binary Search Tree (BST).

Assume a BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.
 

Example 1:



Input: root = [1,4,3,2,4,2,5,null,null,null,null,null,null,4,6]
Output: 20
Explanation: Maximum sum in a valid Binary search tree is obtained in root node with key equal to 3.
Example 2:



Input: root = [4,3,null,1,2]
Output: 2
Explanation: Maximum sum in a valid Binary search tree is obtained in a single root node with key equal to 2.
Example 3:

Input: root = [-4,-2,-5]
Output: 0
Explanation: All values are negatives. Return an empty BST.

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
public class Pair{
    public int min;
    public int max;
    public int maxsum;
    public bool isbst;
    
    public Pair(){
        min = Int32.MaxValue;
        max = Int32.MinValue;
        maxsum = 0;
        isbst = false;
    }
}

public class Solution {
    int res=0;
    public int MaxSumBST(TreeNode root) {
        helper(root);
        return res;
        
    }
 public Pair helper(TreeNode root) {
        if(root == null){
            Pair obj = new Pair();
            obj.isbst = true;
            return obj;
        }
        
        Pair left = helper(root.left);
        Pair right = helper(root.right);
        
        Pair curr = new Pair();
        curr.isbst = (left.isbst && right.isbst) && root.val > left.max && root.val < right.min;
          
        curr.max = Math.Max(root.val,right.max);
        curr.min = Math.Min(root.val,left.min);  
        
        if(curr.isbst == true){          
            curr.maxsum = root.val+left.maxsum+right.maxsum;
            res = Math.Max(res,curr.maxsum);
        }
        
        else{
            curr.maxsum = Math.Max(left.maxsum,right.maxsum);
            res = Math.Max(res,curr.maxsum);
        }            
        
        return curr;
    }

}