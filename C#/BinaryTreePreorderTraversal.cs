/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    private void PreorderTraval(TreeNode root, IList<int> order)
    {
        if(null == root) return;
        order.Add(root.val);
        PreorderTraval(root.left, order);
        PreorderTraval(root.right, order);
    }
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> order = new List<int>();
        PreorderTraval(root, order);
        return order;
    }
}


public class Solution2 {
    
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> order = new List<int>();
        if(null == root) return order;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        while(stack.Count > 0 || current != null)
        {
            if(null == current)
            {
                current = stack.Pop().right;
            }
            else
            {
                order.Add(current.val);
                stack.Push(current);
                current = current.left;
            }
        }
        return order;
    }
}