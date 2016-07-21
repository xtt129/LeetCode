public class Queue {
    Stack<int> stack1 = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();
    // Push element x to the back of queue.
    public void Push(int x) {
        stack1.Push(x);
    }

    // Removes the element from front of queue.
    public void Pop() {
        if(stack2.Count > 0) 
        {
            stack2.Pop();
            return;
        }
        while(stack1.Count > 0) stack2.Push(stack1.Pop());
        stack2.Pop();
    }

    // Get the front element.
    public int Peek() {
        if(stack2.Count > 0) return stack2.Peek();
        while(stack1.Count > 0) stack2.Push(stack1.Pop());
        return stack2.Peek();
    }

    // Return whether the queue is empty.
    public bool Empty() {
        return stack1.Count == 0 && stack2.Count == 0;
    }
}