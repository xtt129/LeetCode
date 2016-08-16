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
    
    private void InorderTraval(TreeNode root, IList<int> ans)
    {
        if(null == root) return;
        InorderTraval(root.left, ans);
        ans.Add(root.val);
        InorderTraval(root.right, ans);
    }
    
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> ret = new List<int>();
        InorderTraval(root, ret);
        return ret;
    }
}




public class Solution {
    
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> ret = new List<int>();
        if(null == root) return ret;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        TreeNode current = root.left;
        while(stack.Count > 0 || current != null)
        {
            if(current == null)
            {
                current = stack.Pop();
                ret.Add(current.val);
                current = current.right;
            }
            else
            {
                stack.Push(current);
                current = current.left;
            }
        }
        return ret;
    }
}