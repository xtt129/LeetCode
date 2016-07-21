public class Heap<T>
{
    private SortedDictionary<T, Queue<T>> heap = new SortedDictionary<T, Queue<T>>();
    private int count;
    public void Add(T key, T value)
    {
        if(!heap.ContainsKey(key)) heap.Add(key, new Queue<T>());
        heap[key].Enqueue(value);
        ++ count;
    }

    public T Pop()
    {
        if(heap.Count == 0) throw new ArgumentNullException();
        var value = heap[heap.Keys.First()];
        T ret = value.Dequeue();
        if(value.Count == 0) heap.Remove(heap.Keys.First());
        -- count;
        return ret;
    }

    public T Peek()
    {
        if(heap.Count == 0) throw new ArgumentNullException();
        return heap.Values.First().Peek();
    }

    public int Count
    {
        get{ return count; }
    }
}
    
public class MedianFinder {
    
    private Heap<double> maxHeap = new Heap<double>();
    private Heap<double> minHeap = new Heap<double>();

    private void Adjust()
    {
        if(minHeap.Count > maxHeap.Count)
        {
             var value = minHeap.Pop();
             maxHeap.Add(-value, value);
        }
        else if(maxHeap.Count > minHeap.Count + 1)
        {
            var value = maxHeap.Pop();
            minHeap.Add(value, value);
        }
    }

    // Adds a num into the data structure.
    public void AddNum(double num) {
        if(maxHeap.Count == 0 || maxHeap.Peek() > num) maxHeap.Add(-num, num);
        else minHeap.Add(num, num);
        Adjust();
    }

    // return the median of current data stream
    public double FindMedian() {
        if(maxHeap.Count > minHeap.Count) return maxHeap.Peek();
        return (maxHeap.Peek() + minHeap.Peek()) / 2;
    }
}

// Your MedianFinder object will be instantiated and called as such:
// MedianFinder mf = new MedianFinder();
// mf.AddNum(1);
// mf.FindMedian();