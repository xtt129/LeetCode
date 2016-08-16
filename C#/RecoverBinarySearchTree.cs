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
    
    private void FindWrongNode(TreeNode root, ref TreeNode node1, ref TreeNode node2, ref TreeNode prev)
    {
        if(null == root) return;
        FindWrongNode(root.left, ref node1, ref node2, ref prev);
        if(prev != null && prev.val > root.val)
        {
            if(null == node1)
            {
                node1 = prev;
                node2 = root;
            }
            else
            {
                node2 = root;
            }
        }
        prev = root;
        FindWrongNode(root.right, ref node1, ref node2, ref prev);
    }
    
    public void RecoverTree(TreeNode root) {
        TreeNode node1 = null, node2 = null, prev = null;
        FindWrongNode(root, ref node1, ref node2, ref prev);
        if(node2 != null)
        {
            int tmp = node1.val;
            node1.val = node2.val;
            node2.val = tmp;
        }
    }
}