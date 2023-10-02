// https://leetcode.com/problems/contains-duplicate/
internal class Program
{
    internal  static void Main()
    {
        var nums = new int[] { 1, 2, 3,  };
        var result = ContainsDuplicate_2(nums);
        Console.WriteLine(result);
    }


    // Brute Force
    // 2640ms
    private static bool ContainsDuplicate_0(int[] nums)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }

        return false;
    }
    
    // Sort
    // 214ms
    private static bool ContainsDuplicate_1(int[] nums)
    {
        var list = nums.ToList();
        list.Sort();
        
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (list[i] == list[i + 1]) return true;
        }

        return false;
    }
    
    // ToHashSet
    // 209ms
    private static bool ContainsDuplicate_2(int[] nums)
    {
        var hash = nums.ToHashSet();

        if (hash.Count < nums.Length) return true;
        
        return false;
    }
}