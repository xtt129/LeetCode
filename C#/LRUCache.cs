public class LRUCache {
    
    private class CacheNode
    {
        public CacheNode prev, next;
        public int value, key;
        public CacheNode(int key, int value)
        {
            this.key = key;
            this.value = value;
            prev = null;
            next = null;
        }
    }
    private CacheNode head = null, tail = null;
    private int capacity;
    Dictionary<int, CacheNode> dict = new Dictionary<int, CacheNode>();
    

    public LRUCache(int capacity) {
        this.capacity = capacity;
    }

    private void MakeRecent(CacheNode node)
    {
        if(node == head) return;
        if(node == tail)
        {
            node.prev.next = null;
            tail = node.prev;
        }
        else
        {
            node.prev.next = node.next;
            node.next.prev = node.prev;
        }
        node.prev = null;
        node.next = head;
        head.prev = node;
        head = node;
    }

    private void Delete()
    {
        int key = tail.key;
        if(tail.prev == null)
        {
             head = null; tail = null;
        }
        else
        {
            tail.prev.next = null;
            tail = tail.prev;
        }
        dict.Remove(key);
    }   

    private void Insert(CacheNode node)
    {
        dict.Add(node.key, node);
        if(head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            node.next = head;
            head.prev = node;
            head = node;
        }
    } 

    public int Get(int key) {
        if(!dict.ContainsKey(key)) return -1;
        CacheNode node = dict[key];
        MakeRecent(node);
        return node.value;
    }

    public void Set(int key, int value) {
        if(dict.ContainsKey(key))
        {
            CacheNode node = dict[key];
            MakeRecent(node);
            node.value = value;
        }
        else
        {
            if(dict.Count == this.capacity)
            {
                 Delete();
            }
            CacheNode node = new CacheNode(key, value);
            Insert(node);
        }
    }
}