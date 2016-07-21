/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class BSTIterator {

    Stack<TreeNode> stack = new Stack<TreeNode>();

    private void PushLeft(TreeNode root)
    {
        while(null != root)
        {
            stack.Push(root);
            root = root.left;
        }
    }

    public BSTIterator(TreeNode root) {
        PushLeft(root);
    }

    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return stack.Count > 0;
    }

    /** @return the next smallest number */
    public int Next() {
        TreeNode node = stack.Pop();
        if(null != node.right)
        {
            PushLeft(node.right);
        }
        return node.val;
    }
}

/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */