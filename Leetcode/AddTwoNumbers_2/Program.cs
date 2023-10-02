//https://leetcode.com/problems/add-two-numbers/description/
namespace LinkedList;

internal static class Program
{
    public static void Main()
    {
        // var l1 = new ListNode(9, new ListNode(4, new ListNode(3, null)));
        // var l2 = new ListNode(1, new ListNode(6, new ListNode(4, null)));
        // Print(AddTwoNumbers(l1, l2));
        //
        // Print(AddTwoNumbers(new ListNode(0), new ListNode(0)));

        Print(AddTwoNumbers(new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(9,
                                new ListNode(9,
                                    new ListNode(9))))))),
            new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9))))));
    }

    private static void Print(ListNode result)
    {
        while (result != null)
        {
            Console.Write(result.val);
            result = result.next;
        }

        Console.WriteLine();
    }

    // 104ms
    private static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var sum = 0;
        var node = new ListNode();
        var current = node;
        
        while (l1 != null || l2 != null || sum != default)
        {
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }
            
            current.next = new ListNode(sum % 10);
            sum /= 10;
            
            current = current.next;
        }

        return node.next;
    }
}