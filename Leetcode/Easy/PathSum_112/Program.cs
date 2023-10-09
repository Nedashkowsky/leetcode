// https://leetcode.com/problems/path-sum/

internal class Program
{
    internal static void Main()
    {
        var root_1 = new TreeNode(1,
            new TreeNode(2),
            new TreeNode(3));
        var root_2 = new TreeNode(1,
            new TreeNode(2),
            new TreeNode(3));

        var result = HasPathSum(root_1, 22);

        Console.WriteLine(result);
    }
    
    // 95ms
    // 42mb
    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
            return false;
        
        targetSum -= root.val;
        if (root.left == null && root.right == null)
            return targetSum == 0;

        return HasPathSum(root.left, targetSum) 
               || HasPathSum(root.right, targetSum);
    }
}

internal class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}