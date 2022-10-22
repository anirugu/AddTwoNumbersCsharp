namespace AddTwoNumbersCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var result = solution.AddTwoNumbers(l1, l2);
        }
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}