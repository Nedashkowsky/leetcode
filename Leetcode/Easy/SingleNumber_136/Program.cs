// https://leetcode.com/problems/single-number/description/

internal class Program
{
    internal static void Main()
    {
        var nums = new int[] { 1 };
        var result = SingleNumber(nums);
        Console.WriteLine(result);
    }

    // 105ms, 44Mb
    private static int SingleNumber(int[] nums)
    {
        var result = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        return result;
    }
}