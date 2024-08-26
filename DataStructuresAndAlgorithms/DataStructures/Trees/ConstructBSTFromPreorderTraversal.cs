/*
Given an array of integers preorder, which represents the preorder traversal of a BST (i.e., binary search tree), construct the tree and return its root.

It is guaranteed that there is always possible to find a binary search tree with the given requirements for the given test cases.

A binary search tree is a binary tree where for every node, any descendant of Node.left has a value strictly less than Node.val, and any descendant of Node.right has a value strictly greater than Node.val.

A preorder traversal of a binary tree displays the value of the node first, then traverses Node.left, then traverses Node.right.

 

Example 1:


Input: preorder = [8,5,1,7,10,12]
Output: [8,5,10,1,7,null,12]
Example 2:

Input: preorder = [1,3]
Output: [1,null,3]

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
    public TreeNode BstFromPreorder(int[] preorder) {
        TreeNode root = new TreeNode(preorder[0]);
        Stack<TreeNode> st=new Stack<TreeNode>();
        st.Push(root);
        
        for (int i = 1; i < preorder.Length; i++) 
        {
            TreeNode temp = new TreeNode(preorder[i]);
            if (temp.val < st.Peek().val)
            {
                st.Peek().left = temp;
                st.Push(temp);            
            }   
            else 
            {
                TreeNode prev=new TreeNode();
                while (st.Count>0 && st.Peek().val < temp.val) 
                {  
                    
                    prev = st.Peek(); 
                    st.Pop();
                }
                prev.right = temp;        
                st.Push(temp);            
            }   
        }
        return root;

    }
    
}