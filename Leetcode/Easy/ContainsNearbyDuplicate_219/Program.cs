// https://leetcode.com/problems/contains-duplicate-ii/description/

internal class Program
{
    internal static void Main()
    {
        var nums = new int[] { 1, 0, 1, 1 };
        var k = 1;
        var result = ContainsNearbyDuplicate(nums, k);
        Console.WriteLine(result);
    }

    // 215ms
    private static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                if (Math.Abs(dict[nums[i]] - i) <= k) return true;
                dict[nums[i]] = i;
            }
            else
            {
                dict.Add(nums[i], i);
            }
        }

        return false;
    }
}