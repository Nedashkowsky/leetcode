// https://leetcode.com/problems/minimum-depth-of-binary-tree/description/

internal class Program
{
    internal static void Main()
    {
        var root = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(4),
            new TreeNode(5)),
            new TreeNode(3));

        var result = MinDepth(root);

        Console.WriteLine(result);
    }

    // runtime 242ms
    // memory 68MB
    public static int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        
        var minDepth = 1;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Any())
        {
            var n = queue.Count;

            for (var i = 0; i < n; i++)
            {
                var node = queue.Dequeue();

                if (node.left == null && node.right == null)
                    return minDepth;

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            minDepth++;
        }

        return minDepth;
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
}