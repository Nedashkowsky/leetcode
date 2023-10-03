// https://leetcode.com/problems/same-tree/solutions/

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

        var result = IsSameTree(root_1, root_2);

        Console.WriteLine(result);
    }

    // 87ms
    // 40MB
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(p);
        queue.Enqueue(q);
        
        while (queue.Any())
        {
            var _p = queue.Dequeue();
            var _q = queue.Dequeue();
            
            if(_p == null && _q == null) continue;
            if(_p == null || _q == null) return false;
            if(_p.val != _q.val) return false;
            
            queue.Enqueue(_p.left);
            queue.Enqueue(_q.left);
            queue.Enqueue(_p.right);
            queue.Enqueue(_q.right);
        }

        return true;
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