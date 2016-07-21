/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if(null == lists || lists.Length == 0) return null;
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        SortedDictionary<int, Queue<ListNode>> heap = new SortedDictionary<int, Queue<ListNode>>();
        foreach(ListNode node in lists)
        {
            if(node == null) continue;
            if(!heap.ContainsKey(node.val))
            {
                heap.Add(node.val, new Queue<ListNode>());
            }
            heap[node.val].Enqueue(node);
        }
        while(heap.Count > 0)
        {
            int key = heap.Keys.First();
            ListNode node = heap[key].Dequeue();
            current.next = node;
            current = current.next;
            if(node.next != null)
            {
                if (!heap.ContainsKey(node.next.val))
                {
                    heap.Add(node.next.val, new Queue<ListNode>());
                }
                heap[node.next.val].Enqueue(node.next);
            }
            if (heap[key].Count == 0)
            {
                heap.Remove(key);
            }
        }
        return dummy.next;
    }
}