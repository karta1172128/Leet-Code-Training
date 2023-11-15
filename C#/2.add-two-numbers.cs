/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode l3 = new ListNode(0);
        ListNode temp = new ListNode(0);
        bool first = false;
        int sum = 0;
        while (l1 != null || l2 != null)
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
            if (!first)
            {
                first = true;
                l3 = null;
                l3 = new ListNode(sum % 10);
                temp = null;
                temp = l3;
            }
            else
            {
                temp.next = new ListNode(sum % 10);
                temp = temp.next;
            }
            sum /= 10;
        }
        if (sum > 0)
            temp.next = new ListNode(sum);
        return l3;
    }
}
// @lc code=end

