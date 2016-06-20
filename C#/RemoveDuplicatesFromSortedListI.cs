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
        ListNode current = head;
        while(null != current)
        {
            ListNode next = current.next;
            while(next != null && current.val == next.val) next = next.next;
            current.next = next;
            current = next;
        }
        return head;
    }
}