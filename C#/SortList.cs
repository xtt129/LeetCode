/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {

    private ListNode Merge(ListNode list1, ListNode list2)
    {
        ListNode dummy =  new ListNode(0);
        ListNode cur = dummy;
        while(list1 != null && list2 != null)
        {
            if(list1.val < list2.val)
            {
                cur.next = list1;
                list1 = list1.next;
            }
            else
            {
                cur.next = list2;
                list2 = list2.next;
            }
            cur = cur.next;
        }
        cur.next = list1 != null ? list1 : list2;
        return dummy.next;
    }
    
    public ListNode SortList(ListNode head) {
        if(head == null) return head;
        if(head.next == null) return head;
        ListNode slower = head, faster = head;
        while(faster.next != null && faster.next.next != null)
        {
            slower = slower.next;
            faster = faster.next.next;
        }
        ListNode list2 = slower.next;
        slower.next = null;
        ListNode list1 = SortList(head);
        list2 = SortList(list2);
        return Merge(list1, list2);
    }
}