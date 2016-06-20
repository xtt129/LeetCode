/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    
    public ListNode ReverseList(ListNode head) {
        if(null == head || null == head.next) return head;
        ListNode cur = head.next;
        head.next = null;
        while(cur.next != null)
        {
            ListNode temp  = cur.next;
            cur.next = head;
            head = cur;
            cur = temp;
        }
        cur.next = head;
        return cur;
    }
}

public class Solution2 {
    
    private ListNode Reverse(ListNode head, out ListNode tail)
    {
        if(null == head.next)
        {
            tail = head;
            return head;
        }
        ListNode last, newHead;
        newHead = Reverse(head.next, out last);
        last.next = head;
        tail = head;
        head.next = null;
        return newHead;
    }    

    public ListNode ReverseList(ListNode head) {
        if(null == head) return head;
        ListNode newHead, tail;
        newHead = Reverse(head, out tail);
        return newHead;
    }
}