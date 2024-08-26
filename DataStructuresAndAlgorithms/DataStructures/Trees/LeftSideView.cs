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

                 if(i == 0) 
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
