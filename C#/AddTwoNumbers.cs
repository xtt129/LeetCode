/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(null == l1) return l2;
        if(null == l2) return l1;
        ListNode head = new ListNode(0);
        ListNode current = head;
        int carry = 0;
        while(null != l1 || null != l2)
        {
            current.next = new ListNode(carry);
            current = current.next;
            int num1 = l1 == null ? 0 : l1.val;
            int num2 = l2 == null ? 0 : l2.val;
            current.val += num1 + num2;
            carry = current.val / 10;
            current.val %= 10;
            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
        }
        if(carry > 0)
        {
            current.next = new ListNode(carry);
        }
        return head.next;
    }
}