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
    private void PostorderTraval(TreeNode root, IList<int> order)
    {
        if(null == root) return;
        PostorderTraval(root.left, order);
        PostorderTraval(root.right, order);
        order.Add(root.val);
    }
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> order = new List<int>();
        PostorderTraval(root, order);
        return order;
    }
}


public class Solution2 {
    
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> order = new List<int>();
        if(null == root) return order;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        while(stack.Count > 0 || current != null)
        {
            if(null == current)
            {
                var parentRight = stack.Pop();
                if(parentRight == null)
                {
                    current = stack.Pop();
                    order.Add(current.val);
                }
                else
                {
                    current = parentRight;
                }
            }
            else
            {
                stack.Push(current);
                stack.Push(current.right);
                current = current.left;
            }
        }
        return order;
    }
}