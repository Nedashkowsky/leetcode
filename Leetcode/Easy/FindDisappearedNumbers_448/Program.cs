// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/See https://aka.ms/new-console-template for more information

internal class Program
{
    internal  static void Main()
    {

        var nums = new int[] { 1,1 };
        var result = FindDisappearedNumbers(nums);

        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
    }
    
    // 218ms, 54.6MB
    private static IList<int> FindDisappearedNumbers(int[] nums)
    {
        var hash = nums.ToHashSet();
        var result = new List<int>();
        var list = nums.ToList();
        list.Sort();
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (hash.TryGetValue(list[i], out var val) && val != i+1 && !hash.Contains(i+1))
            {
                result.Add(i+1);
            }
        }

        return result;
    }
}