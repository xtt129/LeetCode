/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if(null == head) return true;
        ListNode pre = null, current = head, fast  =head;
        while(null != fast && null != fast.next)
        {
            fast = fast.next.next;
            ListNode temp = current.next;
            current.next = pre;
            pre = current;
            current = temp;
        }
        ListNode right = null == fast ? current : current.next;
        bool isPal = true;
        while(null != pre)
        {
            isPal = isPal && pre.val == right.val;
            right = right.next;
            ListNode temp = pre.next;
            pre.next = current;
            current = pre;
            pre = temp;
        }
        return isPal;
    }
}