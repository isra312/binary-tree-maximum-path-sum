namespace BinaryTreeMaximumPathSum;

public class TreeNode(int val, TreeNode left = null, TreeNode right = null)
{
    public int val { get; set; } = val;
    public TreeNode left { get; set; } = left;
    public TreeNode right { get; set; } = right;
}

public class BinaryTree(TreeNode root)
{
    private readonly TreeNode root = root;

    private int? maxPathSum;

    public int GetMaxPathSum()
    {
        Search(root);
        return maxPathSum ?? int.MinValue;
    }

    private int Search(TreeNode node)
    {
        if (node is null)
            return 0;

        var leftSum = Search(node.left);
        var rightSum = Search(node.right);

        maxPathSum = Math.Max(
            maxPathSum ?? node.val,
            node.val + leftSum + rightSum);

        return Math.Max(
            node.val + Math.Max(leftSum, rightSum),
            0);
    }
}
