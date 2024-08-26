/*
Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.

 

Example 1:


Input: root = [1,2,3,null,5,null,4]
Output: [1,3,4]
Example 2:

Input: root = [1,null,3]
Output: [1,3]
Example 3:

Input: root = []
Output: []

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
    public IList<int> RightSideView(TreeNode root) {
        var list = new List<int>(); 
        if(root == null) return list; 

        var queue = new Queue<TreeNode>(); 
        queue.Enqueue(root); 

        while(queue.Count!=0) 
        { 
            var size = queue.Count; 

            for(int i = 0; i < size;i++) 
            { 
                var current = queue.Dequeue(); 

                 if(i == size-1) 
                    list.Add(current.val); 

                if(current.left!=null) 
                { 
                    queue.Enqueue(current.left);  
                } 

                if(current.right!=null) 
                { 

                   queue.Enqueue(current.right); 
                } 

            } 

        } 

        return list; 

    } 
}
