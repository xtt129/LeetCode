/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {

    ListNode findKth(ListNode head, int k)
    {
        for(int i = 0; head != null && i < k; ++i)
        {
            head = head.next;
        }
        return head;
    }

    void Reverse(ListNode head, ListNode tail)
    {
        ListNode current = head.next ;
        while(head != tail)
        {
            ListNode temp = current.next;
            current.next = head;
            head = current;
            current = temp;
        }
    }
     
    public ListNode ReverseKGroup(ListNode head, int k) 
    {
        if(null == head || k <= 1) return head;
        ListNode dummy = new ListNode(0){ next = head };
        ListNode headPre = dummy, tail, tailNext;
        tail = findKth(headPre, k);
        while(null != tail)
        {
            tailNext = tail.next;
            Reverse(head, tail);
            headPre.next = tail;
            head.next = tailNext;
            headPre = head;
            head = tailNext;
            tail = findKth(headPre, k);
        }
        return dummy.next;
    }
}