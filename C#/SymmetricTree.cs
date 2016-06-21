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
    private bool IsSymmetric(TreeNode left, TreeNode right)
    {
        if(null == left || null == right) return left == right;
        
        return left.val == right.val && IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
    }

    public bool IsSymmetric(TreeNode root) {
        if(null == root) return true;
        return IsSymmetric(root.left, root.right);
    }
}


public class Solution2 {

    public bool IsSymmetric(TreeNode root) {
        if(null == root) return true;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root.left);
        stack.Push(root.right);
        while(stack.Count > 0)
        {
            TreeNode right = stack.Pop();
            TreeNode left = stack.Pop();
            if(null == left && null == right) continue;
            if(null == left || null == right) return false;
            if(left.val != right.val) return false;
            stack.Push(left.left);
            stack.Push(right.right);
            stack.Push(right.left);
            stack.Push(left.right);   
        }
        return true;
    }
}