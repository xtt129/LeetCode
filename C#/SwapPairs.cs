/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if(null == head) return null;
        ListNode dummy = new ListNode(0) { next = head };
        ListNode prev = dummy;
        for(ListNode p1 = head, p2 = head.next; p1 != null && p2 != null; p1 = prev.next, p2 = null == p1 ? null : p1.next)
        {
            p1.next = p2.next;
            p2.next = p1;
            prev.next = p2;
            prev = p1;
        }
        return dummy.next;
    }
}