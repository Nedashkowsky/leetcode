// https://leetcode.com/problems/find-all-duplicates-in-an-array/
// todo чтобы снизить расход по памяти можно мутировать исходный массив
internal class Program
{
    internal static void Main()
    {
        var nums = new int[] { 1,1,1 };
        var result = FindDuplicates_1(nums);
        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
    }

    // Dictionary
    // 195ms, beats 82.57%
    private static IList<int> FindDuplicates_0(int[] nums)
    {
        var result = new List<int>();
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.TryAdd(nums[i], i))
            {
                result.Add(nums[i]);
            }
        }

        return result;
    }
    
    // HashSet
    // 206ms, beats 56.88%
    // сложность по памяти O(n), растет линейно, потому что чем больше элементов -- тем больше требуется памяти
    private static IList<int> FindDuplicates_1(int[] nums)
    {
        var result = new List<int>();
        var hashSet = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!hashSet.Add(nums[i]))
            {
                result.Add(nums[i]);
            }
        }

        return result;
    }
    
    // 209ms
    // Этот вариант более правильный на мой взгляд, например, на [1,1,1] тут вернется одна единица, потому что используем в кач-ве результирующего -- массив с уникальными элементами
    // В вариантах выше вернулось бы две единицы, хотя с т.ч. условия задачи, такой вариант входных данных некорректен, т. к. по условию элемент встречается в массиве 1 или 2 раза
    private static IList<int> FindDuplicates_2(int[] nums)
    {
        var result = new HashSet<int>();
        var hashSet = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!hashSet.Add(nums[i]))
            {
                result.Add(nums[i]);
            }
        }

        return result.ToList();
    }
}