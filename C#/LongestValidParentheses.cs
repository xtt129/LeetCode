public class Solution {
    
    public int LongestValidParentheses(string s) {
        if(null == s) return 0;
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < s.Length; ++i)
        {
            char ch = s[i];
            if(ch == '(') stack.Push(i);
            else
            {
                if(stack.Count == 0 || s[stack.Peek()] == ')')
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                }
            }
        }
        if(stack.Count == 0) return s.Length;
        int longest = 0, later = s.Length;
        while(stack.Count > 0)
        {
            int pre = stack.Pop();
            longest = Math.Max(longest, later - pre - 1);
            later = pre;
        }
        longest = Math.Max(longest, later);
        return longest;
    }
}