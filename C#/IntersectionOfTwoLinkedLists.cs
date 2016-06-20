/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode cur1 = headA, cur2 = headB;
        while(cur1 != cur2)
        {
            cur1 = cur1 != null ? cur1.next : headB;
            cur2 = cur2 != null ? cur2.next : headA;
        }
        return cur1;
    }
}