/*
Given the root of a binary tree, return the zigzag level order traversal of its nodes' values. (i.e., from left to right, then right to left for the next level and alternate between).

 

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: [[3],[20,9],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var res=new List<IList<int>>();
        Queue<TreeNode> q=new Queue<TreeNode>();
        q.Enqueue(root);
        bool iseven=true;
        while(q.Count>0){
            var size=q.Count;
            List<int> temp=new List<int>();
            
            for(int i=0;i<size;i++){
                var node=q.Dequeue();
                if(node!=null){
                    if(iseven)
                        temp.Add(node.val);
                    else
                        temp.Insert(0,node.val);
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
            
            
            iseven=!iseven;
            if(temp.Count>0)
                res.Add(temp);
        }
        
        return res;
    }
    
}