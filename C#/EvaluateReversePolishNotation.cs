public class Solution {
    private string[] operations = new string[4]{ "+", "-", "*", "/" };
    
    private int calculate(int a, int b, string operation)
    {
        switch(operation)
        {
            case "+": return a + b;
            case "-": return a - b;
            case "*": return a * b;
            case "/": return a / b;
        }
        return 0;
    }

    public int EvalRPN(string[] tokens) {
        if(null == tokens) return 0;
        int value = 0;
        Stack<int> stack = new Stack<int>();
        foreach(string token in tokens)
        {
            if(operations.Contains(token))
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(calculate(b, a, token));
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }
        return stack.Pop();
    }
}