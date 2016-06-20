/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head) {
        if(null == head) return head;
        for(var cur = head; cur != null;)
        {
            var next = cur.next;
            var node = new RandomListNode(cur.label);
            cur.next = node;
            node.next = next;
            cur = next;
        }
        for(var cur = head;  cur != null; cur = cur.next.next)
        {
            var node = cur.next;
            if(cur.random != null)
            {
                node.random = cur.random.next;
            }
        }
        RandomListNode newHead = head.next;
        for(RandomListNode cur1 = head, cur2 = newHead; cur1 != null; cur1 = cur1.next, cur2 = cur2.next)
        {
            
            cur1.next = cur2.next;
            cur2.next = cur2.next == null ? null : cur2.next.next;
        }
        return newHead;
    }
}