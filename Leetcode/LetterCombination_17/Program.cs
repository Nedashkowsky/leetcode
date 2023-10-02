// https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/

internal class Program
{
    static Dictionary<char, string> _dict = new()
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };

    internal static void Main()
    {
        var result = LetterCombinations("234");

        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
    }

    // рекурсия
    internal static IList<string> LetterCombinations(string digits)
    {
        var chars = digits.ToCharArray();
        var result = new List<string>();
        var values = new List<string>(); // лист для букв: ["abc", "def", "ghi"]

        for (var i = 0; i < chars.Length; i++)
        {
            values.Add(_dict.GetValueOrDefault(chars[i]));
        }
        
        var first = values[0].ToCharArray();
        
        var k = 0;
        for (var j = 0; j < first.Length; j++) // to 3
        {
            var concat = first[j].ToString();
            var n = 1;
            while (n < values.Count) // < 3
            {
                Helper(values[n]); // def
                var second = values[n].ToCharArray(); // [d,e,f]
                concat += second[k].ToString();
                n++;
                result.Add(concat);
            }

            k++;
            result.Add(concat);
        }

        return result;
    }

    private static void Helper(string value)
    {
        
    }
}