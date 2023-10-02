// https://leetcode.com/problems/two-sum/description/

internal class Program
{
    internal static void Main()
    {
        var nums = new int[] { 2,7,11,15 };
        var target = 9;
        var result = TwoSum(nums, target);
        if (result != null)
        {
            for (var i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        else
        {
            Console.WriteLine("null");
        }
    }

    // 142ms
    private static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var div = target - nums[i];
            if (dict.ContainsKey(div))
            {
                return new[] { dict[div], i };
            }

            dict.Add(nums[i], i);
        }

        return null;
    }
}