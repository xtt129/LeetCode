/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {

    public ListNode RotateRight(ListNode head, int k) {
        if(null == head) return head;
        int length = 1;
        ListNode current = head;
        for(; current.next != null; current = current.next, ++length);
        current.next = head;
        k = k % length;
        current = head;
        for(int i = 0; i < length - k - 1; ++i, current = current.next);
        head = current.next;
        current.next = null;
        return head;
    }
}