/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode InsertionSortList(ListNode head) {
        if(head == null) return null;
        ListNode dummy = new ListNode(0);
        while(head != null)
        {
            ListNode pre = dummy, cur = dummy.next;
            while(cur!= null && cur.val < head.val)
            {
                cur = cur.next;
                pre = pre.next;
            }
            if(cur == null) 
            {
                pre.next = head;
                head = head.next;
                pre.next.next = null;
            }
            else
            {
                pre.next = head;
                pre = head;
                head = head.next;
                pre.next = cur;    
            }
        }
        return dummy.next;
    }
}