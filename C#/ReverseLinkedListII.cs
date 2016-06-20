/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 * headPre->head->->->tail->tailNext
 * headPre->tail->->->head->tailNext
 */
public class Solution {

    private void Reverse(ListNode start, ListNode end)
    {
        ListNode next = start.next;
        while(next != null && start != end)
        {
            ListNode temp = next.next;
            next.next = start;
            start = next;
            next = temp;
        }
    }

    public ListNode ReverseBetween(ListNode head, int m, int n) {
        ListNode dummy = new ListNode(0){ next = head };
        ListNode headPre = null, tail = null, tailNext = null, node = dummy;
        for(int i = 0; i <= n; ++i, node = node.next)
        {
            if(i + 1 == m)
            {
                headPre = node;
                head = node.next;
            }
            if(i == n)
            {
                tail = node;
                tailNext = node.next;
            }
        }
        Reverse(head, tail);
        headPre.next  = tail;
        head.next = tailNext;
        return dummy.next;
    }
}