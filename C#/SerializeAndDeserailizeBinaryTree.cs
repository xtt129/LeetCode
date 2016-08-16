/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    private void serializeToStringBuilder(TreeNode root, StringBuilder sb)
    {
        if(root == null) 
        {
            sb.Append("n,");
            return;
        }
        sb.Append(root.val).Append(",");
        serializeToStringBuilder(root.left, sb);
        serializeToStringBuilder(root.right, sb);
    }

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        StringBuilder sb = new StringBuilder();
        serializeToStringBuilder(root, sb);
        return sb.ToString(0, sb.Length - 1);
    }
    
    
    private TreeNode deserializeToTreeNode(Queue<string> tokens)
    {
        string token = tokens.Dequeue();
        if(token == "n") return null;
        TreeNode node = new TreeNode(int.Parse(token));
        node.left = deserializeToTreeNode(tokens);
        node.right = deserializeToTreeNode(tokens);
        return node;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        string[] tokens = data.Split(new char[1]{','}, StringSplitOptions.RemoveEmptyEntries);
        Queue<string> queue = new Queue<string>();
        foreach(var token in tokens)
        {
            queue.Enqueue(token);
        }
        TreeNode root = deserializeToTreeNode(queue);
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));