// https://leetcode.com/problems/missing-number/description/

internal class Program
{
    internal static void Main()
    {
        var nums = new int[] { 3,0,1 };
        var result = MissingNumber_1(nums);
        Console.WriteLine(result);
    }

    // Sort + Brute Force
    // 111ms
    private static int MissingNumber_0(int[] nums)
    {
        var n = nums.Length;
        var list = nums.ToList();
        list.Sort();

        for (int i = 0; i < n; i++)
        {
            if (list[i] != i) return i;
        }

        return n;
    }
    
    // XOR
    // x^0=x
    // x^x=0
    // https://habr.com/ru/companies/vdsina/articles/538298/
    private static int MissingNumber_1(int[] nums)
    {
        var n = nums.Length;
        var result = 0;

        for (int i = 0; i < n; i++)
        {
            result ^= nums[i]; // 0^3=3
           // result ^=
        }

        return n;
    }
}