// https://leetcode.com/problems/average-of-levels-in-binary-tree/

internal class Program
{
    internal static void Main()
    {
        var root = new TreeNode(2147483647,
            new TreeNode(2147483647),
            new TreeNode(2147483647));

        var result = AverageOfLevels(root);

        foreach (var res in result)
        {
            Console.WriteLine(res);
        }
    }

    public static IList<double> AverageOfLevels(TreeNode root)
    {
        var result = new List<double>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var n = queue.Count;
            var levelSum = 0.0;

            for (var i = 0; i < n; i++)
            {
                var node = queue.Dequeue();
                levelSum += node.val;
                
                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            result.Add(levelSum / n);
        }

        return result;
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