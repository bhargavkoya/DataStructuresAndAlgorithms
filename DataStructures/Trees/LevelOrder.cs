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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var res=new List<IList<int>>();
        Queue<TreeNode> q=new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0){
            var size=q.Count;
            List<int> temp=new List<int>();
            
            for(int i=0;i<size;i++){
                var node=q.Dequeue();
                if(node!=null){
                    temp.Add(node.val);
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
            if(temp.Count>0)
                res.Add(temp);
        }
        
        return res;
    }
}