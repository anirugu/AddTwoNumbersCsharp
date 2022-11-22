class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode l3 = new ListNode();
        ListNode next = l3;
        int carry = 0;
        while (l1 != null || l2 != null || carry != 0)
        {
            int? value = l1?.val + l2?.val + carry;
            carry = 0;
            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
            if (value > 9)
            {
                carry = 1;
                value = value % 10;
            }
            var temp = new ListNode(value.Value);
            next.next = temp;
            next = next.next;
        }
        return l3.next;
    }
}
