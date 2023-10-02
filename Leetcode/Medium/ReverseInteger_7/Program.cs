// https://leetcode.com/problems/reverse-integer/description/

internal class Program {

    internal static void Main()
    {
        Reverse(123);
    }
    
    private static int Reverse(int x)
    {
        var result = new List<int>();
        var mod = 0;
        while (x > 10)
        {
            mod = x % 10; // 3
            x /= 10; // 12
        }
        
        return 0;
    }
}