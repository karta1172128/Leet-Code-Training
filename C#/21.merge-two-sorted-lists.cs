/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode list3 = null, temp = list3;
        int length = 0;
        if (list1 != null)
        {
            length++;
            list3 = new ListNode(list1.val);
            temp = list3;
            while (list1.next != null)
            {
                length++;
                list1 = list1.next;
                temp.next = new ListNode(list1.val);
                temp = temp.next;
            }
        }
        if (list2 != null)
        {
            length++;
            if (list3 != null)
            {
                temp.next = new ListNode(list2.val);
                temp = temp.next;
            }
            else
            {
                list3 = new ListNode(list2.val);
                temp = list3;
            }
            while (list2.next != null)
            {
                length++;
                list2 = list2.next;
                temp.next = new ListNode(list2.val);
                temp = temp.next;
            }
        }
        int[] array = new int[length];
        temp = list3;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = temp.val;
            temp = temp.next;
        }
        Array.Sort(array);
        temp = list3;
        for (int i = 0; i < array.Length; i++)
        {
            temp.val = array[i];
            temp = temp.next;
        }
        return list3;
    }
}
// @lc code=end

