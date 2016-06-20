/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(null == head) return head;
        ListNode dummy = new ListNode(head.val - 1){ next = head };
        ListNode pre = dummy, current = head;
        while(current != null)
        {
            if(current.next == null || current.next.val != current.val)
            {
                 pre = current;
                 current = current.next;
            }
            else
            {
                int val = current.val;
                while(current != null && current.val == val) current = current.next;
                pre.next = current;
            }
        }
        return dummy.next;
    }
}