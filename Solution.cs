class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carry = 0;
        ListNode l3 = new ListNode();
        var result = Recursion(l1, l2, l3, carry);
        return result;
    }

    public ListNode Recursion(ListNode l1, ListNode l2, ListNode l3, int carry)
    {
        if (l1 == null && l2 == null)
        {
            if (carry != 0)
            {
                l3 = new ListNode();
                l3.val = carry;
                return l3;
            }
            else
            {
                return l3;
            }
        }
        else
        {
            l3 = new ListNode();
        }
        int result = 0;
        if (l1 != null && l2 != null)
        {
            result = l1.val + l2.val;
        }
        else if (l1 != null)
        {
            result = l1.val;
        }
        else if (l2 != null)
        {
            result = l2.val;
        }
        result += carry;
        if (result >= 10)
        {
            result = result % 10;
            carry = 1;
        }
        else
        {
            carry = 0;
        }
        l3 = new ListNode(result);
        return Recursion(l1.next, l2.next, l3.next, carry);
    }
}
/*
 #TODO recursion need some fixed to return the result properly.
 */