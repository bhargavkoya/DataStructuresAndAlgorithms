class Solution {
    public List<int> postorderTraversal(TreeNode root) {
        // Create an array list to store the solution result...
        List<int> sol = new List<int>();
        // Return the solution answer if the tree is empty...
        if(root==null) return sol;
        // Create an empty stack and push the root node...
        Stack<TreeNode> bag = new Stack<TreeNode>();
        bag.Push(root);
        // Loop till stack is empty...
        while(!bag.isEmpty()) {
            // set peek a node from the stack...
            TreeNode node = bag.Peek();
            // If the subtrees of that node are null, then pop & store the pop value into solution result...
            if(node.left==null && node.right==null) {
                TreeNode pop = bag.Pop();
                sol.Add(pop.val);
            }
            else {
                // Push the right child of the popped node into the stack...
                if(node.right!=null) {
                    bag.Push(node.right);
                    node.right = null;
                }
                // Push the left child of the popped node into the stack...
                if(node.left!=null) {
                    bag.Push(node.left);
                    node.left = null;
                }
            }
        }
        return sol;     // Return the solution list...
    }
}