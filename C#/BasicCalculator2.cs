public class Solution {
    public int Calculate(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        Stack<int> stack = new Stack<int>();
        char sign = '+';
        int i = 0;
        while(i < s.Length)
        {
            while(i < s.Length && s[i] == ' ') ++i;
            if(i < s.Length)
            {
                if(char.IsNumber(s[i]))
                {
                    int num = 0;
                    while(i < s.Length && char.IsNumber(s[i])) num = num * 10 + s[i++] - '0';
                    if(sign == '+')
                    {
                        stack.Push(num);
                    }
                    else if(sign == '-')
                    {
                        stack.Push(-num);
                    }
                    else if(sign == '*')
                    {
                        stack.Push(stack.Pop() * num);
                    }
                    else if(sign == '/')
                    {
                        stack.Push(stack.Pop() / num);
                    }
                }
                else sign = s[i++];
            }
        }
        int ans = 0;
        while(stack.Count > 0)
        {
           ans += stack.Pop();
        }
        return ans;
    }
}